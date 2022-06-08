using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    class arackiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=HPPAVILION;Initial Catalog=arackıralama;Integrated Security=True;");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut,string sorgu)
        {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = sorgu;
                komut.ExecuteNonQuery();
                baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void bosaraclar(System.Windows.Forms.ComboBox combo,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());  
            }
            baglanti.Close();
        }
        public void tcara(TextBox tc,TextBox adsoyad,TextBox telefon,TextBox ehliyetno,TextBox ehliyettarih,TextBox ehliyetyer, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adsoyad.Text=read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
                ehliyetno.Text = read["ehliyetno"].ToString();
                ehliyettarih.Text = read["ehliyettarih"].ToString();
                ehliyetyer.Text = read["ehliyetyer"].ToString();
                
            }
            baglanti.Close();
        }

        //public void hesapla(ComboBox combokirasekli,TextBox ucret , string sorgu)
        //{
        //    baglanti.Open();
        //    SqlCommand komut = new SqlCommand(sorgu, baglanti);
        //    SqlDataReader read = komut.ExecuteReader();
        //    while (read.Read())
        //    {
        //        if (combokirasekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kira"].ToString()) * 1).ToString();
        //        if (combokirasekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kira"].ToString()) * 0.80).ToString();
        //        if (combokirasekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kira"].ToString()) * 0.70).ToString();
                

        //    }
        //    baglanti.Close();
        //}


        public void araccombo(ComboBox araclar, TextBox marka, TextBox seri, TextBox model,TextBox renk,TextBox kira, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["markaadi"].ToString();
                seri.Text = read["seriadi"].ToString();
                model.Text = read["model"].ToString();
                renk.Text = read["renk"].ToString();
                kira.Text = read["kira"].ToString();

            }
            baglanti.Close();
        }
        public void satis(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from sözlesme",baglanti);
            lbl.Text = "Toplam Tutar=" + komut.ExecuteScalar() + "TL";
            baglanti.Close();
        }


        //internal void satis(Label label1)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
