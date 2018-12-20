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
    public partial class frmArac : Form
    {
        private SqlConnection baglanti;
        private Personel personel;
        public frmArac(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();
        }

        private void frmArac_Load(object sender, EventArgs e)
        {
            String komut = "SELECT sasiNo, motorNo, plaka, marka, model, renk FROM araba";
            SqlDataAdapter sorgu = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sorgu.Fill(DS);
            dgArabalar.DataSource = DS.Tables[0];

            btnSil.Enabled = personel.yetkiliMi("Yönetim");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            String komut = String.Format("spArabaEkleGuncelle '{0}', '{1}', '{2}', '{3}', '{4}', '{5}'",
                                             tbSasiNo.Text,
                                             tbMotorNo.Text,
                                             tbPlaka.Text,
                                             tbMarka.Text,
                                             tbModel.Text,
                                             tbRenk.Text);

            SqlDataAdapter sorgu = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sorgu.Fill(DS);
            if (DS.Tables.Count > 0)
            {
                tbSasiNo.Text = DS.Tables[0].Rows[0][0].ToString();
                MessageBox.Show("Araba eklendi", "Araba İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Araba bilgileri güncellendi", "Araba İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            frmArac_Load(sender, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string komut = "DELETE FROM araba WHERE sasiNo = '" + dgArabalar.SelectedRows[0].Cells[0].Value.ToString() + "'";
            SqlCommand sorgu = new SqlCommand(komut, baglanti);
            sorgu.ExecuteNonQuery();
            MessageBox.Show("Araba Silindi", "Araba İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmArac_Load(sender, e);
        }

        private void btnSasiNoDoldur_Click(object sender, EventArgs e)
        {
            string query = "select motorNo, plaka, marka, model, renk from araba where  sasiNo = '" + tbSasiNo.Text + "'";
            using (SqlCommand cmd = new SqlCommand(query, baglanti))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tbMotorNo.Text = (string)reader[0];
                        tbPlaka.Text = (string)reader[1];
                        tbMarka.Text = (string)reader[2];
                        tbModel.Text = (string)reader[3];
                        tbRenk.Text = (string)reader[4];
                    }
                }
            }
        }

        private void dgArabalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSasiNo.Text = dgArabalar.SelectedRows[0].Cells[0].Value.ToString();
            btnSasiNoDoldur_Click(sender, e);
        }
    }
}
