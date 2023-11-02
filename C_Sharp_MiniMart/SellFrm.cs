using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_MiniMart
{
    public partial class SellFrm : Form
    {
        public SellFrm()
        {
            InitializeComponent();
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            fllProduct.VerticalScroll.Value = e.NewValue;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
