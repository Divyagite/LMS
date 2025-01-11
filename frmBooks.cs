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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            clsRegistration obj = new clsRegistration();
            DataTable dt = obj.GetGenre();

            cmbxgenrebooks.DisplayMember = "genrename";
            cmbxgenrebooks.ValueMember = "genreid";
            cmbxgenrebooks.DataSource = dt;
        }

        private void cmbxgenrebooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int genreid=Convert.ToInt32(cmbxgenrebooks.SelectedValue);
            clsRegistration obj=new clsRegistration();
            DataTable dt = obj.GetCupBoardByGenre(genreid);

            cmbxcupboardbooks.DisplayMember = "cupboardname";
            cmbxcupboardbooks.ValueMember = "cupbid";
            cmbxcupboardbooks.DataSource = dt;
        }

        private void cmbxcupboardbooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddbooks_Click(object sender, EventArgs e)
        {
            int genreid = Convert.ToInt32(cmbxgenrebooks.SelectedValue);
            int cupbid = Convert.ToInt32(cmbxcupboardbooks.SelectedValue);
            int rentprice=Convert.ToInt32(txtrealprice.Text);
            int quantity=Convert.ToInt32(txtquantity.Text);
            clsRegistration obj= new clsRegistration(txtbookname.Text,rentprice,quantity,cupbid);
            obj.SaveBooks();
            MessageBox.Show("Data of Book added successfully");
            txtbookname.Clear();
            txtquantity.Clear();
            txtrealprice.Clear();
            cmbxcupboardbooks.Text = string.Empty;
            cmbxgenrebooks.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbookname.Text=string.Empty;
            txtquantity.Text=string.Empty;
            txtrealprice.Text=string.Empty;
            cmbxcupboardbooks.Text=string.Empty;
            cmbxgenrebooks.Text=string.Empty;
        }

        private void txtrealprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
