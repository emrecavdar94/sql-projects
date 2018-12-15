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
    public partial class frmSatis : Form
    {
        private SqlConnection baglanti;
        public long perno;
        public frmSatis(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void gbKisiselBilgiler_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tbMusteriTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTCNoDoldur_Click(object sender, EventArgs e)
        {
            String komut = "SELECT * FROM musteri WHERE tckNo ='" + tbMusteriTCNo.Text + "'";
            SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sqlDA.Fill(DS);

            if (DS.Tables.Count > 0)
            {
                tbAd.Text = DS.Tables[0].Rows[0][1].ToString();
                tbSoyad.Text = DS.Tables[0].Rows[0][2].ToString();
                tbTelNo.Text = DS.Tables[0].Rows[0][4].ToString();
                tbEPosta.Text = DS.Tables[0].Rows[0][5].ToString();
                tbAdres.Text = DS.Tables[0].Rows[0][6].ToString();
            }
        }
    }
}
