﻿using System;
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
    public partial class frmPersonelRaporAl : Form
    {
        private SqlConnection baglanti;
        DataTable dtVeri;
        public frmPersonelRaporAl(SqlConnection baglanti, DataTable dtVeri)
        {
            this.baglanti = baglanti;
            this.dtVeri = dtVeri;
            InitializeComponent();
        }
    }
}
