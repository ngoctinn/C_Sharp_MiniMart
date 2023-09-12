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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void panel2_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(7);
            guna2DataGridView1.Rows[0].Cells[0].Value = "abc";
            guna2DataGridView1.Rows[0].Cells[1].Value = "abc";
            guna2DataGridView1.Rows[0].Cells[2].Value = "abc";
            guna2DataGridView1.Rows[0].Cells[3].Value = "abc";
            guna2DataGridView1.Rows[0].Cells[4].Value = "abc";
            guna2DataGridView1.Rows[0].Cells[5].Value = "abc";
            guna2DataGridView1.Rows[0].Cells[6].Value = "abc";

          


        }
    }
}
