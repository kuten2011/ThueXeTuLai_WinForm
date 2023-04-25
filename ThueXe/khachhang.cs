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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThueXe
{
    public partial class khanhhang : Form
    {
        private BUSkhachhang k;
        public khanhhang()
        {
            InitializeComponent();
        }

        public void loadKH()
        {
            dataGridView1.DataSource = k.selectKH();
            txtMaKH.Text = k.autoID("KH");
            txtMaKH.ReadOnly = true;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            cboGT.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void reset()
        {
            txtMaKH.Text = k.autoID("KH");
            txtTenKH.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            txtMAIL.Clear();
            txtDC.Clear();
            cboGT.SelectedIndex = -1;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            txtTenKH.Focus();
            cboGT.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void khanhhang_Load(object sender, EventArgs e)
        {
            k = new BUSkhachhang("", "", "", "", "", "", "");
            loadKH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = new BUSkhachhang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, cboGT.Text, txtMAIL.Text, txtCCCD.Text, txtDC.Text);
            k.addKH();
            loadKH() ;
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k = new BUSkhachhang(txtMaKH.Text, "", "", "", "", "", "");
            k.delKH();
            loadKH() ; reset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDel.Enabled = true;
            btnEdit.Enabled = true;

            int index = dataGridView1.CurrentCell.RowIndex;

            txtMaKH.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            cboGT.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtMAIL.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtCCCD.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txtDC.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            k = new BUSkhachhang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, cboGT.Text, txtMAIL.Text, txtCCCD.Text, txtDC.Text);
            k.editKH();
            loadKH();
            reset();
        }
    }
}
