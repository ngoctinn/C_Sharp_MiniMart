using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace C_Sharp_MiniMart
{
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private Form activeForm = null;
        private void openChildFrom(Form childForm) // hàm mở form con
        {
            if ( activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildFrom(new ItemForm());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            openChildFrom(new CustomerForm());
        }

        
    }
}
