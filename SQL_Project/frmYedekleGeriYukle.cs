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
    public partial class frmYedekleGeriYukle : Form
    {
        private SqlConnection baglanti;
        private Personel personel;
        public frmYedekleGeriYukle(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Yedek Dosyası | *.bak";
            fileDialog.CheckFileExists = false;
            fileDialog.Title = "Yedek dosyası seçiniz";
            fileDialog.FileName = "yedek.bak";
            fileDialog.ShowDialog();
            if (fileDialog.FileName != "yedek.bak")
            {
                tbKonum.Text = fileDialog.FileName;
            }
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            if (tbKonum.Text.Count() > 0)
            {
                String komut = "BACKUP DATABASE[araba] TO DISK = N'" + tbKonum.Text + "' WITH NOFORMAT, NOINIT, NAME = N'araba-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Yedekleme Başarılı", "Yedekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (tbKonum.Text.Count() > 0)
            {
                String komut = "USE [master] ALTER DATABASE[araba] SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                               "RESTORE DATABASE[araba] FROM DISK = N'" + tbKonum.Text + "' WITH FILE = 1, REPLACE, STATS = 5 " +
                               "ALTER DATABASE[araba] SET MULTI_USER";
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Geri Yükleme Başarılı", "Geri Yükleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
