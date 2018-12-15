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
        public long perno;
        public frmYonetim(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            frmYetkiler yetkilerForm = new frmYetkiler(baglanti);
            yetkilerForm.ShowDialog();
        }
    }
}
