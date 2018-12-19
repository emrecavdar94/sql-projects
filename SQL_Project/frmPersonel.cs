using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Project
{
    public partial class frmPersonel : Form
    {
        private SqlConnection baglanti;
        private Personel personel;
        public frmPersonel(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            tbPersonelNo.Enabled = personel.yetkiliMi("Yönetim");
            tbTcNo.Enabled = personel.yetkiliMi("Yönetim");
            tbPersonelAd.Enabled = personel.yetkiliMi("Yönetim");
            tbPersonelSoyad.Enabled = personel.yetkiliMi("Yönetim");
            tbTelNo.Enabled = personel.yetkiliMi("Yönetim");
            tbEPosta.Enabled = personel.yetkiliMi("Yönetim");
            tbAdres.Enabled = personel.yetkiliMi("Yönetim");
            tbKullaniciAdi.Enabled = personel.yetkiliMi("Yönetim");
            btnTCNoDoldur.Enabled = personel.yetkiliMi("Yönetim");
            btnPersonelNoDoldur.Enabled = personel.yetkiliMi("Yönetim");
        }

        public void kisiselDoldur()
        {
            tbPersonelNo.Text = personel.getPerNo().ToString();
            btnPersonelNoDoldur_Click(this, new EventArgs());
        }

        private void btnPersonelNoDoldur_Click(object sender, EventArgs e)
        {
            if (tbPersonelNo.Text.Count() > 0)
            {
                String komut = "SELECT tckNo, ad, soyad, telefon, eposta, adres, kullaniciAdi FROM personel WHERE perNo =" + tbPersonelNo.Text;
                SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    tbTcNo.Text = DS.Tables[0].Rows[0][0].ToString();
                    tbPersonelAd.Text = DS.Tables[0].Rows[0][1].ToString();
                    tbPersonelSoyad.Text = DS.Tables[0].Rows[0][2].ToString();
                    tbTelNo.Text = DS.Tables[0].Rows[0][3].ToString();
                    tbEPosta.Text = DS.Tables[0].Rows[0][4].ToString();
                    tbAdres.Text = DS.Tables[0].Rows[0][5].ToString();
                    tbKullaniciAdi.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    tbTcNo.Text = "";
                    tbPersonelAd.Text = "";
                    tbPersonelSoyad.Text = "";
                    tbTelNo.Text = "";
                    tbEPosta.Text = "";
                    tbAdres.Text = "";
                    tbKullaniciAdi.Text = "";
                }
            }
        }

        private void btnTCNoDoldur_Click(object sender, EventArgs e)
        {
            if (tbTcNo.Text.Count() > 0)
            {
                String komut = "SELECT perNo, ad, soyad, telefon, eposta, adres, kullaniciAdi FROM personel WHERE tckNo ='" + tbTcNo.Text + "'";
                SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    tbPersonelNo.Text = DS.Tables[0].Rows[0][0].ToString();
                    tbPersonelAd.Text = DS.Tables[0].Rows[0][1].ToString();
                    tbPersonelSoyad.Text = DS.Tables[0].Rows[0][2].ToString();
                    tbTelNo.Text = DS.Tables[0].Rows[0][3].ToString();
                    tbEPosta.Text = DS.Tables[0].Rows[0][4].ToString();
                    tbAdres.Text = DS.Tables[0].Rows[0][5].ToString();
                    tbKullaniciAdi.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    tbPersonelNo.Text = "";
                    tbPersonelAd.Text = "";
                    tbPersonelSoyad.Text = "";
                    tbTelNo.Text = "";
                    tbEPosta.Text = "";
                    tbAdres.Text = "";
                    tbKullaniciAdi.Text = "";
                }
            }
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            int perNo;
            String parola = tbParola.Text;
            if (parola.Count() > 0)
            {
                SHA1 sha = new SHA1CryptoServiceProvider();
                StringBuilder parolaSha = new StringBuilder();
                foreach (byte b in sha.ComputeHash(Encoding.UTF8.GetBytes(parola)))
                {
                    parolaSha.Append(b.ToString("x2"));
                }

                try
                {
                    perNo = Convert.ToInt32(tbPersonelNo.Text);
                }
                catch (Exception exception)
                {
                    perNo = 0;
                }

                String komut = String.Format("spPersonelEkleGuncelle {0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}'",
                                             perNo,
                                             tbPersonelAd.Text,
                                             tbPersonelSoyad.Text,
                                             tbTcNo.Text,
                                             tbTelNo.Text,
                                             tbEPosta.Text,
                                             tbAdres.Text,
                                             tbKullaniciAdi.Text,
                                             parolaSha.ToString());

                SqlDataAdapter sorgu = new SqlDataAdapter(komut, baglanti);
                DataSet DS = new DataSet();
                sorgu.Fill(DS);
                if (DS.Tables.Count > 0)
                {
                    tbPersonelNo.Text = DS.Tables[0].Rows[0][0].ToString();
                    MessageBox.Show("Personel eklendi", "Personel İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Personel bilgileri güncellendi", "Personel İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Parola alanı boş bırakılmamalı", "Personel İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
