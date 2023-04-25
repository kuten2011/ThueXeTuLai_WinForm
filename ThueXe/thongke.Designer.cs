namespace ThueXe
{
    partial class thongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thongke));
            this.dlT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTHD = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLNT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLNTA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dlT)).BeginInit();
            this.SuspendLayout();
            // 
            // dlT
            // 
            this.dlT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlT.Location = new System.Drawing.Point(13, 12);
            this.dlT.Name = "dlT";
            this.dlT.RowHeadersWidth = 51;
            this.dlT.RowTemplate.Height = 24;
            this.dlT.Size = new System.Drawing.Size(1095, 599);
            this.dlT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng Hóa Đơn";
            // 
            // txtTHD
            // 
            this.txtTHD.Location = new System.Drawing.Point(146, 645);
            this.txtTHD.Name = "txtTHD";
            this.txtTHD.Size = new System.Drawing.Size(136, 22);
            this.txtTHD.TabIndex = 5;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(387, 645);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(136, 22);
            this.txtTT.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng Tiền";
            // 
            // cboLNT
            // 
            this.cboLNT.FormattingEnabled = true;
            this.cboLNT.Location = new System.Drawing.Point(745, 645);
            this.cboLNT.Name = "cboLNT";
            this.cboLNT.Size = new System.Drawing.Size(151, 24);
            this.cboLNT.TabIndex = 8;
            this.cboLNT.SelectedIndexChanged += new System.EventHandler(this.cboLNT_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(769, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày Thuê";
            // 
            // cboLNTA
            // 
            this.cboLNTA.FormattingEnabled = true;
            this.cboLNTA.Location = new System.Drawing.Point(901, 643);
            this.cboLNTA.Name = "cboLNTA";
            this.cboLNTA.Size = new System.Drawing.Size(151, 24);
            this.cboLNTA.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(933, 618);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày Trả";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1058, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(550, 631);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 47);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button2_Click);
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 688);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLNTA);
            this.Controls.Add(this.cboLNT);
            this.Controls.Add(this.txtTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dlT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "thongke";
            this.Text = "thongke";
            this.Load += new System.EventHandler(this.thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.DataGridView dlT;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTHD;
        public System.Windows.Forms.TextBox txtTT;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboLNT;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboLNTA;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
    }
}