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
    public partial class form_musteriekle : Form
    {
        public form_musteriekle()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=.;Initial Catalog=YTarackiralama;Integrated Security=True";

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Musteriler Values (@Tcno,@AdSoyad,@TelefonNo,@Mail,@adres)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@Tcno", tb_tcno.Text);
            komut.Parameters.AddWithValue("AdSoyad", tb_adsoyad.Text);
            komut.Parameters.AddWithValue("@TelefonNo", maskedtb_telno.Text);
            komut.Parameters.AddWithValue("@Mail", tb_eposta.Text);
            komut.Parameters.AddWithValue("@Adres", tb_adres.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt başarılı.");
                

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
