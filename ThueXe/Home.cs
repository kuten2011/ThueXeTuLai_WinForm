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
    public partial class Home : Form
    {
        private BUSadmin a;
        public Home()
        {
            InitializeComponent();
        }

        private Form currentChildForm;

        private void openChild(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_bottom.Controls.Add(childForm);
            panel_bottom.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            lbKH.Enabled = false;
            lbCX.Enabled = false;
            lbX.Enabled = false;
            lbHD.Enabled = false;
            lbTK.Enabled = false;
            label1.Visible = false;
            btnLO.Visible = false;
            pictureBox2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            openChild(new khanhhang());
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            openChild(new chuxe());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            openChild(new xe());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new BUSadmin(txtTK.Text, txtPass.Text);
            
            if (a.checkInfo().Trim().Equals("Admin"))
            {
                admin ad = new admin();
                ad.ShowDialog();
            }
            else if (a.checkInfo().Trim().Equals("Staff"))
            {
                lbCX.Enabled = true;
                lbKH.Enabled = true;
                lbX.Enabled = true;
                openChild(new khanhhang());
                label1.Text = txtTK.Text;
                btnLO.Visible = true;
                label1.Visible = true;
                pictureBox2.Visible = true;
            }
            else if (a.checkInfo().Trim().Equals("Manager"))
            {
                lbTK.Enabled = true;
                lbHD.Enabled = true;
                openChild(new hoadon());
                label1.Text = txtTK.Text;
                btnLO.Visible = true;
                label1.Visible = true;
                pictureBox2.Visible=true;
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ");
            }
            txtTK.Clear();
            txtPass.Clear();
        }

        private void panel_left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbHD_Click(object sender, EventArgs e)
        {
            openChild(new hoadon());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                lbKH.Enabled = false;
                lbCX.Enabled = false;
                lbX.Enabled = false;
                lbHD.Enabled = false;
                lbTK.Enabled = false;
                label1.Visible = false;
                btnLO.Visible = false;
                pictureBox2.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pass pass = new Pass();
            pass.txtTK.Text = label1.Text;
            pass.ShowDialog();
        }

        private void lbTK_Click(object sender, EventArgs e)
        {
            openChild(new thongke());
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
