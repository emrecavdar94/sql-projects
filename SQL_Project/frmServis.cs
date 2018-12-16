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
    public partial class frmServis : Form
    {
        private SqlConnection baglanti;
        public long perno;
        private long musNo;
        public frmServis(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void btnTCNoDoldur_Click(object sender, EventArgs e)
        {
            String komut = "SELECT musNo, ad, soyad, telefon, eposta, adres FROM musteri WHERE tckNo ='" + tbMusteriTCNo.Text + "'";
            SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sqlDA.Fill(DS);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                musNo = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());
                tbAd.Text = DS.Tables[0].Rows[0][1].ToString();
                tbSoyad.Text = DS.Tables[0].Rows[0][2].ToString();
                tbTelNo.Text = DS.Tables[0].Rows[0][3].ToString();
                tbEPosta.Text = DS.Tables[0].Rows[0][4].ToString();
                tbAdres.Text = DS.Tables[0].Rows[0][5].ToString();
            }
            else
            {
                musNo = 0;
                tbAd.Text = "";
                tbSoyad.Text = "";
                tbTelNo.Text = "";
                tbEPosta.Text = "";
                tbAdres.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String komut = "SELECT motorNo, plaka, marka, model, renk FROM araba WHERE sasiNo ='" + tbSasiNo.Text + "'";
            SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sqlDA.Fill(DS);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                tbMotorNo.Text = DS.Tables[0].Rows[0][0].ToString();
                tbPlaka.Text = DS.Tables[0].Rows[0][1].ToString();
                tbMarka.Text = DS.Tables[0].Rows[0][2].ToString();
                tbModel.Text = DS.Tables[0].Rows[0][3].ToString();
                tbRenk.Text = DS.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                tbMotorNo.Text = "";
                tbPlaka.Text = "";
                tbMarka.Text = "";
                tbModel.Text = "";
                tbRenk.Text = "";
            }
        }

        private void btnIsEmriDoldur_Click(object sender, EventArgs e)
        {
            if (tbIsEmriNo.Text.Count() > 0)
            {
                String komut = "SELECT A.sasiNo, A.motorNo, A.plaka, A.marka, A.model, A.renk, " +
                               "M.tckNo, M.ad, M.soyad, M.telefon, M.eposta, M.adres, " +
                               "S.girisTarihi, S.girisTalimati, S.aracKm, S.yapilanIslemler, " +
                               "S.cikisTarihi, S.faturaTutari FROM araba A " +
                               "JOIN servis S on S.sasiNo = A.sasiNo " +
                               "JOIN musteri M on S.musNo = M.musNo " +
                               " WHERE isEmriNo =" + tbIsEmriNo.Text;
                SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    tbSasiNo.Text = DS.Tables[0].Rows[0][0].ToString();
                    tbMotorNo.Text = DS.Tables[0].Rows[0][1].ToString();
                    tbPlaka.Text = DS.Tables[0].Rows[0][2].ToString();
                    tbMarka.Text = DS.Tables[0].Rows[0][3].ToString();
                    tbModel.Text = DS.Tables[0].Rows[0][4].ToString();
                    tbRenk.Text = DS.Tables[0].Rows[0][5].ToString();
                    tbMusteriTCNo.Text = DS.Tables[0].Rows[0][6].ToString();
                    tbAd.Text = DS.Tables[0].Rows[0][7].ToString();
                    tbSoyad.Text = DS.Tables[0].Rows[0][8].ToString();
                    tbTelNo.Text = DS.Tables[0].Rows[0][9].ToString();
                    tbEPosta.Text = DS.Tables[0].Rows[0][10].ToString();
                    tbAdres.Text = DS.Tables[0].Rows[0][11].ToString();
                    dtGiris.Text = DS.Tables[0].Rows[0][12].ToString();
                    tbGirisTalimat.Text = DS.Tables[0].Rows[0][13].ToString();
                    tbArackm.Text = DS.Tables[0].Rows[0][14].ToString();
                    tbYapilanIslemler.Text = DS.Tables[0].Rows[0][15].ToString();
                    dtCikis.Text = DS.Tables[0].Rows[0][16].ToString();
                    tbFaturaTutari.Text = DS.Tables[0].Rows[0][17].ToString();
                }
                else
                {
                    tbSasiNo.Text = "";
                    tbMotorNo.Text = "";
                    tbPlaka.Text = "";
                    tbMarka.Text = "";
                    tbModel.Text = "";
                    tbRenk.Text = "";
                    tbMusteriTCNo.Text = "";
                    tbAd.Text = "";
                    tbSoyad.Text = "";
                    tbTelNo.Text = "";
                    tbEPosta.Text = "";
                    tbAdres.Text = "";
                    dtGiris.ResetText();
                    tbGirisTalimat.Text = "";
                    tbArackm.Text = "";
                    tbYapilanIslemler.Text = "";
                    dtCikis.ResetText();
                    tbFaturaTutari.Text = "";
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbSasiNo.Text = "";
            tbMotorNo.Text = "";
            tbPlaka.Text = "";
            tbMarka.Text = "";
            tbModel.Text = "";
            tbRenk.Text = "";
            tbMusteriTCNo.Text = "";
            tbAd.Text = "";
            tbSoyad.Text = "";
            tbTelNo.Text = "";
            tbEPosta.Text = "";
            tbAdres.Text = "";
            tbIsEmriNo.Text = "";
            dtGiris.ResetText();
            tbGirisTalimat.Text = "";
            tbArackm.Text = "";
            tbYapilanIslemler.Text = "";
            dtCikis.ResetText();
            tbFaturaTutari.Text = "";
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParcaCikar_Click(object sender, EventArgs e)
        {
            //lbParcalar.Items.Remove(lbParcalar.SelectedItems);
        }

        private void btnIsEmriAc_Click(object sender, EventArgs e)
        {
            if (musNo != 0)
            {
                String komut = "INSERT INTO servis " +
                    " (girisTarihi, sasiNo, musNo, perNo, girisTalimati, aracKm) VALUES " +
                    " ('" + dtGiris.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + tbSasiNo.Text + "', " +
                    musNo + ", " + perno + ", '" + tbGirisTalimat.Text + "', " +
                    tbArackm.Text + ") SELECT SCOPE_IDENTITY()";
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
                tbIsEmriNo.Text = Convert.ToInt64(sorgu.ExecuteScalar()).ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbIsEmriNo.Text.Count() > 0)
            {
                
            }
        }

        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            frmParcalar parcalarForm = new frmParcalar(baglanti);
            parcalarForm.isEmriNo = Convert.ToInt64(tbIsEmriNo.Text);
            parcalarForm.ShowDialog();

        }

        private void fillParcalar()
        {

        }
    }
}
