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
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=.;Initial Catalog=YTarackiralama;Integrated Security=True";

        private void cbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbmarka.SelectedIndex == 0)
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

        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi); 
            baglanti.Open();

            string komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti); 
            SqlDataAdapter da = new SqlDataAdapter(komut); 
            DataTable dt = new DataTable(); 
            da.Fill(dt); 
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }



        private void AracListele_Load(object sender, EventArgs e)
        {
            Arac_Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Araclar set Marka=@marka, Seri=@seri, Model=@Model, Renk=@Renk , Kilometre=@Km , Yakit=@yakit, Kira_Ucreti=@Ucret, Durumu=@Durum Where Plaka=@plaka";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@plaka", tbplaka.Text);
            komut.Parameters.AddWithValue("@marka", cbmarka.Text);
            komut.Parameters.AddWithValue("@seri", cbseri.Text);
            komut.Parameters.AddWithValue("@Model", tbmodel.Text);
            komut.Parameters.AddWithValue("@Renk",tbrenk.Text);
            komut.Parameters.AddWithValue("@Km", tbkm.Text);
            komut.Parameters.AddWithValue("@yakit", cbyakit.Text );
            komut.Parameters.AddWithValue("@Ucret",tbkira.Text);
            komut.Parameters.AddWithValue("@Durum", cbdurum.Text);


            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete From Araclar where Plaka='" + dataGridView2.CurrentRow.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             tbplaka.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
             cbmarka.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
             cbseri.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
             tbmodel.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
             tbrenk.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
             tbkm.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
             cbyakit.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
             tbkira.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
             cbdurum.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
