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
    public partial class frmYetkiler : Form
        {
        public List<long> pernoList = new List<long>();
        public List<int> yetkilerList = new List<int>();
        private SqlConnection baglanti;
        private Personel personel;
        long secilenPersonel;
        public frmYetkiler(SqlConnection baglanti, Personel personel)
        {
            this.baglanti = baglanti;
            this.personel = personel;
            InitializeComponent();

        }

        private void lbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbYetkiler.Items.Clear();
            if (lbPersonel.SelectedItems.Count > 0)
            {
                secilenPersonel = pernoList[lbPersonel.SelectedIndex];
                yetkilerList.Clear();
                lbYetkiler.Items.Clear();

                string query = "select yetkiAdi,yetkilerNo from yetki inner join yetkiler on yetki.yetkiNo=yetkiler.yetkiNo where yetkiler.perNo=" + secilenPersonel;
                using (SqlCommand cmd = new SqlCommand(query, baglanti))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lbYetkiler.Items.Add((string)reader[0]);
                            yetkilerList.Add(int.Parse(reader[1].ToString()));
                        }
                    }
                }
            }

        }

        private void frmYetkiler_Load(object sender, EventArgs e)
        {
            pernoList.Clear();
            lbPersonel.Items.Clear();
            string query = "SELECT perNo,ad,soyad FROM personel";
            using (SqlCommand cmd = new SqlCommand(query, baglanti))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lbPersonel.Items.Add((string)reader[1]);
                        pernoList.Add(long.Parse(reader[0].ToString()));
                    }
                }
            }
        }

        private void btnYetkiSil_Click(object sender, EventArgs e)
        {
            int secilenYetki = yetkilerList[lbYetkiler.SelectedIndex];

            string query = "delete from yetkiler  where  yetkilerNo=" + secilenYetki ;
            SqlCommand cmd = new SqlCommand(query, baglanti);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Yetki Silindi");
            }
            catch (Exception)
            {
                MessageBox.Show(" Yetki Silinemedi");
            }
            lbPersonel_SelectedIndexChanged(sender, e);
            
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            long secilenPersonel = pernoList[lbPersonel.SelectedIndex];

            string query = "delete from personel  where  perNo=" + secilenPersonel;
            SqlCommand cmd = new SqlCommand(query, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Silindi");
            frmYetkiler_Load(sender, e);
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonel frmPersonel = new frmPersonel(baglanti, personel);
            frmPersonel.ShowDialog();
            frmYetkiler_Load(sender, e);
        }

        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            frmYetkiEkle frmYetkiEkle = new frmYetkiEkle(baglanti, personel);
            frmYetkiEkle.secilenPersonel = secilenPersonel;
            frmYetkiEkle.ShowDialog();
            lbPersonel_SelectedIndexChanged(sender, e);
        }
    }
        
    }

