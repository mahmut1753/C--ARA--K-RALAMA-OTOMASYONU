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
    public partial class markamodel : Form
    {

        public markamodel()
        {
            InitializeComponent();
        }
        SqlConnection baglantı;
        arackiralama arackirala = new arackiralama();
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void markamodel_Load(object sender, EventArgs e)
        {
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
        bool markadurum;
        protected void markasorgu()
        {
            SqlConnection baglan = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from markalar where markaadi=@marka ", baglan);
            komut.Parameters.AddWithValue("@marka", txtmarka.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                markadurum = false;
            }
            else
            {
                markadurum = true;
            }
            baglan.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            markasorgu();
            if (markadurum==true)
            {
                if (txtmarka.Text=="")
                {
                    bosalan bos = new bosalan();
                    bos.ShowDialog();
                }
                else
                {
                    string cümle = "insert into markalar(markaadi) values(@marka) ";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.AddWithValue("@marka", txtmarka.Text);
                    arackirala.ekle_sil_güncelle(komut2, cümle);
                    txtmarka.Text = "";
                    kayıteklendi kayıt = new kayıteklendi();
                    kayıt.ShowDialog();
                }
            }
            else
            {
                aynikayit kayit = new aynikayit();
                kayit.ShowDialog();
            }
            


            marka();
        }
        bool modeldurum;
        protected void modelsorgu()
        {
            SqlConnection baglan = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from seri where seriadi=@seri ", baglan);
            komut.Parameters.AddWithValue("@seri", txtmodel.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                modeldurum = false;
            }
            else
            {
                modeldurum = true;
            }
            baglan.Close();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            modelsorgu();
            if (modeldurum == true)
            {
                if (txtmodel.Text == "")
                {
                    bosalan bos = new bosalan();
                    bos.ShowDialog();
                }
                else
                {
                    string cümle = "insert into seri(markaadi,seriadi) values(@marka,@seriadi) ";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.AddWithValue("@marka", combomarka.SelectedValue);
                    komut2.Parameters.AddWithValue("@seriadi", txtmodel.Text);
                    arackirala.ekle_sil_güncelle(komut2, cümle);
                    txtmodel.Text = "";
                    kayıteklendi kayıt = new kayıteklendi();
                    kayıt.ShowDialog();
                }
            }
            else
            {
                aynikayit kayit = new aynikayit();
                kayit.ShowDialog();
            }
        }
    }
}
