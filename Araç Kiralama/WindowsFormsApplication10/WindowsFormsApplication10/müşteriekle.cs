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
    public partial class müşteriekle : Form
    {
        arackiralama arackira = new arackiralama();
        SqlConnection baglantı;
        public müşteriekle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void müşteriekle_Load(object sender, EventArgs e)
        {
            txttel.MaxLength = 11;
            txttc.MaxLength = 11;
            baglantı = new SqlConnection();
            baglantı = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Iller",baglantı);
            da.Fill(dt);
            comboil.ValueMember = "IlID";
            comboil.DisplayMember = "Il";
            comboil.DataSource = dt;
            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {


            if (txttc.Text == "" || txtadsoy.Text == "" || txttel.Text == "" || txtadres.Text == ""|| comboil.Text=="" || comboilce.Text==""|| txtadres.Text==""||txtehliyetno.Text==""|| txtehliyettarih.Text==""||txtehliyetyer.Text=="" )
            {MessageBox.Show("Boş Değer Girilemez","Bilgilendirme Penceresi");

            
            }
            else
            {
                string cümle = "insert into müsteri(tcno,adsoyad,telefon,il,ilce,adres,ehliyetno,ehliyettarih,ehliyetyer) values(@tcno,@adsoyad,@telefon,@il,@ilce,@adres,@ehliyetno,@ehliyettarih,@ehliyetyer) ";
            SqlCommand komut2 = new SqlCommand();
            
            komut2.Parameters.AddWithValue("@tcno", txttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad",txtadsoy.Text);
            komut2.Parameters.AddWithValue("@telefon", txttel.Text);
            komut2.Parameters.AddWithValue("@il",comboil.SelectedValue);
            komut2.Parameters.AddWithValue("@ilce", comboilce.SelectedValue);
            komut2.Parameters.AddWithValue("@adres", txtadres.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtehliyetno.Text);
            komut2.Parameters.AddWithValue("@ehliyettarih", txtehliyettarih.Text);
            komut2.Parameters.AddWithValue("@ehliyetyer", txtehliyetyer.Text);
               


        
            arackira.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls)
                if (item is TextBox)
                    item.Text = "";

            MessageBox.Show("Müşteri Eklendi", "Bildirim Ekranı");

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;  
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
        bool tcno;
        protected void tcnosorgu()
        {
            SqlConnection baglan = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from müsteri where tcno=@tcno ", baglan);
            komut.Parameters.AddWithValue("@tcno", txttc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                tcno = false;
            }
            else
            {
                tcno = true;
            }
            baglan.Close();
        }

        bool ehliyetno;
        protected void ehliyetsorgu()
        {
            SqlConnection baglan = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from müsteri where ehliyetno=@ehliyetno ", baglan);
            komut.Parameters.AddWithValue("@ehliyetno", txtehliyetno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ehliyetno = false;
            }
            else
            {
                ehliyetno = true;
            }
            baglan.Close();
        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            tcnosorgu();
            ehliyetsorgu();
            if (txttc.TextLength != 11)
            {
                MessageBox.Show("TC NO 11 Karakterden Oluşmalıdır...", "Hata");
            }
            else
            {


                if (tcno == true && ehliyetno==true)
                {
                    

                    if (txttc.Text == "" || txtadsoy.Text == "" || txttel.Text == "" || txtadres.Text == "" || comboil.Text == "" || comboilce.Text == "" || txtadres.Text == "" || txtehliyetno.Text == "" || txtehliyettarih.Text == "" || txtehliyetyer.Text == "")
                    {
                        bosalan bos = new bosalan();
                        bos.ShowDialog();


                    }
                    else
                    {
                        string cümle = "insert into müsteri(tcno,adsoyad,telefon,il,ilce,adres,ehliyetno,ehliyettarih,ehliyetyer) values(@tcno,@adsoyad,@telefon,@il,@ilce,@adres,@ehliyetno,@ehliyettarih,@ehliyetyer) ";
                        SqlCommand komut2 = new SqlCommand();

                        komut2.Parameters.AddWithValue("@tcno", txttc.Text);
                        komut2.Parameters.AddWithValue("@adsoyad", txtadsoy.Text);
                        komut2.Parameters.AddWithValue("@telefon", txttel.Text);
                        komut2.Parameters.AddWithValue("@il", comboil.SelectedValue);
                        komut2.Parameters.AddWithValue("@ilce", comboilce.SelectedValue);
                        komut2.Parameters.AddWithValue("@adres", txtadres.Text);
                        komut2.Parameters.AddWithValue("@ehliyetno", txtehliyetno.Text);
                        komut2.Parameters.AddWithValue("@ehliyettarih", txtehliyettarih.Text);
                        komut2.Parameters.AddWithValue("@ehliyetyer", txtehliyetyer.Text);
                        arackira.ekle_sil_güncelle(komut2, cümle);
                        foreach (Control item in Controls)
                            if (item is TextBox)
                                item.Text = "";

                        kayıteklendi kayıt = new kayıteklendi();
                        kayıt.ShowDialog();

                    }

                }
                else
                {
                    tcehliyet  kayit = new tcehliyet();
                    kayit.ShowDialog();
                    //MessageBox.Show("Aynı Tcno Kaydı Mevcut...", "Bildiri Ekranı");
                }
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
