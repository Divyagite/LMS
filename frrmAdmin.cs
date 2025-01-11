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
    public partial class frrmAdmin : Form
    {
        public frrmAdmin()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        private void allCustomersListToolStripMenuItem_Click(object sender, EventArgs e)
        { //{
          //    frmallcustacs obj= new frmallcustacs();
          //    obj.Show();
          //    obj.MdiParent = this;
          frmAllbooks frmAllbooks = new frmAllbooks();
            frmAllbooks.Show();
            frmAllbooks.MdiParent = this;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentOnBook frmRentOnBook = new frmRentOnBook();
            frmRentOnBook.Show();
            frmRentOnBook.MdiParent = this;
        }

        private void unassignedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnassignedBooks obj=new frmUnassignedBooks();
            obj.Show();
            obj.MdiParent = this;
        }
    }
}
