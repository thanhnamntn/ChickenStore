namespace ChickStore.DoanhThu
{
    partial class frmQuanLyThuChiCuoiThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyThuChiCuoiThang));
            this.dgvBangThuChiCuoiThang = new System.Windows.Forms.DataGridView();
            this.lblNgayText = new System.Windows.Forms.Label();
            this.lblChamCong = new System.Windows.Forms.Label();
            this.bntClose = new System.Windows.Forms.Button();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangThuChiCuoiThang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBangThuChiCuoiThang
            // 
            this.dgvBangThuChiCuoiThang.AllowUserToOrderColumns = true;
            this.dgvBangThuChiCuoiThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangThuChiCuoiThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangThuChiCuoiThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNgay,
            this.cDoanhThu});
            this.dgvBangThuChiCuoiThang.Location = new System.Drawing.Point(24, 69);
            this.dgvBangThuChiCuoiThang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangThuChiCuoiThang.Name = "dgvBangThuChiCuoiThang";
            this.dgvBangThuChiCuoiThang.Size = new System.Drawing.Size(817, 391);
            this.dgvBangThuChiCuoiThang.TabIndex = 9;
            // 
            // lblNgayText
            // 
            this.lblNgayText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayText.AutoSize = true;
            this.lblNgayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgayText.Location = new System.Drawing.Point(497, 42);
            this.lblNgayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayText.Name = "lblNgayText";
            this.lblNgayText.Size = new System.Drawing.Size(74, 25);
            this.lblNgayText.TabIndex = 7;
            this.lblNgayText.Text = "Tháng";
            // 
            // lblChamCong
            // 
            this.lblChamCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChamCong.AutoSize = true;
            this.lblChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChamCong.ForeColor = System.Drawing.Color.Blue;
            this.lblChamCong.Location = new System.Drawing.Point(128, 2);
            this.lblChamCong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChamCong.Name = "lblChamCong";
            this.lblChamCong.Size = new System.Drawing.Size(565, 39);
            this.lblChamCong.TabIndex = 6;
            this.lblChamCong.Text = "QUẢN LÝ THU/CHI CUỐI THÁNG";
            this.lblChamCong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.Location = new System.Drawing.Point(741, 473);
            this.bntClose.Margin = new System.Windows.Forms.Padding(4);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(100, 28);
            this.bntClose.TabIndex = 10;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(598, 42);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(72, 24);
            this.cboThang.TabIndex = 14;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.cboNam.Location = new System.Drawing.Point(401, 42);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(72, 24);
            this.cboNam.TabIndex = 15;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // cNgay
            // 
            this.cNgay.DataPropertyName = "NgayLap";
            this.cNgay.HeaderText = "Ngày";
            this.cNgay.Name = "cNgay";
            this.cNgay.ReadOnly = true;
            this.cNgay.Width = 250;
            // 
            // cDoanhThu
            // 
            this.cDoanhThu.DataPropertyName = "TongDoanhThu";
            this.cDoanhThu.HeaderText = "Doanh thu";
            this.cDoanhThu.Name = "cDoanhThu";
            this.cDoanhThu.ReadOnly = true;
            this.cDoanhThu.Width = 250;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(44, 469);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(206, 29);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "Tổng Doanh Thu :";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(256, 469);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(0, 29);
            this.lblTongDoanhThu.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(297, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Năm";
            // 
            // frmQuanLyThuChiCuoiThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.dgvBangThuChiCuoiThang);
            this.Controls.Add(this.lblNgayText);
            this.Controls.Add(this.lblChamCong);
            this.Controls.Add(this.bntClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyThuChiCuoiThang";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangThuChiCuoiThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangThuChiCuoiThang;
        private System.Windows.Forms.Label lblNgayText;
        private System.Windows.Forms.Label lblChamCong;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDoanhThu;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label label1;
    }
}