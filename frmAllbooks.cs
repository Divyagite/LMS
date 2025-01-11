using System;
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
    public partial class frmAllbooks : Form
    {
        private DataTable AllBooksTable;
        public frmAllbooks()
        {
            InitializeComponent();
        }
        private void frmAllbooks_Load(object sender, EventArgs e)
        {
            clsadminside obj=new clsadminside();
            DataTable dt = new DataTable();
            dt=obj.GetallBookdatagrid();
            grdallbooks.DataSource = dt;
            grdallbooks.Show();
            AllBooksTable = obj.GetallBookdatagrid();
            grdallbooks.DataSource = AllBooksTable;           
        }

        private void grdallbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearchbyBook_TextChanged(object sender, EventArgs e)
        {
            if (AllBooksTable == null) return;
            string bookNameFilter = txtsearchbyBook.Text.Trim();
            string filter = "";
            
            if (!string.IsNullOrEmpty(bookNameFilter))
            {
                filter += $"BookName LIKE '%{bookNameFilter}%'";
            }
            DataView dv = AllBooksTable.DefaultView;
            dv.RowFilter = filter;
            grdallbooks.DataSource = dv;
        }
    }
}
