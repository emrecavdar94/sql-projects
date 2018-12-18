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
    public partial class frmMasterForm : Form
    {
        private SqlConnection baglanti;
        private Personel personel;
        public frmMasterForm(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();
        }

        private void frmMasterForm_Load(object sender, EventArgs e)
        {
            btnYonetim.Enabled = personel.yetkiliMi("Yönetim");
            btnSatis.Enabled = personel.yetkiliMi("Satış");
            btnServis.Enabled = personel.yetkiliMi("Servis");
            //btnKisisel.Text = personel.tamAd();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            frmSatis satisForm = new frmSatis(baglanti, personel);
            satisForm.ShowDialog();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            frmServis servisForm = new frmServis(baglanti, personel);
            servisForm.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar raporlarForm = new frmRaporlar(baglanti);
            raporlarForm.ShowDialog();
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            frmYonetim yonetimForm = new frmYonetim(baglanti, personel);
            yonetimForm.ShowDialog();
        }

        private void btnKisisel_Click(object sender, EventArgs e)
        {

            frmPersonel frmPersonel = new frmPersonel(baglanti, personel);
            frmPersonel.kisiselDoldur();
            frmPersonel.ShowDialog();
        }
    }
}