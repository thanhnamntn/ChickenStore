namespace ChickStore.PhanAn
{
    partial class frmGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiamGia));
            this.lblPwqQLCa = new System.Windows.Forms.Label();
            this.txtPwdQL = new System.Windows.Forms.TextBox();
            this.grpQLInfo = new System.Windows.Forms.GroupBox();
            this.txtIDQL = new System.Windows.Forms.TextBox();
            this.lblMaQL = new System.Windows.Forms.Label();
            this.grpDiscountInfo = new System.Windows.Forms.GroupBox();
            this.bntDis20 = new System.Windows.Forms.Button();
            this.bntDis15 = new System.Windows.Forms.Button();
            this.bntDis10 = new System.Windows.Forms.Button();
            this.bntDelDis = new System.Windows.Forms.Button();
            this.bntHD = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.grpQLInfo.SuspendLayout();
            this.grpDiscountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPwqQLCa
            // 
            this.lblPwqQLCa.AutoSize = true;
            this.lblPwqQLCa.Location = new System.Drawing.Point(216, 27);
            this.lblPwqQLCa.Name = "lblPwqQLCa";
            this.lblPwqQLCa.Size = new System.Drawing.Size(55, 13);
            this.lblPwqQLCa.TabIndex = 99;
            this.lblPwqQLCa.Text = "Mật khẩu:";
            // 
            // txtPwdQL
            // 
            this.txtPwdQL.Location = new System.Drawing.Point(277, 24);
            this.txtPwdQL.Name = "txtPwdQL";
            this.txtPwdQL.Size = new System.Drawing.Size(100, 20);
            this.txtPwdQL.TabIndex = 2;
            this.txtPwdQL.UseSystemPasswordChar = true;
            // 
            // grpQLInfo
            // 
            this.grpQLInfo.Controls.Add(this.lblPwqQLCa);
            this.grpQLInfo.Controls.Add(this.txtPwdQL);
            this.grpQLInfo.Controls.Add(this.txtIDQL);
            this.grpQLInfo.Controls.Add(this.lblMaQL);
            this.grpQLInfo.Location = new System.Drawing.Point(12, 10);
            this.grpQLInfo.Name = "grpQLInfo";
            this.grpQLInfo.Size = new System.Drawing.Size(400, 61);
            this.grpQLInfo.TabIndex = 14;
            this.grpQLInfo.TabStop = false;
            this.grpQLInfo.Text = "Thông tin quản lý";
            // 
            // txtIDQL
            // 
            this.txtIDQL.Location = new System.Drawing.Point(84, 24);
            this.txtIDQL.Name = "txtIDQL";
            this.txtIDQL.Size = new System.Drawing.Size(100, 20);
            this.txtIDQL.TabIndex = 1;
            // 
            // lblMaQL
            // 
            this.lblMaQL.AutoSize = true;
            this.lblMaQL.Location = new System.Drawing.Point(16, 27);
            this.lblMaQL.Name = "lblMaQL";
            this.lblMaQL.Size = new System.Drawing.Size(62, 13);
            this.lblMaQL.TabIndex = 99;
            this.lblMaQL.Text = "Mã quản lý:";
            // 
            // grpDiscountInfo
            // 
            this.grpDiscountInfo.Controls.Add(this.bntDis20);
            this.grpDiscountInfo.Controls.Add(this.bntDis15);
            this.grpDiscountInfo.Controls.Add(this.bntDis10);
            this.grpDiscountInfo.Location = new System.Drawing.Point(12, 77);
            this.grpDiscountInfo.Name = "grpDiscountInfo";
            this.grpDiscountInfo.Size = new System.Drawing.Size(400, 137);
            this.grpDiscountInfo.TabIndex = 15;
            this.grpDiscountInfo.TabStop = false;
            this.grpDiscountInfo.Text = "Thông tin giảm giá";
            // 
            // bntDis20
            // 
            this.bntDis20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntDis20.Image = global::ChickStore.Properties.Resources.d20;
            this.bntDis20.Location = new System.Drawing.Point(277, 19);
            this.bntDis20.Name = "bntDis20";
            this.bntDis20.Size = new System.Drawing.Size(105, 105);
            this.bntDis20.TabIndex = 5;
            this.bntDis20.UseVisualStyleBackColor = true;
            this.bntDis20.Click += new System.EventHandler(this.bntDis20_Click);
            // 
            // bntDis15
            // 
            this.bntDis15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntDis15.Image = global::ChickStore.Properties.Resources.d15;
            this.bntDis15.Location = new System.Drawing.Point(146, 19);
            this.bntDis15.Name = "bntDis15";
            this.bntDis15.Size = new System.Drawing.Size(105, 105);
            this.bntDis15.TabIndex = 4;
            this.bntDis15.UseVisualStyleBackColor = true;
            this.bntDis15.Click += new System.EventHandler(this.bntDis15_Click);
            // 
            // bntDis10
            // 
            this.bntDis10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntDis10.Image = global::ChickStore.Properties.Resources.d10;
            this.bntDis10.Location = new System.Drawing.Point(15, 19);
            this.bntDis10.Name = "bntDis10";
            this.bntDis10.Size = new System.Drawing.Size(105, 105);
            this.bntDis10.TabIndex = 3;
            this.bntDis10.UseVisualStyleBackColor = true;
            this.bntDis10.Click += new System.EventHandler(this.bntDis10_Click);
            // 
            // bntDelDis
            // 
            this.bntDelDis.ForeColor = System.Drawing.Color.Crimson;
            this.bntDelDis.Location = new System.Drawing.Point(12, 220);
            this.bntDelDis.Name = "bntDelDis";
            this.bntDelDis.Size = new System.Drawing.Size(81, 23);
            this.bntDelDis.TabIndex = 16;
            this.bntDelDis.Text = "Xoá giảm giá";
            this.bntDelDis.UseVisualStyleBackColor = true;
            this.bntDelDis.Click += new System.EventHandler(this.bntDelDis_Click);
            // 
            // bntHD
            // 
            this.bntHD.Location = new System.Drawing.Point(256, 220);
            this.bntHD.Name = "bntHD";
            this.bntHD.Size = new System.Drawing.Size(75, 23);
            this.bntHD.TabIndex = 17;
            this.bntHD.Text = "Hướng dẫn";
            this.bntHD.UseVisualStyleBackColor = true;
            this.bntHD.Click += new System.EventHandler(this.bntHD_Click);
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(337, 220);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(75, 23);
            this.bntClose.TabIndex = 18;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // frmGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 252);
            this.Controls.Add(this.grpQLInfo);
            this.Controls.Add(this.grpDiscountInfo);
            this.Controls.Add(this.bntDelDis);
            this.Controls.Add(this.bntHD);
            this.Controls.Add(this.bntClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGiamGia";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giảm giá phần ăn";
            this.TopMost = true;
            this.grpQLInfo.ResumeLayout(false);
            this.grpQLInfo.PerformLayout();
            this.grpDiscountInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPwqQLCa;
        private System.Windows.Forms.TextBox txtPwdQL;
        private System.Windows.Forms.GroupBox grpQLInfo;
        private System.Windows.Forms.TextBox txtIDQL;
        private System.Windows.Forms.Label lblMaQL;
        private System.Windows.Forms.GroupBox grpDiscountInfo;
        private System.Windows.Forms.Button bntDis20;
        private System.Windows.Forms.Button bntDis15;
        private System.Windows.Forms.Button bntDis10;
        private System.Windows.Forms.Button bntDelDis;
        private System.Windows.Forms.Button bntHD;
        private System.Windows.Forms.Button bntClose;
    }
}