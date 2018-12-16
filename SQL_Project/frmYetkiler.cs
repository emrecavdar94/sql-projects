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
    //public class Item
    //{
    //    public string deger;
    //    public string value;

    //    public Item(string deger,string value)
    //    {
    //        this.deger = deger;
    //        this.value = value;
    //    }
    //    public Item()
    //    {
           
    //    }
    //}

        public partial class frmYetkiler : Form
        {
       public List<long> pernoList = new List<long>();
        public List<int> yetkilerList = new List<int>();
        private SqlConnection baglanti;
        public long perno;
        long secilenPersonel;
        public frmYetkiler(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();

        }

        private void lbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbYetkiler.Items.Clear();
            secilenPersonel = pernoList[lbPersonel.SelectedIndex];

            string query = "select yetkiAdi,yetkilerNo from yetki inner join yetkiler on yetki.yetkiNo=yetkiler.yetkiNo where yetkiler.perNo="+secilenPersonel ;
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

        private void frmYetkiler_Load(object sender, EventArgs e)
        {
               
              
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

                MessageBox.Show(" Yetki Silinemedi Silindi");
            }
           
            
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            
            long secilenPersonel = pernoList[lbPersonel.SelectedIndex];

            string query = "delete from personel  where  perNo=" + secilenPersonel;
            SqlCommand cmd = new SqlCommand(query, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Silindi");
            
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonel frmPersonel = new frmPersonel(baglanti);
            frmPersonel.ShowDialog();
        }

        private void btnYetkiEkle_Click(object sender, EventArgs e)
        {
            frmYetkiEkle frmYetkiEkle = new frmYetkiEkle(baglanti);
            frmYetkiEkle.secilenPersonel = secilenPersonel;
            frmYetkiEkle.ShowDialog();
        }
    }
        
    }

