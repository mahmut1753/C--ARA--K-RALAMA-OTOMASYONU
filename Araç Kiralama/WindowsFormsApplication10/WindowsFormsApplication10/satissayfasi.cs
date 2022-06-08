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
    public partial class satissayfasi : Form
    {
        public satissayfasi()
        {
            InitializeComponent();
        }
        arackiralama arackirala = new arackiralama();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void satissayfasi_Load(object sender, EventArgs e)
        {
            string sorgu3 = "select * from sözlesme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackirala.listele(adtr2, sorgu3);
            arackirala.satis(label1);
        }
    }
}
