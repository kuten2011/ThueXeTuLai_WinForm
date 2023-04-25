using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThueXe
{
    public partial class thongke : Form
    {
        private BUShoadon h;
        private BUSCTHD ct;
        public thongke()
        {
            InitializeComponent();
        }

        private void LHD()
        {
            int i = dlT.RowCount - 1;
            txtTHD.Text = i.ToString();

            int t = 0;
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    t += int.Parse(dlT.Rows[j].Cells[7].Value.ToString());
                }
            }
            txtTT.Text = t.ToString();
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            h = new BUShoadon("", "", "", "", "", "", "", 0);
            dlT.DataSource = h.select();
            LHD();

            cboLNT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLNT.DisplayMember = "ngaythue";
            cboLNT.DataSource = h.selectNT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lọc từ "+cboLNT.Text+" tới "+cboLNTA.Text);
            DateTime date = DateTime.ParseExact(cboLNT.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string NT = date.ToString("yyyy/MM/dd");

            date = DateTime.ParseExact(cboLNTA.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string NTA = date.ToString("yyyy/MM/dd");
            h = new BUShoadon("", "", "", "", NT, NTA, "",0);
            dlT.DataSource = h.selectLHD();

            LHD() ;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
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

        private void cboLNT_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(cboLNT.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string NT = date.ToString("yyyy/MM/dd");
            h = new BUShoadon("", "", "", "", NT, "", "", 0);

            cboLNTA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLNTA.DisplayMember = "ngaytra";
            cboLNTA.DataSource = h.selectNTA();
        }
    }
}
