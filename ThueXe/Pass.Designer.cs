namespace ThueXe
{
    partial class Pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pass));
            this.txtPas2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtPas1 = new System.Windows.Forms.TextBox();
            this.txtOP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPas2
            // 
            this.txtPas2.Location = new System.Drawing.Point(445, 337);
            this.txtPas2.Name = "txtPas2";
            this.txtPas2.Size = new System.Drawing.Size(233, 22);
            this.txtPas2.TabIndex = 1;
            this.txtPas2.UseSystemPasswordChar = true;
            this.txtPas2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter New Pass";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Old Pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "User";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(445, 79);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(233, 22);
            this.txtTK.TabIndex = 7;
            // 
            // txtPas1
            // 
            this.txtPas1.Location = new System.Drawing.Point(445, 244);
            this.txtPas1.Name = "txtPas1";
            this.txtPas1.Size = new System.Drawing.Size(233, 22);
            this.txtPas1.TabIndex = 9;
            this.txtPas1.UseSystemPasswordChar = true;
            // 
            // txtOP
            // 
            this.txtOP.Location = new System.Drawing.Point(445, 160);
            this.txtOP.Name = "txtOP";
            this.txtOP.Size = new System.Drawing.Size(233, 22);
            this.txtOP.TabIndex = 10;
            this.txtOP.UseSystemPasswordChar = true;
            // 
            // Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 458);
            this.Controls.Add(this.txtOP);
            this.Controls.Add(this.txtPas1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPas2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pass";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPas1;
        public System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtOP;
    }
}