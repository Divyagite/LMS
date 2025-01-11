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
    public partial class frmlibrarymgmt : Form
    {
        public frmlibrarymgmt()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genrefrm obj = new genrefrm();
            obj.Show();
            obj.MdiParent = this;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterUser frmRegisterUser = new frmRegisterUser();
            frmRegisterUser.Show();
            frmRegisterUser.MdiParent = this;
        }

        private void cupboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCupboard obj= new frmCupboard();
            obj.Show();
            obj.MdiParent = this;
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks obj= new frmBooks();
            obj.Show();
            obj.MdiParent = this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin obj= new frmLogin();
            obj.Show();
            obj.MdiParent = this;
        }

        private void frmlibrarymgmt_Load(object sender, EventArgs e)
        {

        }
    }
}
