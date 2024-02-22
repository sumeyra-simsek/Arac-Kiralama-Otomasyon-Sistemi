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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=.;Initial Catalog=YTarackiralama;Integrated Security=True";

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbmarka.SelectedIndex == 0)
            {
                cbseri.Items.Clear();
                cbseri.Text = "";

                cbseri.Items.Add("320 i");
                cbseri.Items.Add("M4");
                cbseri.Items.Add("M5");
                cbseri.Items.Add("M6");
                cbseri.Items.Add("M8");
            }
            else if (cbmarka.SelectedIndex == 1)
            {
                cbseri.Items.Clear(); 
                cbseri.Text = ""; 

                cbseri.Items.Add("C63");
                cbseri.Items.Add("E180");
                cbseri.Items.Add("E200");
                cbseri.Items.Add("S300");
                cbseri.Items.Add("C200");
            }
            else if (cbmarka.SelectedIndex == 2)
            {
                cbseri.Items.Clear();
                cbseri.Text = "";

                cbseri.Items.Add("Şahin");
                cbseri.Items.Add("Doğan");
                cbseri.Items.Add("Serçe");
                cbseri.Items.Add("Doğan SLX");
                cbseri.Items.Add("Murat");
            }

            else if (cbmarka.SelectedIndex == 3)
            {
                cbseri.Items.Clear();
                cbseri.Text = "";

                cbseri.Items.Add("Dokker");
                cbseri.Items.Add("Sandero");
                cbseri.Items.Add("Lodgy");
                cbseri.Items.Add("Duster");
                cbseri.Items.Add("Logan");
            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar values (@Plaka,@Marka,@Seri,@Model,@Renk,@Kilometre,@Yakit,@ucret,@Durum)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@Plaka",tbplaka.Text);
            komut.Parameters.AddWithValue("@Marka",cbmarka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri",cbseri.SelectedItem);
            komut.Parameters.AddWithValue("@Model",tbmodel.Text);
            komut.Parameters.AddWithValue("@Renk",tbrenk.Text);
            komut.Parameters.AddWithValue("@Kilometre",tbkm.Text);
            komut.Parameters.AddWithValue("@Yakit",cbyakit.SelectedItem);
            komut.Parameters.AddWithValue("@ucret",tbkira.Text);
            komut.Parameters.AddWithValue("@Durum",cbdurum.SelectedItem);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Araç kaydı başarılı");

        }
    }
}
