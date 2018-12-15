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
        private long musNo;
        public frmSatis(SqlConnection baglanti)
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

        private void btnSasiNoDoldur_Click(object sender, EventArgs e)
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

        private void btnSatisDoldur_Click(object sender, EventArgs e)
        {
            if (tbSatisNo.Text.Count() > 0)
            {
                String komut = "SELECT A.sasiNo, A.motorNo, A.plaka, A.marka, A.model, A.renk, " +
                               "M.tckNo, M.ad, M.soyad, M.telefon, M.eposta, M.adres, " +
                               "S.tarih, S.tutar FROM araba A " +
                               "JOIN satis S on S.sasiNo = A.sasiNo " +
                               "JOIN musteri M on S.musNo = M.musNo " +
                               " WHERE satisNo =" + tbSatisNo.Text;
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
                    dtSatis.Text = DS.Tables[0].Rows[0][12].ToString();
                    tbSatisTutari.Text = DS.Tables[0].Rows[0][13].ToString();
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
                    dtSatis.Text = "";
                    tbSatisTutari.Text = "";
                }
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (musNo != 0)
            {
                String komut = "INSERT INTO satis " +
                    " (tarih, sasiNo, musNo, perNo, tutar) VALUES " +
                    " ('" + dtSatis.ToString() + "', '" + tbSasiNo + "', " +
                    musNo + ", " + perno + ", " + tbSatisTutari.ToString() + ")";
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
            }
        }
    }
}
