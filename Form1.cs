using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arackiralamaproject
{
    public partial class form_anasayfa : Form
    {
        public form_anasayfa()
        {
            InitializeComponent();
        }

        private void btn_müsteriekle_Click(object sender, EventArgs e)
        {
            form_musteriekle musterieklefrm = new form_musteriekle();
            musterieklefrm.Show();
        }

        private void btn_müsterilistele_Click(object sender, EventArgs e)
        {
            MusteriListele musterilistelefrm = new MusteriListele();
            musterilistelefrm.Show();
        }

        private void btn_aracekle_Click(object sender, EventArgs e)
        {
            AracEkle araceklefrm = new AracEkle();
            araceklefrm.Show();
        }

        private void btn_araclistele_Click(object sender, EventArgs e)
        {
            AracListele araclistelefrm = new AracListele();
            araclistelefrm.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sozlesme_Click(object sender, EventArgs e)
        {
            Sozlesme sozlesmefrm = new Sozlesme();
            sozlesmefrm.Show();
        }

        private void btn_satislar_Click(object sender, EventArgs e)
        {
            Satis satisfrm = new Satis();
            satisfrm.Show();
        }
    }
}
