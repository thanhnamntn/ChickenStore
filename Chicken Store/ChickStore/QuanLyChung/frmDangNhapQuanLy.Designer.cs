namespace ChickStore.QuanLyChung
{
    partial class frmDangNhapQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhapQuanLy));
            this.sttStatusSignIn = new System.Windows.Forms.StatusStrip();
            this.sttlblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIDQL = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.txtPwdQL = new System.Windows.Forms.TextBox();
            this.bntSignIn = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.sttStatusSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
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
            this.lblID.Location = new System.Drawing.Point(165, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "Mã QL:";
            // 
            // txtIDQL
            // 
            this.txtIDQL.Location = new System.Drawing.Point(213, 46);
            this.txtIDQL.Name = "txtIDQL";
            this.txtIDQL.Size = new System.Drawing.Size(122, 20);
            this.txtIDQL.TabIndex = 17;
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
            // pic1
            // 
            this.pic1.Image = global::ChickStore.Properties.Resources.logo;
            this.pic1.Location = new System.Drawing.Point(12, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(128, 128);
            this.pic1.TabIndex = 16;
            this.pic1.TabStop = false;
            // 
            // txtPwdQL
            // 
            this.txtPwdQL.Location = new System.Drawing.Point(213, 72);
            this.txtPwdQL.Name = "txtPwdQL";
            this.txtPwdQL.Size = new System.Drawing.Size(122, 20);
            this.txtPwdQL.TabIndex = 19;
            this.txtPwdQL.UseSystemPasswordChar = true;
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
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(155, 100);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(87, 40);
            this.bntClose.TabIndex = 24;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // frmDangNhapQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 175);
            this.Controls.Add(this.sttStatusSignIn);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtIDQL);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.txtPwdQL);
            this.Controls.Add(this.bntSignIn);
            this.Controls.Add(this.bntClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhapQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập Quản lý";
            this.TopMost = true;
            this.sttStatusSignIn.ResumeLayout(false);
            this.sttStatusSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttStatusSignIn;
        private System.Windows.Forms.ToolStripStatusLabel sttlblTime;
        private System.Windows.Forms.ToolStripStatusLabel sttTime;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtIDQL;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.TextBox txtPwdQL;
        private System.Windows.Forms.Button bntSignIn;
        private System.Windows.Forms.Button bntClose;
    }
}