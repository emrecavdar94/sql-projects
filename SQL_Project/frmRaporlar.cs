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
            string komut = "SELECT ad AS[AD], soyad AS[SOYAD], tckNo AS[TC KIMLIK NO], telefon AS[TELEFON], eposta AS[E-POSTA], adres AS[ADRES]  FROM musteri ";
            if (mtbMusteriTCNo.Text == string.Empty && tbMusteriAd.Text == string.Empty && tbMusteriSoyad.Text == string.Empty)
            {
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (mtbMusteriTCNo.Text != string.Empty && tbMusteriAd.Text == string.Empty && tbMusteriSoyad.Text == string.Empty)
            {
                komut += "WHERE tckNo='" + mtbMusteriTCNo.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (mtbMusteriTCNo.Text == string.Empty && tbMusteriAd.Text != string.Empty && tbMusteriSoyad.Text == string.Empty)
            {
                komut += "WHERE ad = '" + tbMusteriAd.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (mtbMusteriTCNo.Text == string.Empty && tbMusteriAd.Text == string.Empty && tbMusteriSoyad.Text != string.Empty)
            {
                komut += "WHERE soyad = '" + tbMusteriSoyad.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (mtbMusteriTCNo.Text == string.Empty && tbMusteriAd.Text != string.Empty && tbMusteriSoyad.Text != string.Empty)
            {
                komut += "WHERE ad = '" + tbMusteriAd.Text + "' AND soyad = '" + tbMusteriSoyad.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
        }

        private void btnArabaGetir_Click(object sender, EventArgs e)
        {
            string komut = "SELECT sasiNo AS [ŞASI NO], motorNo AS [MOTOR NO], plaka AS [PLAKA], model AS [MODEL], marka AS [MARKA], renk AS [RENK] FROM araba ";
            Boolean andGerekli = false;
            if (tbMarka.Text.Count() > 0)
            {
                komut += "WHERE marka = '" + tbMarka.Text + "'";
                andGerekli = true;
            }
            if (tbModel.Text.Count() > 0)
            {
                if (andGerekli)
                    komut += " AND model = '" + tbModel.Text + "'";
                else
                {
                    komut += "WHERE model = '" + tbModel.Text + "'";
                    andGerekli = true;
                }
            }
            if (tbRenk.Text.Count() > 0)
            {
                if (andGerekli)
                    komut += " AND renk = '" + tbRenk.Text + "'";
                else
                {
                    komut += "WHERE renk = '" + tbRenk.Text + "'";
                    andGerekli = true;
                }
            }
            if (rbSatilmamisAraba.Checked)
            {
                if (andGerekli)
                    komut += " AND sasiNo NOT IN (SELECT sasiNo FROM satis)";
                else
                {
                    komut += "WHERE sasiNo NOT IN (SELECT sasiNo FROM satis)";
                    andGerekli = true;
                }
            }
            if (rbSatilmisAraba.Checked)
            {
                if (andGerekli)
                    komut += " AND sasiNo IN (SELECT sasiNo FROM satis)";
                else
                {
                    komut += "WHERE sasiNo IN (SELECT sasiNo FROM satis)";
                    andGerekli = true;
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgVeriler.DataSource = dt;
        }

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            rbTumArabalar.Checked = true;
        }

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
            string komut = "SELECT ad AS[AD], soyad AS[SOYAD], tckNo AS[TC KIMLIK NO], eposta AS[E-POSTA], adres AS[ADRES] FROM personel ";
            if (tbPersonelAd.Text == string.Empty && tbPersonelSoyad.Text == string.Empty)
            {
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbPersonelAd.Text != string.Empty && tbPersonelSoyad.Text == string.Empty)
            {
                komut += "WHERE ad = '" + tbPersonelAd.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbPersonelAd.Text == string.Empty && tbPersonelSoyad.Text != string.Empty)
            {
                komut += "WHERE soyad = '" + tbPersonelSoyad.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
            else if (tbPersonelAd.Text != string.Empty && tbPersonelSoyad.Text != string.Empty)
            {
                komut += "WHERE ad = '" + tbPersonelAd.Text + "' AND soyad = '" + tbPersonelSoyad.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
        }

        private void btnPersonelEncokSatisYapan_Click(object sender, EventArgs e)
        {
            string komut = "SELECT TOP (10) p.tckNo AS[TC KIMLIK NO], p.ad AS[AD], p.soyad AS[SOYAD], COUNT(p.perNo) AS[SATIŞ ADEDİ], SUM(s.tutar) AS[SATIŞ TUTARI] FROM personel p INNER JOIN satis s ON p.perNo=s.perNo GROUP BY p.tckNo,p.ad,p.soyad,p.perNo ORDER BY [SATIŞ ADEDİ] DESC, [SATIŞ TUTARI] DESC ";
            if (tbPersonelAd.Text == string.Empty && tbPersonelSoyad.Text == string.Empty)
            {
                SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVeriler.DataSource = dt;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            object Missing = Type.Missing;
            Microsoft.Office.Interop.Excel.Workbook workbook = Excel.Workbooks.Add(Missing);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dgVeriler.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgVeriler.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgVeriler.Rows.Count; i++)
            {
                for (int j = 0; j < dgVeriler.Columns.Count; j++)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dgVeriler[j, i].Value == null ? "" : dgVeriler[j, i].Value;
                        myRange.Select();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Aktarım Yapılırken Hata Oluştu", "Aktarım Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Excel.Visible = true;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            frmRaporRapor disariaktar = new frmRaporRapor();
            disariaktar.ShowDialog();
        }
    }
}