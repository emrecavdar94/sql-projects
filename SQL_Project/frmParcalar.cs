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
    public partial class frmParcalar : Form
    {
        private SqlConnection baglanti;
        private Personel personel;
        private long isEmriNo;
        public frmParcalar(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();
        }

        public void setIsEmriNo(long isEmriNo)
        {
            this.isEmriNo = isEmriNo;
            setEnabledBtnEkle(true);
        }

        private void frmParcalar_Load(object sender, EventArgs e)
        {
            doldur();
            btnYeniParca.Enabled = personel.yetkiliMi("Parça", "Yönetim");
            btnParcaSil.Enabled = personel.yetkiliMi("Parça", "Yönetim");
        }

        private void doldur()
        {
            String komut = "SELECT * FROM parca";
            SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sqlDA.Fill(DS);
            dgParcalar.DataSource = DS.Tables[0];
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            String komut = "SELECT * FROM parca WHERE ";
            if (tbParcaKodu.Text.Count() > 0 && tbParcaAdi.Text.Count() > 0)
                komut += "parcaKodu LIKE '%" + tbParcaKodu.Text + "%' AND parcaKodu LIKE '%" + tbParcaAdi.Text + "%'";
            else if (tbParcaKodu.Text.Count() > 0)
                komut += "parcaKodu LIKE '%" + tbParcaKodu.Text + "%'";
            else if (tbParcaAdi.Text.Count() > 0)
                komut += "parcaAdi LIKE '%" + tbParcaAdi.Text + "%'";
            
            if (tbParcaKodu.Text.Count() > 0 || tbParcaAdi.Text.Count() > 0)
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);
                dgParcalar.DataSource = DS.Tables[0];
            }
            else
            {
                doldur();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (dgParcalar.SelectedRows.Count > 0)
            {
                String parcaKodu = dgParcalar.SelectedRows[0].Cells[0].Value.ToString();
                String komut = "INSERT INTO degisim (isEmriNo, parcaKodu) VALUES (" +
                    isEmriNo + ", '" + parcaKodu + "')";
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Parça Eklendi", "Parça Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void setEnabledBtnEkle(Boolean durum)
        {
            btnEkle.Enabled = durum;
        }

        private void btnParcaSil_Click(object sender, EventArgs e)
        {
            if (dgParcalar.SelectedRows.Count > 0)
            {
                String parcaKodu = dgParcalar.SelectedRows[0].Cells[0].Value.ToString();
                String komut = "DELETE FROM parca WHERE parcaKodu = '" + parcaKodu + "'";
                SqlCommand sorgu = new SqlCommand(komut, baglanti);
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Parça Silindi", "Parça Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            doldur();
        }

        private void btnYeniParca_Click(object sender, EventArgs e)
        {
            frmParca parcaForm = new frmParca(baglanti, personel);
            parcaForm.ShowDialog();
            doldur();
        }
    }
}
