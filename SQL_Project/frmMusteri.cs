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
        public long perno;
        public frmMusteri(SqlConnection baglanti)
        {
            this.baglanti = baglanti;
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string query = "insert into musteri values('" + tbMusteriAd.Text + "','" + tbMusteriSoyad.Text + "','" + tbTcNo.Text + "','" + tbMusTelNo.Text + "','" + tbMusteriEPosta.Text + "','" + tbMusteriAdres.Text + "')";
            SqlCommand cmd = new SqlCommand(query, baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Müşteri Eklendi Eklendi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE musteri SET ad = '"+tbMusteriAd.Text+"', soyad = '"+tbMusteriSoyad.Text+ "', telefon = '" + tbMusTelNo.Text + "',eposta = '" + tbMusteriEPosta.Text + "', adres = '" + tbMusteriAdres.Text + "' WHERE tckNo ='" + tbTcNo.Text + "'";
            SqlCommand cmd = new SqlCommand(query, baglanti);
            
          
            cmd.ExecuteNonQuery();
            MessageBox.Show("Müşteri Güncellendi");

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
    }
}
