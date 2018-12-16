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
    public partial class frmYetkiEkle : Form
    {
        List<int> yetkiList = new List<int>();
        private SqlConnection baglanti;
        public long perno;
        public long secilenPersonel;
        public frmYetkiEkle(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();

        }

        private void frmYetkiEkle_Load(object sender, EventArgs e)
        {
            string query = "select yetkiAdi,yetkiNo from yetki";
            using (SqlCommand cmd = new SqlCommand(query, baglanti))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        cbYetki.Items.Add((string)reader[0]);
                        
                        yetkiList.Add(int.Parse(reader[1].ToString()));

                    }
                }
            }
        }

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            int yetkiNo = yetkiList[cbYetki.SelectedIndex];
            string query = "insert into yetkiler values("+yetkiNo+","+secilenPersonel+")";
            SqlCommand cmd = new SqlCommand(query, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yetki Eklendi");
        }
    }
}
