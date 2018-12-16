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
        private SqlConnection baglanti;
        public long perno;
        public frmYetkiler(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();

        }

        private void lbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Item obj = new Item();
            //string query = "SELECT yetkiad,ad,soyad FROM personel";
            //using (SqlCommand cmd = new SqlCommand(query, baglanti))
            //{
            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    {

            //        while (reader.Read())
            //        {
            //            obj.deger = (string)reader[1];
            //            obj.value= (int)reader[0];
            //            lbPersonel.Items.Add(obj);
            //        }
            //    }
            //}
        }

        private void frmYetkiler_Load(object sender, EventArgs e)
        {
                List<long> pernoList = new List<long>();
              
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
            }
        
    }

