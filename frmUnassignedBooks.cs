﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class frmUnassignedBooks : Form
    {
        public frmUnassignedBooks()
        {
            InitializeComponent();
        }

        private void frmUnassignedBooks_Load(object sender, EventArgs e)
        {
            clsadminside obj = new clsadminside();
            DataTable dt = new DataTable();
            dt = obj.GetallUnassignedBookdata();
            grdviewUnassignedBooks.DataSource = dt;
            grdviewUnassignedBooks.Show();
        }
    }
}
