using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Project
{
    public partial class frmParca : Form
    {
        private SqlConnection baglanti;
        private Personel personel;
        public frmParca(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();
        }

        private void frmParca_Load(object sender, EventArgs e)
        {

        }

        private void btnParcaDoldur_Click(object sender, EventArgs e)
        {
            String komut = "SELECT parcaAdi, parcaIscilik, parcaTutari FROM parca WHERE parcaKodu = '" + tbParcaKodu.Text + "'";
            SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sqlDA.Fill(DS);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                tbParcaAdi.Text = DS.Tables[0].Rows[0][0].ToString();
                tbIscilik.Text = Convert.ToDouble(DS.Tables[0].Rows[0][1]).ToString();
                tbParcaTutari.Text = Convert.ToDouble(DS.Tables[0].Rows[0][2]).ToString();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (tbParcaKodu.Text.Count() > 0 && tbParcaAdi.Text.Count() > 0 && tbIscilik.Text.Count() > 0 && tbParcaTutari.Text.Count() > 0)
            {
                String komut = "spParcaEkleGuncelle '" + tbParcaKodu.Text + "', '" + tbParcaAdi.Text + "', " +
                            Convert.ToDouble(tbIscilik.Text).ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ", " +
                            Convert.ToDouble(tbParcaTutari.Text).ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Parça bilgileri güncellendi", "Parça güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
