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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        int mov;
        int movX;
        int movY;

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglantı;
         
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            baglantı = new SqlConnection();
            baglantı = new SqlConnection("Data Source =HPPAVILION; Initial Catalog = arackıralama ; Integrated Security=True");
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("Select * from admin where adminkul='" + txtkuladi.Text + "' and adminsifre= '" + txtparola.Text + "' ", baglantı);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
            this.Hide();
            anasayfa geciş = new anasayfa();
            geciş.ShowDialog();
            }
            else
            {
                label2.Text = "Kullanıcı Adı Veya Sifre Yanlıs...";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void txtkuladi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtparola_OnValueChanged(object sender, EventArgs e)
        {
          
        }

        private void txtkuladi_MouseClick(object sender, MouseEventArgs e)
        {
            txtkuladi.Text = "";
        }

        private void txtparola_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;           
        }

        private void txtkuladi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
