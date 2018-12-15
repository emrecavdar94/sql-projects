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
    public partial class frmRaporlar : Form
    {
        private SqlConnection baglanti;
        public long perno;
        public frmRaporlar(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {

        }
    }
}
