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

namespace WindowsFormsApplication10
{
    public partial class aracekle : Form
    {
        public aracekle()
        {
            InitializeComponent();
        }
        arackiralama arackirala = new arackiralama();
        SqlConnection baglantı;

        bool plakadurum;
        protected void plakasorgu()
        {
            SqlConnection baglan = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from arac where plaka=@plaka ", baglan);
            komut.Parameters.AddWithValue("@plaka", txtplaka.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                plakadurum = false;
            }
            else
            {
                plakadurum = true;
            }
            baglan.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int plaka;
            plakasorgu();

                if (txtplaka.TextLength != 7)
                {
                    MessageBox.Show("Plaka 7 Karakterden Oluşmalıdıır...", "Hata");
                }
                else
                {
                    if ((int.TryParse(txtplaka.Text.Substring(0, 2), out a) == true) && (int.TryParse(txtplaka.Text.Substring(5, 2), out b) == true) && (int.TryParse(txtplaka.Text.Substring(2, 1), out c) == false))
                    {
                        if ((plaka = int.Parse(txtplaka.Text.Substring(0, 2))) > 0 && (plaka = int.Parse(txtplaka.Text.Substring(0, 2))) <= 81)
                        {
                            if (plakadurum == true)
                            {
                                if ( txtkiraücreti.Text == "" || pictureBox1.ImageLocation == "")
                                {
                                    bosalan bos = new bosalan();
                                    bos.ShowDialog();
                                }
                                else
                                {
                                    SqlConnection baglantı = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
                                    baglantı.Open();
                                    SqlCommand komut2 = new SqlCommand("INSERT INTO arac(plaka,marka,seri,model,renk,yakıt,kira,resim,durumu,tarih) VALUES('" + txtplaka.Text + "','" + combomarka.SelectedValue + "','" + comboseri.SelectedValue + "','" + combomodel.SelectedValue + "','" + comborenk.SelectedValue + "','" + comboyakıt.SelectedItem + "','" + txtkiraücreti.Text + "','" + pictureBox1.ImageLocation + "','BOŞ','" + DateTime.Now.ToString() + "')", baglantı);
                                    komut2.ExecuteNonQuery();
                                    foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                                    foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                                    pictureBox1.ImageLocation = "";
                                    baglantı.Close();
                                    kayıteklendi kayıt = new kayıteklendi();
                                    kayıt.ShowDialog();
                                }
                            }
                            else
                            {
                                aynikayit kayit = new aynikayit();
                                kayit.ShowDialog();
                                //MessageBox.Show("Aynı Plakada Araç Mevcut...", "Bildiri Ekranı");
                            }
                        }
                        else
                        {
                            MessageBox.Show("İlk 2 Hane 81'den Büyük Olamaz ...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Plaka Formatı Sadece 01M1233 VEYA 01MM123 VEYA 01MMM12 Olmalıdır...");
                    }


                    

                }
                
              }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void aracekle_Load(object sender, EventArgs e)
        {
            txtplaka.MaxLength = 7;
            // TODO: This line of code loads data into the 'arackıralamaDataSet5.renk' table. You can move, or remove it, as needed.
            this.renkTableAdapter.Fill(this.arackıralamaDataSet5.renk);
            // TODO: This line of code loads data into the 'arackıralamaDataSet4.modelyil' table. You can move, or remove it, as needed.
            this.modelyilTableAdapter.Fill(this.arackıralamaDataSet4.modelyil);
            marka();
        }

        private void marka()
        {
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

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.modelyilTableAdapter.FillBy1(this.arackıralamaDataSet4.modelyil);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void txtplaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            markamodel gg = new markamodel();
            gg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marka();
        }
    }
}
