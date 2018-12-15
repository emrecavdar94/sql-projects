using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace SQL_Project
{
    public partial class frmLogin : Form
    {
        private SqlConnection baglanti;
        public long perno = -1;
        public frmLogin(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            String kullanici = tbKullaniciAdi.Text;
            String parola = tbParola.Text;
            SHA1 sha = new SHA1CryptoServiceProvider();
            StringBuilder parolaSha = new StringBuilder();
            foreach (byte b in sha.ComputeHash(Encoding.UTF8.GetBytes(parola)))
            {
                parolaSha.Append(b.ToString("x2"));
            }

            String komut = "SELECT kullaniciAdi, parola,perNo FROM personel";
            SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sqlDA.Fill(DS);

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables.Count; i++)
                {
                    if (kullanici == DS.Tables[0].Rows[i][0].ToString() && parolaSha.ToString() == DS.Tables[0].Rows[i][1].ToString())
                    {
                        perno = Int64.Parse(DS.Tables[0].Rows[i][2].ToString());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı adı veya parolası","Giriş Bilgileri Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}