using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication10.bildirim_ekranları;
namespace WindowsFormsApplication10
{
    public partial class müşterilistele : Form
    {
        arackiralama arackirala = new arackiralama();
        SqlConnection baglantı;
        public müşterilistele()
        {
            InitializeComponent();
        }

        private void müşterilistele_Load(object sender, EventArgs e)
        {
            
            yenilelistele();
            baglantı = new SqlConnection();
            baglantı = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From Iller", baglantı);
            da.Fill(dt);
            comboil.ValueMember = "IlID";
            comboil.DisplayMember = "Il";
            comboil.DataSource = dt;

        }

        private void yenilelistele()
        {
            string cümle = "select müsteri_id,tcno,adsoyad,telefon,i.Il,e.Ilce,adres,ehliyetno,ehliyettarih,ehliyetyer from müsteri m join Iller i  on m.il=i.IlID   join Ilceler e on m.ilce=e.IlceID ";

            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackirala.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "İD";
             dataGridView1.Columns[1].HeaderText = "TC NO";
            dataGridView1.Columns[2].HeaderText = "AD SOYAD";
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "İL";
            dataGridView1.Columns[5].HeaderText = "İLÇE";
            dataGridView1.Columns[6].HeaderText = "ADRES";
            dataGridView1.Columns[7].HeaderText = "EHLİYET NO";
            dataGridView1.Columns[8].HeaderText = "EHLİYET TARİHİ";
            dataGridView1.Columns[9].HeaderText = "EHLİYET YERİ";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select * from müsteri where tcno like '%"+textBox6.Text+"%' ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackirala.listele(adtr2, cümle);

        }

     

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "update müsteri set tcno=@tcno,adsoyad=@adsoyad,telefon=@telefon,il=@il,ilce=@ilce,adres=@adres,ehliyetno=@ehliyetno,ehliyettarih=@ehliyettarih,ehliyetyer=@ehliyetyer where müsteri_id=@id ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@id", txtid.Text);
                komut2.Parameters.AddWithValue("@tcno", txttc.Text);
                komut2.Parameters.AddWithValue("@adsoyad", txtadsoy.Text);
                komut2.Parameters.AddWithValue("@telefon", txttel.Text);
                komut2.Parameters.AddWithValue("@il", comboil.SelectedValue);
                komut2.Parameters.AddWithValue("@ilce", comboilce.SelectedValue);
                komut2.Parameters.AddWithValue("@adres", txtadres.Text);
                komut2.Parameters.AddWithValue("@ehliyetno", txtehliyetno.Text);
                komut2.Parameters.AddWithValue("@ehliyettarih", txtehliyettarih.Text);
                komut2.Parameters.AddWithValue("@ehliyetyer", txtehliyetyer.Text);

                arackirala.ekle_sil_güncelle(komut2, cümle);
                foreach (Control item in Controls)
                    if (item is TextBox)
                        item.Text = "";
                yenilelistele();
                guncelle guncel = new guncelle();
                guncel.ShowDialog();
            }
            catch (Exception)
            {

                guncellenemedi noguncel = new guncellenemedi();
                noguncel.ShowDialog();
            }
            
            

        }

     

        private void comboil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboil.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from Ilceler where IlID=" + comboil.SelectedValue, baglantı);
                da.Fill(dt);
                comboilce.ValueMember = "IlceID";
                comboilce.DisplayMember = "Ilce";
                comboilce.DataSource = dt;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult giriskapanis = MessageBox.Show("Kayıt'ı Silmek İstediğinizden Eminmisiniz ? ", "Bildirim Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (giriskapanis == DialogResult.No)
                {
                    ((FormClosingEventArgs)e).Cancel = true;
                    return;

                }
                else
                {
                    DataGridViewRow satır = dataGridView1.CurrentRow;
                    string cümle = "delete from müsteri where tcno='" + satır.Cells["tcno"].Value.ToString() + "'";
                    SqlCommand komut2 = new SqlCommand();
                    arackirala.ekle_sil_güncelle(komut2, cümle);
                    MessageBox.Show("Kayıt Başarıyla Silindi...", "Bildiri Ekranı");

                    yenilelistele();
                }

                
            }
            catch (Exception)
            {
                hataformu hata = new hataformu();
                hata.ShowDialog();
                //MessageBox.Show("Kayıt Silinemedi...", "Hata");
                
            }
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtid.Text = satır.Cells[0].Value.ToString();
            txttc.Text = satır.Cells[1].Value.ToString();
            txtadsoy.Text = satır.Cells[2].Value.ToString();
            txttel.Text = satır.Cells[3].Value.ToString();
            comboil.Text = satır.Cells[4].Value.ToString();
            comboilce.Text = satır.Cells[5].Value.ToString();
            txtadres.Text = satır.Cells[6].Value.ToString();
            txtehliyetno.Text = satır.Cells[7].Value.ToString();
            txtehliyettarih.Text = satır.Cells[8].Value.ToString();
            txtehliyetyer.Text = satır.Cells[9].Value.ToString();
        }

      
    }
}
