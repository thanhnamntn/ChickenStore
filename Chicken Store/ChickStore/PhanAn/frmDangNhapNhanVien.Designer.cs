namespace ChickStore.PhanAn
{
    partial class frmDangNhapNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhapNhanVien));
            this.sttStatusSignIn = new System.Windows.Forms.StatusStrip();
            this.sttlblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIDNV = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntHelp1 = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.bntSignIn = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.sttStatusSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sttStatusSignIn
            // 
            this.sttStatusSignIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttlblTime,
            this.sttTime});
            this.sttStatusSignIn.Location = new System.Drawing.Point(0, 153);
            this.sttStatusSignIn.Name = "sttStatusSignIn";
            this.sttStatusSignIn.Size = new System.Drawing.Size(359, 22);
            this.sttStatusSignIn.TabIndex = 23;
            // 
            // sttlblTime
            // 
            this.sttlblTime.Name = "sttlblTime";
            this.sttlblTime.Size = new System.Drawing.Size(60, 17);
            this.sttlblTime.Text = "Thời gian:";
            // 
            // sttTime
            // 
            this.sttTime.Name = "sttTime";
            this.sttTime.Size = new System.Drawing.Size(90, 17);
            this.sttTime.Text = "Đang khởi tạo...";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(152, 75);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(55, 13);
            this.lblPwd.TabIndex = 20;
            this.lblPwd.Text = "Mật khẩu:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(164, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "Mã NV:";
            // 
            // txtIDNV
            // 
            this.txtIDNV.Location = new System.Drawing.Point(213, 46);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.Size = new System.Drawing.Size(122, 20);
            this.txtIDNV.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(181, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 29);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChickStore.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // bntHelp1
            // 
            this.bntHelp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntHelp1.ForeColor = System.Drawing.Color.Blue;
            this.bntHelp1.Location = new System.Drawing.Point(336, 0);
            this.bntHelp1.Name = "bntHelp1";
            this.bntHelp1.Size = new System.Drawing.Size(23, 23);
            this.bntHelp1.TabIndex = 25;
            this.bntHelp1.Text = "?";
            this.bntHelp1.UseVisualStyleBackColor = true;
            this.bntHelp1.Click += new System.EventHandler(this.bntHelp1_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(213, 72);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(122, 20);
            this.txtPwd.TabIndex = 19;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // bntSignIn
            // 
            this.bntSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntSignIn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bntSignIn.Location = new System.Drawing.Point(248, 100);
            this.bntSignIn.Name = "bntSignIn";
            this.bntSignIn.Size = new System.Drawing.Size(87, 40);
            this.bntSignIn.TabIndex = 22;
            this.bntSignIn.Text = "Đăng nhập";
            this.bntSignIn.UseVisualStyleBackColor = true;
            this.bntSignIn.Click += new System.EventHandler(this.bntSignIn_Click);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(155, 100);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(87, 40);
            this.bntExit.TabIndex = 24;
            this.bntExit.Text = "Thoát";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // frmDangNhapNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 175);
            this.Controls.Add(this.sttStatusSignIn);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtIDNV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntHelp1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.bntSignIn);
            this.Controls.Add(this.bntExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhapNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập Nhân viên";
            this.sttStatusSignIn.ResumeLayout(false);
            this.sttStatusSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttStatusSignIn;
        private System.Windows.Forms.ToolStripStatusLabel sttlblTime;
        private System.Windows.Forms.ToolStripStatusLabel sttTime;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtIDNV;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntHelp1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button bntSignIn;
        private System.Windows.Forms.Button bntExit;
    }
}