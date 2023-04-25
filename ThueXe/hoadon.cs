using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThueXe
{
    public partial class hoadon : Form
    {
        private BUSxe x;
        private BUShoadon h;
        private BUSkhachhang k;
        private BUStaikhoan t;
        private BUSCTHD ct;

        public hoadon()
        {
            InitializeComponent();
        }

        private void resetHD()
        {
            cboMaNV.SelectedIndex = 0;
            cboMaKH.SelectedIndex = 0;
            cboNX.SelectedIndex = 0;
            cboHTTT.SelectedIndex = 0;

            txtTenNV.Clear();
            txtDCKH.Clear();
            txtTenKH.Clear();

            txtMaXe.Clear();
            txtTX.Clear();
            txtDG.Clear();
            txtMaCX.Clear();

            dtNT.Text = DateTime.Now.ToString();
            dtNTA.Text = DateTime.Now.ToString();
        }

        private void loadHD()
        {
            dtXe.DataSource = x.selectXe();
            
            txtMaHD.ReadOnly = true;
            txtMaHD.Text = h.autoID(getNG(dtNT.Value.ToString().Substring(0, 10)));

            cboMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaNV.DisplayMember = "mataikhoan";
            cboMaNV.ValueMember = "mataikhoan";
            cboMaNV.DataSource = t.selectCV();
            txtTenNV.ReadOnly = true;


            cboMaKH.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaKH.DisplayMember = "makhachhang";
            cboMaKH.ValueMember = "makhachhang";
            cboMaKH.DataSource = k.selectKH();
            txtDCKH.ReadOnly = true;
            txtTenKH.ReadOnly = true;

            cboNX.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNX.SelectedIndex = 0;
            cboHTTT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHTTT.SelectedIndex = 0;

            txtMaXe.ReadOnly = true;
            txtTX.ReadOnly = true;
            txtMaCX.ReadOnly = true;
            txtDG.ReadOnly = true;

            h = new BUShoadon(txtMaHD.Text, cboMaNV.Text, cboMaKH.Text, txtTenNV.Text, dtNT.Value.ToString("yyyy-MM-dd"), 
                dtNTA.Value.ToString("yyyy-MM-dd"), cboNX.Text, 0);
            h.addHD();

            ct = new BUSCTHD(txtMaHD.Text, "", "", "", 0);
            dtCTHD.DataSource = ct.selectCTHD();
        }

        private string getNG(string s)
        {
            string[] subs = s.Split('/');

            string a;
            a = subs[0] + subs[1] + subs[2];
            return a;
        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            x = new BUSxe("", "", "", "", "", "", "", "", "", 0);
            h = new BUShoadon("","", "", "","", "", "", 0); 
            k = new BUSkhachhang("", "", "", "", "", "", "");
            t = new BUStaikhoan("", "", "", "", "", "", "", "Staff");

            loadHD();
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = cboMaNV.Items[cboMaNV.SelectedIndex] as DataRowView;
                if (row != null)
                {
                    string s = row["ten"].ToString();
                    txtTenNV.Text = s;
                }
            } catch { }
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = cboMaKH.Items[cboMaKH.SelectedIndex] as DataRowView;
                if (row != null)
                {
                    string ten = row["tenkhachhang"].ToString();
                    string dc = row["diachi"].ToString();

                    txtTenKH.Text = ten;
                    txtDCKH.Text = dc;
                }
            } catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ct = new BUSCTHD(txtMaHD.Text, "", "", "", 0);
            ct.delAllCTHD();
            h = new BUShoadon(txtMaHD.Text, "", "", "", "", "", "", 0);
            h.delHD();
            loadCTHD();
            resetCTHD();
            resetHD();
        }

        private void dtXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtXe_CellContentClick(sender, e);
        }

        private void dtXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtXe.CurrentCell.RowIndex;

            txtMaXe.Text = dtXe.Rows[index].Cells[0].Value.ToString();
            txtTX.Text = dtXe.Rows[index].Cells[2].Value.ToString();
            txtMaCX.Text = dtXe.Rows[index].Cells[3].Value.ToString();
            txtDG.Text = dtXe.Rows[index].Cells[4].Value.ToString();

        }

        private void loadCTHD()
        {
            dtCTHD.DataSource = ct.selectCTHD();
        }

        private void resetCTHD()
        {
            txtMaXe.Clear();
            txtTX.Clear();
            txtDG.Clear();
            txtMaCX.Clear();

            dtNT.Text = DateTime.Now.ToString();
            dtNTA.Text = DateTime.Now.ToString();
        }
        int tt;
        private void dtXe_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtXe.CurrentCell.RowIndex;
 
            string MX = dtXe.Rows[index].Cells[0].Value.ToString();
            string MCX = dtXe.Rows[index].Cells[2].Value.ToString();
            string TX = dtXe.Rows[index].Cells[3].Value.ToString();
            string TT = dtXe.Rows[index].Cells[9].Value.ToString().Trim();
            int DG = int.Parse(dtXe.Rows[index].Cells[4].Value.ToString());

            bool tr = true;
            if (dtCTHD.Rows.Count > 1)
            {
                for (int i = 0; i < dtCTHD.Rows.Count-1; i++)
                {
                    if (dtCTHD.Rows[i].Cells[1].Value.ToString().Equals(MX))
                    {
                        tr = false;
                    }
                }
            }

            if (!tr || TT.Equals("RENTING"))
            {
                
            } else
            {
                ct = new BUSCTHD(txtMaHD.Text, MX, TX, MCX, DG);
                ct.addCTHD();

                tt += DG;
                txtTien.Text = tt.ToString();
                loadCTHD();
                resetCTHD();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dtXe.CurrentCell.RowIndex;

            string MX = dtXe.Rows[index].Cells[0].Value.ToString();
            string TX = dtXe.Rows[index].Cells[2].Value.ToString();
            string MCX = dtXe.Rows[index].Cells[3].Value.ToString();
            int DG = int.Parse(dtXe.Rows[index].Cells[4].Value.ToString());

            ct = new BUSCTHD(txtMaHD.Text, MX, TX, MCX, DG);
            ct.addCTHD();
            loadCTHD();
            resetCTHD();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTien.Text != "" & txtTien.Text != "0")
            {
                h = new BUShoadon(txtMaHD.Text, cboMaNV.Text, cboMaKH.Text, cboNX.Text, dtNT.Value.ToString("yyyy-MM-dd"), dtNTA.Value.ToString("yyyy-MM-dd"), cboHTTT.Text, tt);
                h.editHD();

                for (int i = 0; i < dtCTHD.Rows.Count - 1; i++)
                {
                    string maxe = dtCTHD.Rows[i].Cells[1].Value.ToString();
                    x = new BUSxe(maxe, "", "", "", "", "", "", "", "", 0);
                    x.updateSTX();
                }                
            }
            loadHD();
            resetHD();
        }

        private void dtCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hoadon_FormClosed(object sender, FormClosedEventArgs e)
        {
            ct = new BUSCTHD(txtMaHD.Text, "", "", "", 0);
            ct.delAllCTHD();
            h = new BUShoadon(txtMaHD.Text, "", "", "", "", "", "", 0);
            h.delHD();
        }

        private void dtXe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtXe_CellContentDoubleClick(sender, e);
        }

        private void dtCTHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtCTHD.CurrentCell.RowIndex;
            string maxe = dtCTHD.Rows[index].Cells[1].Value.ToString();
            ct = new BUSCTHD(txtMaHD.Text, maxe, "", "", 0);
            ct.delCTHD();
            loadCTHD();
            resetCTHD();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            findxe f = new findxe();
            f.ShowDialog();
        }
    }
}
