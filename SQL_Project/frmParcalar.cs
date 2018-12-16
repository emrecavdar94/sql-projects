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
    public partial class frmParcalar : Form
    {
        private SqlConnection baglanti;
        public long isEmriNo;
        public frmParcalar(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            String komut = "SELECT * FROM parcalar WHERE ";
            if (tbParcaKodu.Text.Count() > 0 && tbParcaAdi.Text.Count() > 0)
                komut += "parcaKodu LIKE '" + tbParcaKodu.Text + "' AND parcaKodu LIKE '" + tbParcaAdi.Text + "'";
            else if (tbParcaKodu.Text.Count() > 0)
                komut += "parcaKodu LIKE '" + tbParcaKodu.Text + "'";
            else if (tbParcaAdi.Text.Count() > 0)
                komut += "parcaAdi LIKE '" + tbParcaAdi.Text + "'";
            
            if (tbParcaKodu.Text.Count() > 0 || tbParcaAdi.Text.Count() > 0)
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);
                dgParcalar.DataSource = DS.Tables[0];
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
