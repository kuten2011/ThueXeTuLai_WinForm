namespace ThueXe
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel_left = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLO = new System.Windows.Forms.Button();
            this.lbHD = new System.Windows.Forms.Label();
            this.lbKH = new System.Windows.Forms.Label();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbCX = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_left.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.Cyan;
            this.panel_left.Controls.Add(this.pictureBox2);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Controls.Add(this.btnLO);
            this.panel_left.Controls.Add(this.lbHD);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Controls.Add(this.lbKH);
            this.panel_left.Controls.Add(this.lbTK);
            this.panel_left.Controls.Add(this.lbCX);
            this.panel_left.Controls.Add(this.lbX);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(200, 835);
            this.panel_left.TabIndex = 0;
            this.panel_left.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_left_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(75, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // btnLO
            // 
            this.btnLO.Location = new System.Drawing.Point(6, 760);
            this.btnLO.Name = "btnLO";
            this.btnLO.Size = new System.Drawing.Size(188, 63);
            this.btnLO.TabIndex = 12;
            this.btnLO.Text = "Đăng Xuất";
            this.btnLO.UseVisualStyleBackColor = true;
            this.btnLO.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbHD
            // 
            this.lbHD.AutoSize = true;
            this.lbHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHD.ForeColor = System.Drawing.Color.Chocolate;
            this.lbHD.Location = new System.Drawing.Point(12, 471);
            this.lbHD.Name = "lbHD";
            this.lbHD.Size = new System.Drawing.Size(150, 25);
            this.lbHD.TabIndex = 11;
            this.lbHD.Text = "Quản lí hóa đơn";
            this.lbHD.Click += new System.EventHandler(this.lbHD_Click);
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKH.ForeColor = System.Drawing.Color.Chocolate;
            this.lbKH.Location = new System.Drawing.Point(12, 276);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(181, 25);
            this.lbKH.TabIndex = 5;
            this.lbKH.Text = "Quản lí khách hàng";
            this.lbKH.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.ForeColor = System.Drawing.Color.Chocolate;
            this.lbTK.Location = new System.Drawing.Point(12, 536);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(164, 25);
            this.lbTK.TabIndex = 9;
            this.lbTK.Text = "Báo cáo thông kê";
            this.lbTK.Click += new System.EventHandler(this.lbTK_Click);
            // 
            // lbCX
            // 
            this.lbCX.AutoSize = true;
            this.lbCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCX.ForeColor = System.Drawing.Color.Chocolate;
            this.lbCX.Location = new System.Drawing.Point(12, 341);
            this.lbCX.Name = "lbCX";
            this.lbCX.Size = new System.Drawing.Size(137, 25);
            this.lbCX.TabIndex = 6;
            this.lbCX.Text = "Quản lí chủ xe";
            this.lbCX.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.ForeColor = System.Drawing.Color.Chocolate;
            this.lbX.Location = new System.Drawing.Point(12, 406);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(100, 25);
            this.lbX.TabIndex = 7;
            this.lbX.Text = "Quản lí xe";
            this.lbX.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label6);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(200, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1138, 100);
            this.panel_top.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1138, 100);
            this.label6.TabIndex = 0;
            this.label6.Text = "PHẦN MỀM QUẢN LÝ THUÊ Ô TÔ TỰ LÁI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.label4);
            this.panel_bottom.Controls.Add(this.button1);
            this.panel_bottom.Controls.Add(this.label7);
            this.panel_bottom.Controls.Add(this.label8);
            this.panel_bottom.Controls.Add(this.txtPass);
            this.panel_bottom.Controls.Add(this.txtTK);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Location = new System.Drawing.Point(200, 100);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1138, 735);
            this.panel_bottom.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(433, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 62);
            this.label4.TabIndex = 11;
            this.label4.Text = "WELCOME";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "User";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(467, 327);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(195, 22);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(467, 265);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(195, 22);
            this.txtTK.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ThueXe.Properties.Resources.OIP;
            this.pictureBox2.Location = new System.Drawing.Point(17, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThueXe.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 835);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Trangchu";
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbCX;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbHD;
        private System.Windows.Forms.Button btnLO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}