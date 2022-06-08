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
    public partial class sözleşme : Form
    {
        public sözleşme()
        {
            InitializeComponent();
        }
        arackiralama arac = new arackiralama();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(giristarih.Text) - DateTime.Parse(cıkıstarih.Text);
            int gun2 = gun.Days;
            txtgün.Text = gun2.ToString();
            txttutar.Text = (gun2 * int.Parse(txtkira.Text)).ToString();
        }

        private void sözleşme_Load(object sender, EventArgs e)
        {
            boşaraclar();
            yenile();
            txttcno.MaxLength = 11;
            dataGridView1.Columns[0].HeaderText = "İD";
            dataGridView1.Columns[1].HeaderText = "TC NO";
            dataGridView1.Columns[2].HeaderText = "AD SOYAD";
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "EHLİYET NO";
            dataGridView1.Columns[5].HeaderText = "EHLİYET TARİH";
            dataGridView1.Columns[6].HeaderText = "EHLİYET YER";
            dataGridView1.Columns[7].HeaderText = "PLAKA";
            dataGridView1.Columns[8].HeaderText = "MARKA";
            dataGridView1.Columns[9].HeaderText = "SERİ";
            dataGridView1.Columns[10].HeaderText = "YIL";
            dataGridView1.Columns[11].HeaderText = "RENK";
            dataGridView1.Columns[12].HeaderText = "KİRA ÜCRETİ";
            dataGridView1.Columns[13].HeaderText = "GÜN";
            dataGridView1.Columns[14].HeaderText = "TUTAR";
            dataGridView1.Columns[15].HeaderText = "ÇIKIŞ TARİHİ";
            dataGridView1.Columns[16].HeaderText = "DÖNÜŞ TARİHİ";
        }

        private void boşaraclar()
        {
            string sorgu2 = "select * from arac where durumu='BOŞ'";
            arac.bosaraclar(comboarac, sorgu2);
        }

        private void yenile()
        {
            string sorgu3 = "select * from sözlesme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select arac_id,plaka,m.markaadi,s.seriadi,model,r.renk,kira,durumu,tarih,resim,yakıt from arac a join markalar m on a.marka=m.marka_id join seri s on a.seri=s.seri_id join renk r on a.renk=r.renk_id where plaka like '" + comboarac.SelectedItem + "'";
            arac.araccombo (comboarac,txtmarka,txtseri,txtyıl,txtrenk,txtkira,sorgu2);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttcno_TextChanged(object sender, EventArgs e)
        {
            if (txttcno.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from müsteri where tcno like '" +txttcno.Text+"'";
            arac.tcara(txttcno,txtadsoyad,txttel,txtehliyet,txtehliyettarih,txtehliyetyer,sorgu2);
        }

        //private void combokira_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string sorgu2 = "select * from arac where plaka like '" + comboarac.SelectedItem + "'";
        //    arac.hesapla(combokira,txtkira,sorgu2);
        //}

    

        private void temizle()
        {
            cıkıstarih.Text = DateTime.Now.ToShortDateString();
            giristarih.Text = DateTime.Now.ToShortDateString();
         
            txtkira.Text = "";
            txtgün.Text = "";
            txttutar.Text = "";
        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtid.Text = satır.Cells[0].Value.ToString();
            txttcno.Text = satır.Cells[1].Value.ToString();
            txtadsoyad.Text = satır.Cells[2].Value.ToString();
            txttel.Text = satır.Cells[3].Value.ToString();
            txtehliyet.Text = satır.Cells[4].Value.ToString();
            txtehliyettarih.Text = satır.Cells[5].Value.ToString();
            txtehliyetyer.Text = satır.Cells[6].Value.ToString();
            comboarac.Text = satır.Cells[7].Value.ToString();
            txtmarka.Text = satır.Cells[8].Value.ToString();
            txtseri.Text = satır.Cells[9].Value.ToString();
            txtyıl.Text = satır.Cells[10].Value.ToString();
            txtrenk.Text = satır.Cells[11].Value.ToString();
            txtkira.Text = satır.Cells[12].Value.ToString();
            txtgün.Text = satır.Cells[13].Value.ToString();
            txttutar.Text = satır.Cells[14].Value.ToString();
            cıkıstarih.Text = satır.Cells[15].Value.ToString();
            giristarih.Text = satır.Cells[16].Value.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (txtgün.Text=="")
            {
                MessageBox.Show("Gün Sayısı 0 ve Boş Olamaz...", "Hata");
            }
            else
            {
                double gün = double.Parse(txtgün.Text);
                double kira = double.Parse(txtkira.Text);
             txttutar.Text = (gün * kira).ToString();
            }
           
          // txttutar.Text = (int.Parse(txtgün.Text) * int.Parse(txtkira.Text)).ToString();
          
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            cıkıstarih.Text = DateTime.Now.ToShortDateString();
            giristarih.Text = DateTime.Now.ToShortDateString();
            
            txtkira.Text = "";
            txtgün.Text = "";
            txttutar.Text = "";
            txtid.Text = "";
            txttcno.Text = "";
            txtadsoyad.Text = "";
            txttel.Text = "";
            txtehliyetyer.Text = "";
            txtehliyettarih.Text = "";
            txtehliyet.Text = "";
            comboarac.Text = "";
            txtmarka.Text="";
            txtseri.Text = "";
            txtyıl.Text = "";
            txtrenk.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu2 = "insert into sözlesme(tcno,adsoyad,telefon,ehliyetno,ehliyettarih,ehliyetyer,plaka,marka,seri,yıl,renk,kiraücreti,gün,tutar,ctarih,dtarih) values(@tcno,@adsoyad,@telefon,@ehliyetno,@ehliyettarih,@ehliyetyer,@plaka,@marka,@seri,@yıl,@renk,@kiraücreti,@gün,@tutar,@ctarih,@dtarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@tcno", txttcno.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttel.Text);
                komut.Parameters.AddWithValue("@ehliyetno", txtehliyet.Text);
                komut.Parameters.AddWithValue("@ehliyettarih", txtehliyettarih.Text);
                komut.Parameters.AddWithValue("@ehliyetyer", txtehliyetyer.Text);
                komut.Parameters.AddWithValue("@plaka", comboarac.Text);
                komut.Parameters.AddWithValue("@marka", txtmarka.Text);
                komut.Parameters.AddWithValue("@seri", txtseri.Text);
                komut.Parameters.AddWithValue("@yıl", txtyıl.Text);
                komut.Parameters.AddWithValue("@renk", txtrenk.Text);
        
                komut.Parameters.AddWithValue("@kiraücreti", double.Parse(txtkira.Text));
                komut.Parameters.AddWithValue("@gün", double.Parse(txtgün.Text));
                komut.Parameters.AddWithValue("@tutar", double.Parse(txttutar.Text));
                komut.Parameters.AddWithValue("@ctarih", cıkıstarih.Text);
                komut.Parameters.AddWithValue("@dtarih", giristarih.Text);
                arac.ekle_sil_güncelle(komut, sorgu2);
                string sorgu3 = "update arac set durumu='DOLU' where plaka='" + comboarac.Text + "'";
                SqlCommand komut3 = new SqlCommand();
                arac.ekle_sil_güncelle(komut3, sorgu3);
                comboarac.Items.Clear();
                boşaraclar();
                yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboarac.Text = "";
                temizle();

                kayıteklendi kayıt = new kayıteklendi();
                kayıt.ShowDialog();
            }
            catch (Exception)
            {

                kayıteklenemedi kayıt2 = new kayıteklenemedi();
                kayıt2.ShowDialog();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu2 = "update sözlesme set tcno=@tcno,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,ehliyettarih=@ehliyettarih,ehliyetyer=@ehliyetyer,marka=@marka,seri=@seri,yıl=@yıl,renk=@renk,kiraücreti=@kiraücreti,gün=@gün,tutar=@tutar,ctarih=@ctarih,dtarih=@dtarih  where plaka=@plaka";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@tcno", txttcno.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttel.Text);
                komut.Parameters.AddWithValue("@ehliyetno", txtehliyet.Text);
                komut.Parameters.AddWithValue("@ehliyettarih", txtehliyettarih.Text);
                komut.Parameters.AddWithValue("@ehliyetyer", txtehliyetyer.Text);
                komut.Parameters.AddWithValue("@plaka", comboarac.Text);
                komut.Parameters.AddWithValue("@marka", txtmarka.Text);
                komut.Parameters.AddWithValue("@seri", txtseri.Text);
                komut.Parameters.AddWithValue("@yıl", txtyıl.Text);
                komut.Parameters.AddWithValue("@renk", txtrenk.Text);
                
                komut.Parameters.AddWithValue("@kiraücreti", int.Parse(txtkira.Text));
                komut.Parameters.AddWithValue("@gün", int.Parse(txtgün.Text));
                komut.Parameters.AddWithValue("@tutar", int.Parse(txttutar.Text));
                komut.Parameters.AddWithValue("@ctarih", cıkıstarih.Text);
                komut.Parameters.AddWithValue("@dtarih", giristarih.Text);
                arac.ekle_sil_güncelle(komut, sorgu2);

                comboarac.Items.Clear();
                boşaraclar();
                yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboarac.Text = "";
                temizle();
                guncelle guncel = new guncelle();
                guncel.ShowDialog();
            }
            catch (Exception)
            {
                guncellenemedi noguncel = new guncellenemedi();
                noguncel.ShowDialog();
            }
            
        }

        private void giristarih_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(giristarih.Text) - DateTime.Parse(cıkıstarih.Text);
            int gun2 = gun.Days;
            txtgün.Text = gun2.ToString();
        }

        private void cıkıstarih_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(giristarih.Text) - DateTime.Parse(cıkıstarih.Text);
            int gun2 = gun.Days;
            txtgün.Text = gun2.ToString();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string sorgu1 = "delete from sözlesme where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand();
            arac.ekle_sil_güncelle(komut, sorgu1);

            string sorgu2 = "update arac set durumu='BOŞ' where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arac.ekle_sil_güncelle(komut2, sorgu2);

            yenile();
        }

        private void txttcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
