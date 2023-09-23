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
            if (activeForm != null)
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

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            openChildFrom(new ItemFrm());
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            openChildFrom(new ItemFrm());
        }

        internal static void close()
        {
            throw new NotImplementedException();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            LoginFrm f = new LoginFrm();
            this.Close();
            f.Show();
            
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            openChildFrom(new SellFrm());
        }
    }
}
