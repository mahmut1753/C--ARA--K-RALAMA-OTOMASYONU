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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        arackiralama arackirala = new arackiralama();
        SqlConnection baglantı;
        private void anasayfa_Load(object sender, EventArgs e)
        {
            
            try
            {
              müsterisayisi();
              aracsayisi();
              satiş();
            }
            catch (Exception)
            {

                MessageBox.Show("Veri Tabanı Bağlantısında Hata", "Bildirim Ekranı");
            }
            

        }
        private void satiş()
        {
            baglantı = new SqlConnection();
            baglantı = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * From sözlesme", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label8.Text = dt.Rows.Count.ToString();
            
            
        }

        private void aracsayisi()
        {
            baglantı = new SqlConnection();
            baglantı = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * From arac", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label7.Text = dt.Rows.Count.ToString();
        }

        private void müsterisayisi()
        {
            baglantı = new SqlConnection();
            baglantı = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * From müsteri", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            label5.Text = dt.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            müşteriekle git = new müşteriekle();
            git.ShowDialog();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            müşterilistele g = new müşterilistele();
            g.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            aracekle gg = new aracekle();
            gg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            araçlistele ii = new araçlistele();
            ii.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            sözleşme giti = new sözleşme();
            giti.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            satissayfasi gitt = new satissayfasi();
            gitt.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            müsterisayisi();
            aracsayisi();
            satiş();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void müsteriekle1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/"); 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/"); 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/"); 
        }

     
    }
}
