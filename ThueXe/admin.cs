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
    public partial class admin : Form
    {
        private BUStaikhoan t;
        public admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SignUp sg = new SignUp();
            sg.ShowDialog();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            t = new BUStaikhoan("", "","","","","","","");
            load_TaiKhoan();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public void load_TaiKhoan()
        {
            dataGridView1.DataSource = t.selectTK();
            txtMaNV.ReadOnly = true;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
        }

        public void resetForm()
        {
            txtMaNV.Text = "";
            txtPass.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            cboSex.Text = "";   
            txtMail.Text = "";
            txtDC.Text = "";
            cboCV.Text = "";
            txtMaNV.Focus();
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                txtMaNV.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            }
            catch
            {

            }
            t = new BUStaikhoan(txtMaNV.Text, "","","","","","","");
            t.delTK();
            load_TaiKhoan();
            resetForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            int row = dataGridView1.CurrentCell.RowIndex;

            txtMaNV.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtPass.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            cboSex.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
            txtDC.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();
            cboCV.Text = dataGridView1.Rows[row].Cells[7].Value.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t = new BUStaikhoan(txtMaNV.Text, txtPass.Text, txtName.Text,
                txtPhone.Text, cboSex.Text, txtMail.Text, txtDC.Text, cboCV.Text);
            t.editTK();
            load_TaiKhoan();
            resetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_TaiKhoan();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender, e );
        }
    }
}
