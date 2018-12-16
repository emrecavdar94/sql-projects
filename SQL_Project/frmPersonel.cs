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
        public long perno;
        public frmPersonel(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            String parola = tbParola.Text;
            SHA1 sha = new SHA1CryptoServiceProvider();
            StringBuilder parolaSha = new StringBuilder();
            foreach (byte b in sha.ComputeHash(Encoding.UTF8.GetBytes(parola)))
            {
                parolaSha.Append(b.ToString("x2"));
            }

            string query = "insert into personel values('" + tbPersonelAd.Text + "','" + tbPersonelSoyad.Text + "','" + tbTcNo.Text + "','" + parolaSha.ToString() + "','"+tbTelNo.Text+"','"+tbEPosta.Text+"','"+tbAdres.Text+"','"+tbKullaniciAdi.Text+"') ";
            SqlCommand cmd = new SqlCommand(query, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi");




        
        }
    }
}
