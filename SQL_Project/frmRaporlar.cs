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
            string komut = "SELECT ad AS[AD], soyad AS[SOYAD], tckNo AS[TC KIMLIK NO], telefon AS[TELEFON], eposta AS[E - POSTA], adres AS[ADRES]  FROM musteri";
            if (mtbMusteriTCNo.Text == string.Empty && tbMusteriAd.Text == string.Empty && tbMusteriSoyad.Text == string.Empty)
            {
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (mtbMusteriTCNo.Text != string.Empty)
            {
                komut += " WHERE tckNo='" + mtbMusteriTCNo.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbMusteriAd.Text != string.Empty)
            {
                komut += "WHERE ad = '" + tbMusteriAd.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbMusteriSoyad.Text != string.Empty)
            {
                komut += "WHERE soyad = '" + tbMusteriSoyad.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
        }

        private void btnArabaGetir_Click(object sender, EventArgs e)
        {
            string komut = "SELECT sasiNo AS [ŞASI NO], motorNo AS [MOTOR NO], plaka AS [PLAKA], model AS [MODEL], marka AS [MARKA], renk AS [RENK] FROM araba ";
            if (tbMarka.Text == string.Empty && tbModel.Text == string.Empty && tbRenk.Text == string.Empty && rbSatilmisAraba.Checked == true)
            {
                komut += "WHERE sasiNo IN (SELECT sasiNo FROM satis)";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbMarka.Text == string.Empty && tbModel.Text == string.Empty && tbRenk.Text == string.Empty && rbSatilmamisAraba.Checked == true)
            {
                komut += "WHERE sasiNo NOT IN (SELECT sasiNo FROM satis)";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbMarka.Text == string.Empty && tbModel.Text == string.Empty && tbRenk.Text == string.Empty && rbTumArabalar.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbMarka.Text != string.Empty && rbSatilmisAraba.Checked == true)
            {
                komut += "WHERE sasiNo IN(SELECT sasiNo FROM satis) AND marka = '" + tbMarka.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbMarka.Text != string.Empty && rbSatilmamisAraba.Checked == true)
            {
                komut += "WHERE sasiNo NOT IN(SELECT sasiNo FROM satis) AND marka = '" + tbMarka.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbMarka.Text != string.Empty && rbTumArabalar.Checked == true)
            {
                komut += "WHERE marka = '" + tbMarka.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbModel.Text != string.Empty && rbSatilmisAraba.Checked == true)
            {
                komut += "WHERE sasiNo IN(SELECT sasiNo FROM satis) AND model = '" + tbModel.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbModel.Text != string.Empty && rbSatilmamisAraba.Checked == true)
            {
                komut += "WHERE sasiNo NOT IN(SELECT sasiNo FROM satis) AND model = '" + tbModel.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbModel.Text != string.Empty && rbTumArabalar.Checked == true)
            {
                komut += "WHERE model = '" + tbModel.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbRenk.Text != string.Empty && rbSatilmisAraba.Checked == true)
            {
                komut += "WHERE sasiNo IN(SELECT sasiNo FROM satis) AND renk = '" + tbRenk.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbRenk.Text != string.Empty && rbSatilmamisAraba.Checked == true)
            {
                komut += "WHERE sasiNo NOT IN(SELECT sasiNo FROM satis) AND renk = '" + tbRenk.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbRenk.Text != string.Empty && rbTumArabalar.Checked == true)
            {
                komut += "WHERE renk = '" + tbRenk.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            rbTumArabalar.Checked = true;
            if (true)
            {

            }
        }
    }
}