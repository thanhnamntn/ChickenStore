namespace ChickStore.DoanhThu
{
    partial class frmQuanLyThuChiCuoiCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyThuChiCuoiCa));
            this.lblChamCong = new System.Windows.Forms.Label();
            this.lblNgayText = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dgvBangThuChiCuoiCa = new System.Windows.Forms.DataGridView();
            this.cCaPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienVay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntClose = new System.Windows.Forms.Button();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangThuChiCuoiCa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChamCong
            // 
            this.lblChamCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChamCong.AutoSize = true;
            this.lblChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChamCong.ForeColor = System.Drawing.Color.Blue;
            this.lblChamCong.Location = new System.Drawing.Point(133, 11);
            this.lblChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChamCong.Name = "lblChamCong";
            this.lblChamCong.Size = new System.Drawing.Size(490, 39);
            this.lblChamCong.TabIndex = 1;
            this.lblChamCong.Text = "QUẢN LÝ THU/CHI CUỐI CA";
            this.lblChamCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNgayText
            // 
            this.lblNgayText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayText.AutoSize = true;
            this.lblNgayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgayText.Location = new System.Drawing.Point(255, 49);
            this.lblNgayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayText.Name = "lblNgayText";
            this.lblNgayText.Size = new System.Drawing.Size(62, 25);
            this.lblNgayText.TabIndex = 2;
            this.lblNgayText.Text = "Ngày";
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgay.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgay.Location = new System.Drawing.Point(370, 49);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(0, 25);
            this.lblNgay.TabIndex = 3;
            // 
            // dgvBangThuChiCuoiCa
            // 
            this.dgvBangThuChiCuoiCa.AllowUserToOrderColumns = true;
            this.dgvBangThuChiCuoiCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangThuChiCuoiCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCaPOS,
            this.cMSNV,
            this.cTenNV,
            this.cTienVay,
            this.cDoanhThu});
            this.dgvBangThuChiCuoiCa.Location = new System.Drawing.Point(39, 77);
            this.dgvBangThuChiCuoiCa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangThuChiCuoiCa.Name = "dgvBangThuChiCuoiCa";
            this.dgvBangThuChiCuoiCa.Size = new System.Drawing.Size(713, 349);
            this.dgvBangThuChiCuoiCa.TabIndex = 4;
            // 
            // cCaPOS
            // 
            this.cCaPOS.DataPropertyName = "CaPos";
            this.cCaPOS.HeaderText = "Ca/POS";
            this.cCaPOS.MaxInputLength = 3;
            this.cCaPOS.Name = "cCaPOS";
            this.cCaPOS.ReadOnly = true;
            this.cCaPOS.Width = 70;
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
            // cTienVay
            // 
            this.cTienVay.DataPropertyName = "TienVay";
            this.cTienVay.HeaderText = "Tiền Vay";
            this.cTienVay.Name = "cTienVay";
            // 
            // cDoanhThu
            // 
            this.cDoanhThu.DataPropertyName = "DoanhThu";
            this.cDoanhThu.HeaderText = "DoanhThu";
            this.cDoanhThu.Name = "cDoanhThu";
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.Location = new System.Drawing.Point(678, 435);
            this.bntClose.Margin = new System.Windows.Forms.Padding(4);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(100, 28);
            this.bntClose.TabIndex = 5;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(325, 52);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(175, 22);
            this.dtpNgayNhap.TabIndex = 103;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // frmQuanLyThuChiCuoiCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 477);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.dgvBangThuChiCuoiCa);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblNgayText);
            this.Controls.Add(this.lblChamCong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyThuChiCuoiCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thu/chi cuối ca";
            this.Load += new System.EventHandler(this.frmQuanLyThuChiCuoiCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangThuChiCuoiCa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChamCong;
        private System.Windows.Forms.Label lblNgayText;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DataGridView dgvBangThuChiCuoiCa;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCaPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienVay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
    }
}