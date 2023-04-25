using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThueXe
{
    public partial class chuxe : Form
    {
        private BUSchuxe c;

        public chuxe()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadCX()
        {
            dataGridView1.DataSource = c.selectCX();
            txtMaCX.Text = c.autoID("CX");
            txtMaCX.ReadOnly = true;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            cboGT.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void reset()
        {
            txtMaCX.Text = c.autoID("CX");
            txtTenCX.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            txtMail.Clear();
            txtDC.Clear();
            cboGT.SelectedIndex = -1;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            txtTenCX.Focus();
            cboGT.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void chuxe_Load(object sender, EventArgs e)
        {
            c = new BUSchuxe("", "", "", "", "", "", "");
            loadCX();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = new BUSchuxe(txtMaCX.Text, txtTenCX.Text, txtSDT.Text, cboGT.Text, txtMail.Text, txtCCCD.Text, txtDC.Text);
            c.addCX();
            loadCX();
            reset();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            c = new BUSchuxe(txtMaCX.Text, "", "", "", "", "", "");
            c.delCX();
            loadCX(); reset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDel.Enabled = true;
            btnEdit.Enabled = true;

            int index = dataGridView1.CurrentCell.RowIndex;

            txtMaCX.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenCX.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            cboGT.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtCCCD.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txtDC.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDel.Enabled = true;
            btnEdit.Enabled = true;

            int index = dataGridView1.CurrentCell.RowIndex;

            txtMaCX.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenCX.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            cboGT.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtCCCD.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txtDC.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            c = new BUSchuxe(txtMaCX.Text, txtTenCX.Text, txtSDT.Text, cboGT.Text, txtMail.Text, txtCCCD.Text, txtDC.Text);
            c.editCX();
            loadCX();
            reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
