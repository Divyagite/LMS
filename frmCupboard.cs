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
    public partial class frmCupboard : Form
    {
        public frmCupboard()
        {
            InitializeComponent();
        }

        private void frmCupboard_Load(object sender, EventArgs e)
        {
            clsRegistration obj = new clsRegistration();
            DataTable dt = obj.GetGenre();

            cmbxgenrecb.DisplayMember = "genrename";
            cmbxgenrecb.ValueMember = "genreid";
            cmbxgenrecb.DataSource = dt;
        }
        private void cmbxgenrecb_SelectedIndexChanged(object sender, EventArgs e)
        {           

        }

        private void btnaddCupboard_Click(object sender, EventArgs e)
        {
            int genreid = Convert.ToInt32(cmbxgenrecb.SelectedValue);
            clsRegistration obj = new clsRegistration(genreid, txtbxaddcupboard.Text);
            obj.SaveCupboard();
            MessageBox.Show("Data of Cupboard added successfully");
            txtbxaddcupboard.Clear();
            cmbxgenrecb.Items.Clear();

        }
    }
}
