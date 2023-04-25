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

namespace ThueXe
{
    public partial class SignUp : Form
    {
        private BUStaikhoan t;
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtName.Focus();
            cboCV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void resetForm()
        {
            txtMaNV.Clear();
            txtName.Clear();
            txtDC.Clear();
            txtMail.Clear();
            txtPass.Clear();
            txtPhone.Clear();
            cboCV.SelectedIndex = -1;
            cboSex.SelectedIndex = -1;
            cboCV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = new BUStaikhoan(txtMaNV.Text, txtPass.Text, txtName.Text, 
                txtPhone.Text, cboSex.Text, txtMail.Text, txtDC.Text,cboCV.Text);
            t.addTK();
            resetForm();
        }

        private void cboCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            t = new BUStaikhoan("", "", "", "", "", "", "", cboCV.Text);
            if (cboCV.Text.Equals("Admin"))
            {
                txtMaNV.Text = t.autoID("AD");
            } else if (cboCV.Text.Equals("Staff"))
            {
                txtMaNV.Text = t.autoID("ST");
            }
            else if (cboCV.Text.Equals("Manager"))
            {
                txtMaNV.Text = t.autoID("MN");
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            admin admin = new admin();
            admin.Update();
        }
    }
}
