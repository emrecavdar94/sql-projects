using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnection baglanti = new SqlConnection("Server=.;Database=araba;User Id=araba;Password=arabaparola;");
            baglanti.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin(baglanti);
            Application.Run(login);

            if (login.perno != -1) {
                frmMasterForm master = new frmMasterForm(baglanti);
                master.perno = login.perno;
                Application.Run(master);
            }
        }
    }
}
