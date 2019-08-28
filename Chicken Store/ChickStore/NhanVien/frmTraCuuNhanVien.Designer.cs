namespace ChickStore.NhanVien
{
    partial class frmTraCuuNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuNhanVien));
            this.lblChamCong = new System.Windows.Forms.Label();
            this.lblMSNV = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.bntClose = new System.Windows.Forms.Button();
            this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChamCong
            // 
            this.lblChamCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChamCong.AutoSize = true;
            this.lblChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChamCong.ForeColor = System.Drawing.Color.Blue;
            this.lblChamCong.Location = new System.Drawing.Point(129, 11);
            this.lblChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChamCong.Name = "lblChamCong";
            this.lblChamCong.Size = new System.Drawing.Size(591, 39);
            this.lblChamCong.TabIndex = 2;
            this.lblChamCong.Text = "TRA CỨU THÔNG TIN NHÂN VIÊN";
            this.lblChamCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMSNV
            // 
            this.lblMSNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMSNV.AutoSize = true;
            this.lblMSNV.Location = new System.Drawing.Point(121, 80);
            this.lblMSNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSNV.Name = "lblMSNV";
            this.lblMSNV.Size = new System.Drawing.Size(51, 17);
            this.lblMSNV.TabIndex = 3;
            this.lblMSNV.Text = "MSNV:";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMSNV.Location = new System.Drawing.Point(184, 76);
            this.txtMSNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(177, 22);
            this.txtMSNV.TabIndex = 4;
            this.txtMSNV.TextChanged += new System.EventHandler(this.txtMSNV_TextChanged);
            // 
            // lblTenNV
            // 
            this.lblTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(371, 80);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(95, 17);
            this.lblTenNV.TabIndex = 5;
            this.lblTenNV.Text = "hoặc Tên NV:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNV.Location = new System.Drawing.Point(477, 76);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(177, 22);
            this.txtTenNV.TabIndex = 6;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT,
            this.cMSNV,
            this.cTenNV,
            this.cNgaySinh,
            this.cGioiTinh,
            this.cQueQuan,
            this.BoPhan,
            this.cNgayNhan});
            this.dgvNhanVien.Location = new System.Drawing.Point(16, 128);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(877, 256);
            this.dgvNhanVien.TabIndex = 8;
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.Location = new System.Drawing.Point(793, 400);
            this.bntClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(100, 28);
            this.bntClose.TabIndex = 9;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // cSTT
            // 
            this.cSTT.HeaderText = "STT";
            this.cSTT.MaxInputLength = 2;
            this.cSTT.Name = "cSTT";
            this.cSTT.ReadOnly = true;
            this.cSTT.Width = 35;
            // 
            // cMSNV
            // 
            this.cMSNV.DataPropertyName = "MSNV";
            this.cMSNV.HeaderText = "MSNV";
            this.cMSNV.MaxInputLength = 10;
            this.cMSNV.Name = "cMSNV";
            this.cMSNV.ReadOnly = true;
            this.cMSNV.Width = 70;
            // 
            // cTenNV
            // 
            this.cTenNV.DataPropertyName = "HoTenNV";
            this.cTenNV.HeaderText = "Tên Nhân Viên";
            this.cTenNV.MaxInputLength = 100;
            this.cTenNV.Name = "cTenNV";
            this.cTenNV.ReadOnly = true;
            this.cTenNV.Width = 150;
            // 
            // cNgaySinh
            // 
            this.cNgaySinh.DataPropertyName = "NgSinh";
            this.cNgaySinh.HeaderText = "Ngày Sinh";
            this.cNgaySinh.MaxInputLength = 10;
            this.cNgaySinh.Name = "cNgaySinh";
            this.cNgaySinh.ReadOnly = true;
            this.cNgaySinh.Width = 75;
            // 
            // cGioiTinh
            // 
            this.cGioiTinh.DataPropertyName = "GioiTinh";
            this.cGioiTinh.HeaderText = "Giới Tính";
            this.cGioiTinh.MaxInputLength = 3;
            this.cGioiTinh.Name = "cGioiTinh";
            this.cGioiTinh.ReadOnly = true;
            this.cGioiTinh.Width = 40;
            // 
            // cQueQuan
            // 
            this.cQueQuan.DataPropertyName = "QueQuan";
            this.cQueQuan.HeaderText = "Quê Quán";
            this.cQueQuan.MaxInputLength = 255;
            this.cQueQuan.Name = "cQueQuan";
            this.cQueQuan.ReadOnly = true;
            // 
            // BoPhan
            // 
            this.BoPhan.DataPropertyName = "MaBoPhan";
            this.BoPhan.HeaderText = "Bộ Phận";
            this.BoPhan.MaxInputLength = 50;
            this.BoPhan.Name = "BoPhan";
            this.BoPhan.ReadOnly = true;
            this.BoPhan.Width = 70;
            // 
            // cNgayNhan
            // 
            this.cNgayNhan.DataPropertyName = "NgayTiepNhan";
            this.cNgayNhan.HeaderText = "Ngày Tiếp Nhận";
            this.cNgayNhan.MaxInputLength = 10;
            this.cNgayNhan.Name = "cNgayNhan";
            this.cNgayNhan.ReadOnly = true;
            this.cNgayNhan.Width = 75;
            // 
            // frmTraCuuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 443);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.lblMSNV);
            this.Controls.Add(this.lblChamCong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTraCuuNhanVien";
            this.Text = "Tra cứu thông tin nhân viên";
            this.Load += new System.EventHandler(this.frmTraCuuNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChamCong;
        private System.Windows.Forms.Label lblMSNV;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayNhan;
    }
}