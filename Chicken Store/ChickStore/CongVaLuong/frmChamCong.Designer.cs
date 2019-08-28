namespace ChickStore.CongVaLuong
{
    partial class frmChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            this.lblChamCong = new System.Windows.Forms.Label();
            this.dgvBangChamCong = new System.Windows.Forms.DataGridView();
            this.dgvTongGioCong = new System.Windows.Forms.DataGridView();
            this.bntClose = new System.Windows.Forms.Button();
            this.lblThangChamCong = new System.Windows.Forms.Label();
            this.cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThangLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiLam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cSTT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNgayDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongGioCong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChamCong
            // 
            this.lblChamCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChamCong.AutoSize = true;
            this.lblChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChamCong.ForeColor = System.Drawing.Color.Blue;
            this.lblChamCong.Location = new System.Drawing.Point(180, 11);
            this.lblChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChamCong.Name = "lblChamCong";
            this.lblChamCong.Size = new System.Drawing.Size(349, 39);
            this.lblChamCong.TabIndex = 0;
            this.lblChamCong.Text = "BẢNG CHẤM CÔNG";
            this.lblChamCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvBangChamCong
            // 
            this.dgvBangChamCong.AllowUserToOrderColumns = true;
            this.dgvBangChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT,
            this.MSNV,
            this.HoTenNV,
            this.NgayThangLamViec,
            this.DiLam});
            this.dgvBangChamCong.Location = new System.Drawing.Point(16, 59);
            this.dgvBangChamCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBangChamCong.Name = "dgvBangChamCong";
            this.dgvBangChamCong.Size = new System.Drawing.Size(484, 435);
            this.dgvBangChamCong.TabIndex = 1;
            // 
            // dgvTongGioCong
            // 
            this.dgvTongGioCong.AllowUserToAddRows = false;
            this.dgvTongGioCong.AllowUserToDeleteRows = false;
            this.dgvTongGioCong.AllowUserToOrderColumns = true;
            this.dgvTongGioCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTongGioCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongGioCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSTT2,
            this.cMSNV2,
            this.cTenNV2,
            this.TongNgayDiLam});
            this.dgvTongGioCong.Location = new System.Drawing.Point(501, 59);
            this.dgvTongGioCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTongGioCong.Name = "dgvTongGioCong";
            this.dgvTongGioCong.ReadOnly = true;
            this.dgvTongGioCong.Size = new System.Drawing.Size(468, 435);
            this.dgvTongGioCong.TabIndex = 2;
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.Location = new System.Drawing.Point(869, 502);
            this.bntClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(100, 28);
            this.bntClose.TabIndex = 4;
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
            this.lblThangChamCong.Location = new System.Drawing.Point(555, 11);
            this.lblThangChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThangChamCong.Name = "lblThangChamCong";
            this.lblThangChamCong.Size = new System.Drawing.Size(39, 39);
            this.lblThangChamCong.TabIndex = 5;
            this.lblThangChamCong.Text = "T";
            this.lblThangChamCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.MSNV.Width = 70;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Tên Nhân Viên";
            this.HoTenNV.MaxInputLength = 100;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            // 
            // NgayThangLamViec
            // 
            this.NgayThangLamViec.DataPropertyName = "NgayThangLamViec";
            this.NgayThangLamViec.HeaderText = "Ngày Làm Việc";
            this.NgayThangLamViec.Name = "NgayThangLamViec";
            this.NgayThangLamViec.Width = 50;
            // 
            // DiLam
            // 
            this.DiLam.DataPropertyName = "DiLam";
            this.DiLam.HeaderText = "Đi Làm";
            this.DiLam.Name = "DiLam";
            this.DiLam.ReadOnly = true;
            this.DiLam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DiLam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DiLam.Width = 65;
            // 
            // cSTT2
            // 
            this.cSTT2.DataPropertyName = "STT";
            this.cSTT2.HeaderText = "STT";
            this.cSTT2.Name = "cSTT2";
            this.cSTT2.ReadOnly = true;
            this.cSTT2.Width = 35;
            // 
            // cMSNV2
            // 
            this.cMSNV2.DataPropertyName = "MSNV";
            this.cMSNV2.HeaderText = "MSNV";
            this.cMSNV2.MaxInputLength = 10;
            this.cMSNV2.Name = "cMSNV2";
            this.cMSNV2.ReadOnly = true;
            this.cMSNV2.Width = 50;
            // 
            // cTenNV2
            // 
            this.cTenNV2.DataPropertyName = "HoTenNV";
            this.cTenNV2.HeaderText = "Tên Nhân Viên";
            this.cTenNV2.MaxInputLength = 100;
            this.cTenNV2.Name = "cTenNV2";
            this.cTenNV2.ReadOnly = true;
            this.cTenNV2.Width = 120;
            // 
            // TongNgayDiLam
            // 
            this.TongNgayDiLam.DataPropertyName = "TongNgayDiLam";
            this.TongNgayDiLam.HeaderText = "Số Ngày Đi Làm";
            this.TongNgayDiLam.Name = "TongNgayDiLam";
            this.TongNgayDiLam.ReadOnly = true;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 536);
            this.Controls.Add(this.lblThangChamCong);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.dgvTongGioCong);
            this.Controls.Add(this.dgvBangChamCong);
            this.Controls.Add(this.lblChamCong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongGioCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChamCong;
        private System.Windows.Forms.DataGridView dgvBangChamCong;
        private System.Windows.Forms.DataGridView dgvTongGioCong;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Label lblThangChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThangLamViec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMSNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNgayDiLam;
    }
}