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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=.;Initial Catalog=YTarackiralama;Integrated Security=True";

        private void Satis_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Satis";
            SqlCommand komut = new SqlCommand(komutCumlesi,baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
