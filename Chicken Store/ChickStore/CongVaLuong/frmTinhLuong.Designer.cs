namespace ChickStore.CongVaLuong
{
    partial class frmTinhLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhLuong));
            this.lblChamCong = new System.Windows.Forms.Label();
            this.dgvBangChamCong = new System.Windows.Forms.DataGridView();
            this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntClose = new System.Windows.Forms.Button();
            this.lblThangChamCong = new System.Windows.Forms.Label();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblTienLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChamCong
            // 
            this.lblChamCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChamCong.AutoSize = true;
            this.lblChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChamCong.ForeColor = System.Drawing.Color.Blue;
            this.lblChamCong.Location = new System.Drawing.Point(158, 11);
            this.lblChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChamCong.Name = "lblChamCong";
            this.lblChamCong.Size = new System.Drawing.Size(254, 39);
            this.lblChamCong.TabIndex = 1;
            this.lblChamCong.Text = "BẢNG LƯƠNG";
            this.lblChamCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvBangChamCong
            // 
            this.dgvBangChamCong.AllowUserToAddRows = false;
            this.dgvBangChamCong.AllowUserToDeleteRows = false;
            this.dgvBangChamCong.AllowUserToOrderColumns = true;
            this.dgvBangChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT,
            this.MSNV,
            this.TenNV,
            this.NgayCongThuong,
            this.NgayCongLe});
            this.dgvBangChamCong.Location = new System.Drawing.Point(16, 56);
            this.dgvBangChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangChamCong.Name = "dgvBangChamCong";
            this.dgvBangChamCong.ReadOnly = true;
            this.dgvBangChamCong.Size = new System.Drawing.Size(807, 349);
            this.dgvBangChamCong.TabIndex = 6;
            // 
            // cSTT
            // 
            this.cSTT.HeaderText = "STT";
            this.cSTT.Name = "cSTT";
            this.cSTT.ReadOnly = true;
            this.cSTT.Width = 35;
            // 
            // MSNV
            // 
            this.MSNV.DataPropertyName = "MSNV";
            this.MSNV.HeaderText = "MSNV";
            this.MSNV.MaxInputLength = 10;
            this.MSNV.Name = "MSNV";
            this.MSNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "HoTenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MaxInputLength = 100;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 150;
            // 
            // NgayCongThuong
            // 
            this.NgayCongThuong.DataPropertyName = "NgayCongThuong";
            this.NgayCongThuong.HeaderText = "Ngày Công Thường";
            this.NgayCongThuong.MaxInputLength = 2;
            this.NgayCongThuong.Name = "NgayCongThuong";
            this.NgayCongThuong.ReadOnly = true;
            this.NgayCongThuong.Width = 145;
            // 
            // NgayCongLe
            // 
            this.NgayCongLe.DataPropertyName = "NgayCongLe";
            this.NgayCongLe.HeaderText = "Ngày Công Lễ";
            this.NgayCongLe.MaxInputLength = 2;
            this.NgayCongLe.Name = "NgayCongLe";
            this.NgayCongLe.ReadOnly = true;
            this.NgayCongLe.Width = 130;
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.Location = new System.Drawing.Point(723, 413);
            this.bntClose.Margin = new System.Windows.Forms.Padding(4);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(100, 35);
            this.bntClose.TabIndex = 8;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // lblThangChamCong
            // 
            this.lblThangChamCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThangChamCong.AutoSize = true;
            this.lblThangChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThangChamCong.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblThangChamCong.Location = new System.Drawing.Point(439, 11);
            this.lblThangChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThangChamCong.Name = "lblThangChamCong";
            this.lblThangChamCong.Size = new System.Drawing.Size(39, 39);
            this.lblThangChamCong.TabIndex = 9;
            this.lblThangChamCong.Text = "T";
            this.lblThangChamCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTinhLuong.Location = new System.Drawing.Point(589, 413);
            this.btnTinhLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(126, 35);
            this.btnTinhLuong.TabIndex = 10;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // lb
            // 
            this.lb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(41, 419);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(135, 25);
            this.lb.TabIndex = 11;
            this.lb.Text = "NHÂN VIÊN:";
            this.lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "TIỀN LƯƠNG:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTenNV
            // 
            this.lblTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Black;
            this.lblTenNV.Location = new System.Drawing.Point(184, 419);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(2, 22);
            this.lblTenNV.TabIndex = 13;
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTienLuong
            // 
            this.lblTienLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTienLuong.AutoSize = true;
            this.lblTienLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTienLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienLuong.ForeColor = System.Drawing.Color.Black;
            this.lblTienLuong.Location = new System.Drawing.Point(441, 423);
            this.lblTienLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienLuong.Name = "lblTienLuong";
            this.lblTienLuong.Size = new System.Drawing.Size(2, 22);
            this.lblTienLuong.TabIndex = 14;
            this.lblTienLuong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 455);
            this.Controls.Add(this.lblTienLuong);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.lblThangChamCong);
            this.Controls.Add(this.dgvBangChamCong);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.lblChamCong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tính lương";
            this.Load += new System.EventHandler(this.frmTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChamCong;
        private System.Windows.Forms.DataGridView dgvBangChamCong;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Label lblThangChamCong;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblTienLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongLe;
    }
}