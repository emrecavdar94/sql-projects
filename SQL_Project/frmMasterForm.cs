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
        public long perno;
        public frmMasterForm(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void frmMasterForm_Load(object sender, EventArgs e)
        {
            lblMasterKarsilama.Text = perno.ToString();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            frmSatis satisForm = new frmSatis(baglanti);
            satisForm.perno = perno;
            satisForm.ShowDialog();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            frmServis servisForm = new frmServis(baglanti);
            servisForm.perno = perno;
            servisForm.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar raporlarForm = new frmRaporlar(baglanti);
            raporlarForm.perno = perno;
            raporlarForm.ShowDialog();
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            frmYonetim yonetimForm = new frmYonetim(baglanti);
            yonetimForm.perno = perno;
            yonetimForm.ShowDialog();
        }
    }
}