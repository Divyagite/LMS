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
    public partial class genrefrm : Form
    {
        public genrefrm()
        {
            InitializeComponent();
        }
        private void btngenre_Click(object sender, EventArgs e)
        {
            clsRegistration obj= new clsRegistration(txtbxgenre.Text);
            obj.SaveGenre();
            MessageBox.Show("Genre Data Saved Successfully..");
            txtbxgenre.Clear();
            //frmCupboard.MdiParent = this;
        }
    }
}
