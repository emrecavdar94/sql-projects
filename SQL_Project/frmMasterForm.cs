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
            frmPersonel personel = new frmPersonel();
            personel.ShowDialog();
        }

        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteri musteri = new frmMusteri();
            musteri.ShowDialog();
        }

        private void aracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArac arac = new frmArac();
            arac.ShowDialog();
        }

        private void frmMasterForm_Load(object sender, EventArgs e)
        {
            lblMasterKarsilama.Text = perno.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSatis frmSatis = new frmSatis();
            frmSatis.ShowDialog();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            frmServis frmServis = new frmServis();
            frmServis.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYonetim_Click(object sender, EventArgs e)
        {
            frmYonetim frmYonetim = new frmYonetim();
            frmYonetim.ShowDialog();
        }
    }
}
