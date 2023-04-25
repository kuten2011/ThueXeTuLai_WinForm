using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Xml.Linq;

namespace ThueXe
{
    public partial class Pass : Form
    {
        private BUStaikhoan t;
        private BUSadmin a;
        public Pass()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtTK.ReadOnly = true;
            txtOP.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new BUSadmin(txtTK.Text, txtOP.Text);

            if (a.checkInfo().Trim().Equals("Admin") || a.checkInfo().Trim().Equals("Staff") || a.checkInfo().Trim().Equals("Manager"))
            {
                if (txtPas1.Text.Equals(txtPas2.Text))
                {
                    if(txtTK.Text.Substring(0,txtTK.Text.Length - 4).Equals("ST"))
                    {
                        t = new BUStaikhoan(txtTK.Text.Trim(), txtPas1.Text.Trim(), "", "", "", "", "", "Staff");
                    } else if (txtTK.Text.Substring(0, txtTK.Text.Length - 4).Equals("MN"))
                    {
                        t = new BUStaikhoan(txtTK.Text.Trim(), txtPas1.Text.Trim(), "", "", "", "", "", "Manager");
                    } else if (txtTK.Text.Substring(0, txtTK.Text.Length - 4).Equals("AD"))
                    {
                        t = new BUStaikhoan(txtTK.Text.Trim(), txtPas1.Text.Trim(), "", "", "", "", "", "Admin");
                    }
                    t.editTK();
                    MessageBox.Show("Thay đổi thành công");
                }
            }
            else
            {
                MessageBox.Show("Thay đổi thất bại");
            }
            txtOP.Clear();
            txtPas1.Clear();
            txtPas2.Clear();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
