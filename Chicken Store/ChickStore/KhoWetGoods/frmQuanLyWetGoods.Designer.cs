namespace ChickStore.KhoWetGoods
{
    partial class frmQuanLyWetGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyWetGoods));
            this.lblNhapWG = new System.Windows.Forms.Label();
            this.dgvKhoWG = new System.Windows.Forms.DataGridView();
            this.bntNhapWG = new System.Windows.Forms.Button();
            this.bntXuatWG = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSLGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThucNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoWG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhapWG
            // 
            this.lblNhapWG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhapWG.AutoSize = true;
            this.lblNhapWG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapWG.ForeColor = System.Drawing.Color.Blue;
            this.lblNhapWG.Location = new System.Drawing.Point(173, 11);
            this.lblNhapWG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapWG.Name = "lblNhapWG";
            this.lblNhapWG.Size = new System.Drawing.Size(480, 39);
            this.lblNhapWG.TabIndex = 16;
            this.lblNhapWG.Text = "QUẢN LÝ KHO WETGOODS";
            this.lblNhapWG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvKhoWG
            // 
            this.dgvKhoWG.AllowUserToAddRows = false;
            this.dgvKhoWG.AllowUserToDeleteRows = false;
            this.dgvKhoWG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhoWG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoWG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT,
            this.cMaHang,
            this.cTenHang,
            this.cDVT,
            this.cSLGiao,
            this.cThucNhan,
            this.cNgayNhap,
            this.cHSD});
            this.dgvKhoWG.Location = new System.Drawing.Point(16, 64);
            this.dgvKhoWG.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhoWG.Name = "dgvKhoWG";
            this.dgvKhoWG.ReadOnly = true;
            this.dgvKhoWG.Size = new System.Drawing.Size(840, 437);
            this.dgvKhoWG.TabIndex = 17;
            // 
            // bntNhapWG
            // 
            this.bntNhapWG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntNhapWG.Location = new System.Drawing.Point(16, 508);
            this.bntNhapWG.Margin = new System.Windows.Forms.Padding(4);
            this.bntNhapWG.Name = "bntNhapWG";
            this.bntNhapWG.Size = new System.Drawing.Size(213, 28);
            this.bntNhapWG.TabIndex = 18;
            this.bntNhapWG.Text = "Nhập hàng";
            this.bntNhapWG.UseVisualStyleBackColor = true;
            this.bntNhapWG.Click += new System.EventHandler(this.bntNhapWG_Click);
            // 
            // bntXuatWG
            // 
            this.bntXuatWG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntXuatWG.Location = new System.Drawing.Point(237, 508);
            this.bntXuatWG.Margin = new System.Windows.Forms.Padding(4);
            this.bntXuatWG.Name = "bntXuatWG";
            this.bntXuatWG.Size = new System.Drawing.Size(213, 28);
            this.bntXuatWG.TabIndex = 19;
            this.bntXuatWG.Text = "Xuất hàng";
            this.bntXuatWG.UseVisualStyleBackColor = true;
            this.bntXuatWG.Click += new System.EventHandler(this.bntXuatWG_Click);
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.Location = new System.Drawing.Point(756, 508);
            this.bntClose.Margin = new System.Windows.Forms.Padding(4);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(100, 28);
            this.bntClose.TabIndex = 20;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // cSTT
            // 
            this.cSTT.HeaderText = "STT";
            this.cSTT.Name = "cSTT";
            this.cSTT.ReadOnly = true;
            this.cSTT.Width = 35;
            // 
            // cMaHang
            // 
            this.cMaHang.DataPropertyName = "MaHang";
            this.cMaHang.HeaderText = "Mã Hàng";
            this.cMaHang.Name = "cMaHang";
            this.cMaHang.ReadOnly = true;
            this.cMaHang.Width = 80;
            // 
            // cTenHang
            // 
            this.cTenHang.DataPropertyName = "TenHang";
            this.cTenHang.HeaderText = "Tên Hàng";
            this.cTenHang.Name = "cTenHang";
            this.cTenHang.ReadOnly = true;
            this.cTenHang.Width = 120;
            // 
            // cDVT
            // 
            this.cDVT.DataPropertyName = "DonViTinh";
            this.cDVT.HeaderText = "ĐVT";
            this.cDVT.Name = "cDVT";
            this.cDVT.ReadOnly = true;
            this.cDVT.Width = 40;
            // 
            // cSLGiao
            // 
            this.cSLGiao.DataPropertyName = "SL";
            this.cSLGiao.HeaderText = "SL Giao";
            this.cSLGiao.Name = "cSLGiao";
            this.cSLGiao.ReadOnly = true;
            this.cSLGiao.Width = 50;
            // 
            // cThucNhan
            // 
            this.cThucNhan.DataPropertyName = "ThucNhan";
            this.cThucNhan.HeaderText = "Thực Nhận";
            this.cThucNhan.Name = "cThucNhan";
            this.cThucNhan.ReadOnly = true;
            this.cThucNhan.Width = 50;
            // 
            // cNgayNhap
            // 
            this.cNgayNhap.DataPropertyName = "NgayNhap";
            this.cNgayNhap.HeaderText = "Ngày Nhập";
            this.cNgayNhap.Name = "cNgayNhap";
            this.cNgayNhap.ReadOnly = true;
            // 
            // cHSD
            // 
            this.cHSD.DataPropertyName = "NgayHetHan";
            this.cHSD.HeaderText = "Hạn Sử Dụng";
            this.cHSD.Name = "cHSD";
            this.cHSD.ReadOnly = true;
            // 
            // frmQuanLyWetGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 551);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.bntXuatWG);
            this.Controls.Add(this.bntNhapWG);
            this.Controls.Add(this.dgvKhoWG);
            this.Controls.Add(this.lblNhapWG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyWetGoods";
            this.Text = "Quản lý WetGoods";
            this.Load += new System.EventHandler(this.frmQuanLyWetGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoWG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapWG;
        private System.Windows.Forms.DataGridView dgvKhoWG;
        private System.Windows.Forms.Button bntNhapWG;
        private System.Windows.Forms.Button bntXuatWG;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSLGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThucNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHSD;
    }
}