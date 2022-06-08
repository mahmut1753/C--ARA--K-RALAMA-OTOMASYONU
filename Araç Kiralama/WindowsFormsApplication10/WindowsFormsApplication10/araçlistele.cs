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
    public partial class araçlistele : Form
    {
        arackiralama arackirala = new arackiralama();
        SqlConnection baglantı;
        public araçlistele()
        {
            InitializeComponent();
        }

        private void araçlistele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arackıralamaDataSet3.renk' table. You can move, or remove it, as needed.
            this.renkTableAdapter.Fill(this.arackıralamaDataSet3.renk);
            // TODO: This line of code loads data into the 'arackıralamaDataSet2.modelyil' table. You can move, or remove it, as needed.
            this.modelyilTableAdapter.Fill(this.arackıralamaDataSet2.modelyil);
            aracyanileme();
               comboBox1.SelectedIndex = 0;

               baglantı = new SqlConnection();
               baglantı = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
               DataTable dt = new DataTable();
               SqlDataAdapter da = new SqlDataAdapter("Select * From markalar order by markaadi asc", baglantı);
               da.Fill(dt);
               combomarka.ValueMember = "marka_id";
               combomarka.DisplayMember = "markaadi";
               combomarka.DataSource = dt;
               baglantı.Close();
      
        }
        private void aracyanileme()
        {
            string cümle = "select arac_id,plaka,m.markaadi,s.seriadi,model,r.renk,kira,durumu,tarih,resim,yakıt from arac a join markalar m on a.marka=m.marka_id join seri s on a.seri=s.seri_id join renk r on a.renk=r.renk_id";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackirala.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "ARAÇ İD";
            dataGridView1.Columns[1].HeaderText = "PLAKA";
            dataGridView1.Columns[2].HeaderText = "MARKA";
            dataGridView1.Columns[3].HeaderText = "SERİ";
            dataGridView1.Columns[4].HeaderText = "MODEL";
            dataGridView1.Columns[5].HeaderText = "RENK";
            dataGridView1.Columns[6].HeaderText = "KİRA ÜCRETİ";
            dataGridView1.Columns[7].HeaderText = "DURUMU";
            dataGridView1.Columns[8].HeaderText = "TARİH";
            dataGridView1.Columns[9].HeaderText = "RESİM";
            dataGridView1.Columns[10].HeaderText = "YAKIT";
            
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

  

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedIndex==0)
                {
                    aracyanileme();
                }
                if (comboBox1.SelectedIndex == 1)
                {

                    string cümle = "select arac_id,plaka,m.markaadi,s.seriadi,model,r.renk,kira,durumu,tarih,resim,yakıt from arac a join markalar m on a.marka=m.marka_id join seri s on a.seri=s.seri_id join renk r on a.renk=r.renk_id where durumu='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackirala.listele(adtr2, cümle);
                }
                if (comboBox1.SelectedIndex == 2)
                {

                    string cümle = "select arac_id,plaka,m.markaadi,s.seriadi,model,r.renk,kira,durumu,tarih,resim,yakıt from arac a join markalar m on a.marka=m.marka_id join seri s on a.seri=s.seri_id join renk r on a.renk=r.renk_id where durumu='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackirala.listele(adtr2, cümle);
                }
            }
            catch
            {
                
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combomarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combomarka.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from seri  where markaadi='" + combomarka.SelectedValue + "' order by seriadi asc", baglantı);
                da.Fill(dt);
                comboseri.ValueMember = "seri_id";
                comboseri.DisplayMember = "seriadi";
                comboseri.DataSource = dt;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                string cümle = "update arac set plaka=@plaka,marka=@marka,seri=@seri,model=@model,renk=@renk,yakıt=@yakıt,kira=@kira,resim=@resim where arac_id=@id ";
                SqlCommand komut2 = new SqlCommand();

                komut2.Parameters.AddWithValue("@id", txtid.Text);
                komut2.Parameters.AddWithValue("@plaka", txtplaka.Text);
                komut2.Parameters.AddWithValue("@marka", combomarka.SelectedValue);
                komut2.Parameters.AddWithValue("@seri", comboseri.SelectedValue);
                komut2.Parameters.AddWithValue("@model", combomodel.SelectedValue);
                komut2.Parameters.AddWithValue("@renk", comborenk.SelectedValue);
                komut2.Parameters.AddWithValue("@yakıt", comboyakıt.SelectedItem);
                komut2.Parameters.AddWithValue("@kira", txtkiraücreti.Text);
                komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                arackirala.ekle_sil_güncelle(komut2, cümle);

                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                pictureBox1.ImageLocation = "";
                aracyanileme();
                guncelle guncel = new guncelle();
                guncel.ShowDialog();
            }
            catch (Exception)
            {

                guncellenemedi noguncel = new guncellenemedi();
                noguncel.ShowDialog();
                
            }
            
        }

        private void btnsil_Click(object sender, EventArgs e)
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
                    string cümle = "delete from arac where plaka='" + satır.Cells["plaka"].Value.ToString() + "' ";
                    SqlCommand komut2 = new SqlCommand();
                    arackirala.ekle_sil_güncelle(komut2, cümle);
                    aracyanileme();
                    foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                    foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                    pictureBox1.ImageLocation = "";

                    MessageBox.Show("Kayıt Başarıyla Silindi...", "Hata");
                }
                

            }
            catch (Exception)
            {
                hataformu hata = new hataformu();
                hata.ShowDialog();
                //MessageBox.Show("Kayıt Silinemedi...", "Hata");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtid.Text = satır.Cells["arac_id"].Value.ToString();
            txtplaka.Text = satır.Cells["plaka"].Value.ToString();
            combomarka.Text = satır.Cells["markaadi"].Value.ToString();
            comboseri.Text = satır.Cells["seriadi"].Value.ToString();
            combomodel.Text = satır.Cells["model"].Value.ToString();
            comborenk.Text = satır.Cells["renk"].Value.ToString();
            comboyakıt.Text = satır.Cells["yakıt"].Value.ToString();
            txtkiraücreti.Text = satır.Cells["kira"].Value.ToString();
            pictureBox1.ImageLocation = satır.Cells["resim"].Value.ToString();
        }
    }
}
