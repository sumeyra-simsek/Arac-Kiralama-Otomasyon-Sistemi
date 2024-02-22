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

namespace Arackiralamaproject
{
    public partial class Sozlesme : Form
    {
        public Sozlesme()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=.;Initial Catalog=YTarackiralama;Integrated Security=True";

        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From Araclar where Durumu ='Boş'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader(); // komudu okut
            while (read.Read())
            {
                cbaraclar.Items.Add(read["Plaka"]);
            }
        }

        public void Sozlesme_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Sozlesme";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void Sozlesme_Load(object sender, EventArgs e)
        {
            Arac_Listele();
            Sozlesme_Listele();

        }

        private void cbaraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
  
            string komutCumlesi = "Select * From Araclar where Plaka like '" + cbaraclar.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tbmarka.Text = read["Marka"].ToString();
                tbseri.Text = read["Seri"].ToString();
                tbmodel.Text = read["Model"].ToString();
                tbrenk.Text = read["Renk"].ToString();
            }
                

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunfarki = DateTime.Parse(dateTimeDonus.Text) - DateTime.Parse(dateTimeCikis.Text);
            int gunhesap = gunfarki.Days;
            tbgun.Text = gunhesap.ToString();
            tbtutar.Text = (gunhesap * int.Parse(tbkiraucreti.Text)).ToString();
        }

        private void cbkirasekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select Kira_Ucreti From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cbkirasekli.SelectedIndex ==0)
                {
                    tbkiraucreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 1).ToString();
                }
                else if (cbkirasekli.SelectedIndex == 1)
                {
                    tbkiraucreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.80).ToString();
                }
                else if (cbkirasekli.SelectedIndex == 2) 
                {
                    tbkiraucreti.Text = (int.Parse(read["Kira_Ucreti"].ToString()) * 0.50).ToString();
                }
            }

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Sozlesme Values(@tcno,@adsoyad,@telefon,@ehliyetno,@ehliyettarih,@plaka,@marka,@seri,@model,@renk,@kirasekil,@kiraucret,@kiralanangun,@tutar,@cikistarih,@donustarih)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@tcno",tbtc.Text);
            komut.Parameters.AddWithValue("@adsoyad",tbadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon",tbtel.Text);
            komut.Parameters.AddWithValue("@ehliyetno",tb_ehliyetno.Text);
            komut.Parameters.AddWithValue("@ehliyettarih",tb_ehliyettarihi.Text);
            komut.Parameters.AddWithValue("@plaka",cbaraclar.Text);
            komut.Parameters.AddWithValue("@marka",tbmarka.Text);
            komut.Parameters.AddWithValue("@seri",tbseri.Text);
            komut.Parameters.AddWithValue("@model",tbmodel.Text);
            komut.Parameters.AddWithValue("@renk",tbrenk.Text);
            komut.Parameters.AddWithValue("@kirasekil",cbkirasekli.Text);
            komut.Parameters.AddWithValue("@kiraucret",tbkiraucreti.Text);
            komut.Parameters.AddWithValue("@kiralanangun",tbgun.Text);
            komut.Parameters.AddWithValue("@tutar",tbtutar.Text);
            komut.Parameters.AddWithValue("@cikistarih",dateTimeCikis.Text);
            komut.Parameters.AddWithValue("@donustarih",dateTimeDonus.Text);

            string komutCumlesiUp = "update Araclar set Durumu= 'Dolu' where Plaka ='" + cbaraclar.SelectedItem + "'";
            SqlCommand komutUp = new SqlCommand(komutCumlesiUp, baglanti);

            komutUp.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Sozlesme_Listele();
            Arac_Listele();
            MessageBox.Show("Kayıt başarılı.");
        
        }

        private void tb_tcara_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Musteriler where Tc_No Like'" + tb_tcara.Text +"'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tbtc.Text = read["Tc_No"].ToString();
                tbadsoyad.Text = read["Ad_Soyad"].ToString();
                tbtel.Text = read["Telefon_Numarasi"].ToString();
            }
        }

        private void btnaracteslim_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            DateTime Bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            int ucret = int.Parse(satir.Cells["Kira_Ucreti"].Value.ToString());
            int tutar = int.Parse(satir.Cells["Tutar"].Value.ToString());
            DateTime cikis = DateTime.Parse(satir.Cells["Cikis_Tarih"].Value.ToString());
            TimeSpan gun = Bugün - cikis;
            int gunu = gun.Days;
            int ToplamTutar = gunu - ucret;

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete from Sozlesme where Plaka='" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();

            string komutCumlesiUp = "Update Araclar set Durumu='Boş' where Plaka='" + satir.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komutUp = new SqlCommand(komutCumlesiUp, baglanti);
            komutUp.ExecuteNonQuery();

            string komutCumlesiSatis = "Insert Into Satis Values(@tc_no,@AdSoyad,@plaka,@gun,@kirasekli,@kiraucret,@tutar,@Cikis_Tarih,@Dönüs_Tarih)";
            SqlCommand komutSatis = new SqlCommand(komutCumlesiSatis, baglanti);

            komutSatis.Parameters.AddWithValue("@tc_no", satir.Cells["Tc_No"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@AdSoyad", satir.Cells["Ad_Soyad"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@plaka", satir.Cells["Plaka"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@gun", gunu);
            komutSatis.Parameters.AddWithValue("@kirasekli", satir.Cells["Kira_Sekli"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@kiraucret", ucret);
            komutSatis.Parameters.AddWithValue("@tutar", ToplamTutar);
            komutSatis.Parameters.AddWithValue("@Cikis_Tarih", satir.Cells["Cikis_Tarih"].Value.ToString());
            komutSatis.Parameters.AddWithValue("@Dönüs_Tarih", satir.Cells["Donus_Tarih"].Value.ToString());

            komutSatis.ExecuteNonQuery();
            
            MessageBox.Show("Araç teslim edildi.");
        }




    }
}
