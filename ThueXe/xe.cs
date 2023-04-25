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
    public partial class xe : Form
    {
        private BUSxe x;
        private BUSchuxe cx;
        public xe()
        {
            InitializeComponent();
        }

        private void loadXe()
        {
            dataGridView2.DataSource = x.selectXe();

            cboChuXe.DisplayMember = "machuxe"; // Hiển thị trường trong ComboBox
            cboChuXe.ValueMember = "machuxe";
            cboChuXe.DataSource = cx.selectCX();

            cboChuXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNgoaiHinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhienLieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHopSo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;

            txtMaXe.Text = x.autoID("X");
            txtMaXe.ReadOnly = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void resetXe()
        {
            txtMaXe.Text = x.autoID("X");
            txtMaXe.ReadOnly = true;
            txtHangXe.Clear();
            txtTenXe.Clear();
            txtBienSoXe.Clear();
            txtGiaThue.Clear();
            cboChuXe.SelectedIndex = -1;
            cboNhienLieu.SelectedIndex = -1;
            cboHopSo.SelectedIndex = -1;
            cboNgoaiHinh.SelectedIndex = -1;
            cboTinhTrang.SelectedIndex = -1;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void xe_Load(object sender, EventArgs e)
        {
            x = new BUSxe("", "", "", "", "", "", "", "", "", 0);
            cx = new BUSchuxe("", "", "", "", "", "", "");
            loadXe();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int giathue;
            try
            {
                giathue = int.Parse(txtGiaThue.Text);
            } catch 
            {
                giathue = 0;
            }
            x = new BUSxe(txtMaXe.Text, txtHangXe.Text, txtTenXe.Text, cboChuXe.Text, 
                txtBienSoXe.Text, cboNhienLieu.Text, cboHopSo.Text, cboNgoaiHinh.Text, 
                cboTinhTrang.Text, giathue);
            if (!x.addXe())
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Mã Chủ Xe");
            } else
            {
                loadXe();
                resetXe();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            x = new BUSxe(txtMaXe.Text, "", "", "", "", "", "", "", "", 0);
            x.delXe();
            loadXe();
            resetXe();
        }

        private void changeCBO(System.Windows.Forms.ComboBox CBO, System.Windows.Forms.DataGridView data, int row, int cell)
        {
            for (int i = 0; i < CBO.Items.Count; i++)
            {
                if (CBO.Items[i].ToString().Trim().Equals(data.Rows[row].Cells[cell].Value.ToString().Trim()))
                {
                    CBO.SelectedIndex = i;
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            txtMaXe.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
            txtHangXe.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
            txtTenXe.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
            txtGiaThue.Text = dataGridView2.Rows[index].Cells[4].Value.ToString();
            txtBienSoXe.Text = dataGridView2.Rows[index].Cells[5].Value.ToString();

            for (int i = 0; i < cboChuXe.Items.Count; i++)
            {
                DataRowView row = cboChuXe.Items[i] as DataRowView;
                if (row != null)
                {
                    string macx = row["machuxe"].ToString();
                    if (macx.Trim().Equals(dataGridView2.Rows[index].Cells[3].Value.ToString().Trim()))
                    {
                        cboChuXe.SelectedIndex = i;
                    }
                }
            }

            changeCBO(cboNhienLieu, dataGridView2, index, 6);
            changeCBO(cboHopSo, dataGridView2, index, 7);
            changeCBO(cboNgoaiHinh, dataGridView2, index, 8);
            changeCBO(cboTinhTrang, dataGridView2, index, 9);

            btnEdit.Enabled = true;
            btnDel.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetXe();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int giathue;
            try
            {
                giathue = int.Parse(txtGiaThue.Text);
            } catch 
            {
                giathue = 0;
            }
            
            x = new BUSxe(txtMaXe.Text, txtHangXe.Text, txtTenXe.Text, cboChuXe.Text,
                txtBienSoXe.Text, cboNhienLieu.Text, cboHopSo.Text, cboNgoaiHinh.Text,
                cboTinhTrang.Text, giathue);
            x.editXe();
            loadXe();
            resetXe();
        }

        private void txtGiaThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
