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
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=.;Initial Catalog=YTarackiralama;Integrated Security=True";
        
        private void MusteriListele_Load(object sender, EventArgs e)
        {
            Musteri_Listele();
        }

        public void Musteri_Listele() // fonksiyon
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi); // baglanti degiskenine atadık sql baglantisini
            baglanti.Open(); 

            string komutCumlesi = "Select * From Musteriler";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti); // komut cumlesiyle baglantiyi bagladik.
            SqlDataAdapter da = new SqlDataAdapter(komut); // sqldataadapteri actık ixine komutu attık
            DataTable dt = new DataTable(); // datatable olusturduk.
            da.Fill(dt); // musterileri da dan fill yapıp dtye listeledik. datatble a listeledik
            dataGridView1.DataSource = dt; // datagrde dt yi aktardık
            baglanti.Close();
  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_tcno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_adsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedtb_telno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_eposta.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_adres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Musteriler set Ad_Soyad=@adsoyad, Telefon_Numarasi=@Telno, Mail=@Mail, Adres=@adres Where Tc_No=@Tc";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Tc", tb_tcno.Text);
            komut.Parameters.AddWithValue("@adsoyad", tb_adsoyad.Text);
            komut.Parameters.AddWithValue("@Telno", maskedtb_telno.Text);
            komut.Parameters.AddWithValue("@Mail", tb_eposta.Text);
            komut.Parameters.AddWithValue("@adres", tb_adres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete From Musteriler where Tc_No='" + dataGridView1.CurrentRow.Cells["Tc_No"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
