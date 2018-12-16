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
            if (tbMusteriTCNo.Text == string.Empty && tbMusteriAd.Text == string.Empty && tbMusteriSoyad.Text == string.Empty)
            {
                string komut = "SELECT ad AS[AD], soyad AS[SOYAD], tckNo AS[TC KIMLIK NO], telefon AS[TELEFON], eposta AS[E - POSTA], adres AS[ADRES]  FROM musteri";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbMusteriTCNo.Text != string.Empty || tbMusteriAd.Text != string.Empty || tbMusteriSoyad.Text == string.Empty)
            {
                string komut = "SELECT ad AS[AD], soyad AS[SOYAD], tckNo AS[TC KIMLIK NO], telefon AS[TELEFON], eposta AS[E - POSTA], adres AS[ADRES]  FROM musteri WHERE tckNo='" + tbMusteriTCNo.Text + "' OR ad='" + tbMusteriAd.Text + "' (OR soyad='" + tbMusteriSoyad.Text + "')";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }

        }

        private void btnArabaGetir_Click(object sender, EventArgs e)
        {
            if (tbMarka.Text == string.Empty && tbModel.Text == string.Empty && tbRenk.Text == string.Empty)
            {
                string komut = "SELECT sasiNo AS [ŞASI NO], motorNo AS [motorNo], plaka AS [PLAKA], model AS [MODEl],marka AS [marka], renk AS [RENK] FROM araba";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
        }
    }
}