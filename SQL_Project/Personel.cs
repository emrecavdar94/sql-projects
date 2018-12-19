using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Project
{
    public class Personel
    {
        private String ad;
        private String soyad;
        private List<String> yetkiler = new List<string>();
        private SqlConnection baglanti;
        private long perno;

        public Personel(SqlConnection baglanti, long perno)
        {
            this.baglanti = baglanti;
            this.perno = perno;
            yetkileriTazele();
        }

        public String tamAd()
        {
            return ad + " " + soyad;
        }

        public void yetkileriTazele()
        {
            yetkiler.Clear();
            String komut = "SELECT P.ad, P.soyad, Y.yetkiAdi FROM personel P " +
                           "JOIN yetkiler YY on YY.perNo = P.perNo " +
                           "JOIN yetki Y on YY.yetkiNo = Y.yetkiNo " +
                           "WHERE P.perNo = " + perno;
            SqlDataAdapter sqlDA = new SqlDataAdapter(komut, baglanti);
            DataSet DS = new DataSet();
            sqlDA.Fill(DS);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                ad = DS.Tables[0].Rows[0][0].ToString();
                soyad = DS.Tables[0].Rows[0][1].ToString();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    yetkiler.Add(DS.Tables[0].Rows[i][2].ToString());
                }
            }
        }

        public Boolean yetkiliMi(params String[] yetkiler)
        {
            Boolean durum = false;
            foreach (String yetki in yetkiler)
            {
                if (this.yetkiler.IndexOf(yetki) >= 0)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        public long getPerNo()
        {
            return perno;
        }
    }
}
