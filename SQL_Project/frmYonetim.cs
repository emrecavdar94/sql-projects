using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Project
{
    public partial class frmYonetim : Form
    {
        private SqlConnection baglanti;
        private Personel personel;
        public frmYonetim(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            frmYetkiler yetkilerForm = new frmYetkiler(baglanti, personel);
            yetkilerForm.ShowDialog();
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            frmArac frmArac = new frmArac(baglanti, personel);
            frmArac.ShowDialog();

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri(baglanti, personel);
            frmMusteri.ShowDialog();
        }

        private void btnSistemSabitleri_Click(object sender, EventArgs e)
        {
            frmSistemSabitleri frmSistemSabitleri = new frmSistemSabitleri(baglanti, personel);
            frmSistemSabitleri.ShowDialog();
        }

        private void btnYedekleGeriYukle_Click(object sender, EventArgs e)
        {
            frmYedekleGeriYukle yedekleGeriYukleForm = new frmYedekleGeriYukle(baglanti, personel);
            yedekleGeriYukleForm.ShowDialog();
        }

        private void btnParcalar_Click(object sender, EventArgs e)
        {
            frmParcalar parcalarForm = new frmParcalar(baglanti, personel);
            parcalarForm.ShowDialog();
        }
    }
}
