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

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonel personelForm = new frmPersonel(baglanti);
            personelForm.ShowDialog();
        }

        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteri musteriForm = new frmMusteri();
            musteriForm.ShowDialog();
        }

        private void aracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArac aracForm = new frmArac();
            aracForm.ShowDialog();
        }

        private void frmMasterForm_Load(object sender, EventArgs e)
        {
            lblMasterKarsilama.Text = perno.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSatis satisForm = new frmSatis();
            satisForm.ShowDialog();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            frmServis servisForm = new frmServis();
            servisForm.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar raporlarForm = new frmRaporlar();
            raporlarForm.ShowDialog();
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            frmYonetim yonetimForm = new frmYonetim();
            yonetimForm.ShowDialog();
        }
    }
}
