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
    public partial class frmMusteri : Form
    {
        private SqlConnection baglanti;
        private Personel personel;
        public frmMusteri(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            String komut = "SELECT ad, soyad, tckNo, telefon, eposta, adres FROM musteri";
            SqlDataAdapter sorgu = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sorgu.Fill(DS);
            dgMusteriler.DataSource = DS.Tables[0];

            btnSil.Enabled = personel.yetkiliMi("Yönetim");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string komut = "DELETE FROM musteri WHERE tckNo = '" + dgMusteriler.SelectedRows[0].Cells[2].Value.ToString() + "'";
            SqlCommand sorgu = new SqlCommand(komut, baglanti);
            sorgu.ExecuteNonQuery();
            MessageBox.Show("Müşteri Silindi", "Müşteri İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMusteri_Load(sender, e);
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            String komut = String.Format("spMusteriEkleGuncelle '{0}', '{1}', '{2}', '{3}', '{4}', '{5}'",
                                             tbTcNo.Text,
                                             tbMusteriAd.Text,
                                             tbMusteriSoyad.Text,
                                             tbMusTelNo.Text,
                                             tbMusteriEPosta.Text,
                                             tbMusteriAdres.Text);

            SqlDataAdapter sorgu = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sorgu.Fill(DS);
            if (DS.Tables.Count > 0)
            {
                tbTcNo.Text = DS.Tables[0].Rows[0][0].ToString();
                MessageBox.Show("Müsteri eklendi", "Müşteri İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Müşteri bilgileri güncellendi", "Müşteri İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmMusteri_Load(sender, e);
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string query = "select ad,soyad,tckNo,telefon,eposta,adres from musteri where  tckNo = '"+tbTcNo.Text+"'";
            using (SqlCommand cmd = new SqlCommand(query, baglanti))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) { 
                    tbMusteriAd.Text = (string)reader[0];
                    tbMusteriSoyad.Text = (string)reader[1];
                    tbTcNo.Text = (string)reader[2];
                    tbMusTelNo.Text= (string)reader[3];
                    tbMusteriEPosta.Text = (string)reader[4];
                    tbMusteriAdres.Text = (string)reader[5];
                    }
                }
            }
           
        }

        private void dgMusteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTcNo.Text = dgMusteriler.SelectedRows[0].Cells[2].Value.ToString();
            btnGetir_Click(sender, e);
        }
    }
}
