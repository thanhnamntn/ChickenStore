namespace ChickStore.KhoWetGoods
{
    partial class frmXuatWetGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatWetGoods));
            this.bntClose = new System.Windows.Forms.Button();
            this.bntNhapHang = new System.Windows.Forms.Button();
            this.grpNhapHang = new System.Windows.Forms.GroupBox();
            this.lblKhoCon = new System.Windows.Forms.Label();
            this.txtKhoCon = new System.Windows.Forms.TextBox();
            this.txtHSD = new System.Windows.Forms.TextBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.numSLXuat = new System.Windows.Forms.NumericUpDown();
            this.lblHSD = new System.Windows.Forms.Label();
            this.lblSLG = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblTenHangNhap = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.lblMaHangNhap = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.bntChonHang = new System.Windows.Forms.Button();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblXuatWG = new System.Windows.Forms.Label();
            this.grpNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLXuat)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.Location = new System.Drawing.Point(920, 517);
            this.bntClose.Margin = new System.Windows.Forms.Padding(6);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(150, 44);
            this.bntClose.TabIndex = 14;
            this.bntClose.Text = "Đóng";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // bntNhapHang
            // 
            this.bntNhapHang.Location = new System.Drawing.Point(874, 44);
            this.bntNhapHang.Margin = new System.Windows.Forms.Padding(6);
            this.bntNhapHang.Name = "bntNhapHang";
            this.bntNhapHang.Size = new System.Drawing.Size(150, 179);
            this.bntNhapHang.TabIndex = 106;
            this.bntNhapHang.Text = "Xuất hàng";
            this.bntNhapHang.UseVisualStyleBackColor = true;
            this.bntNhapHang.Click += new System.EventHandler(this.bntNhapHang_Click);
            // 
            // grpNhapHang
            // 
            this.grpNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNhapHang.Controls.Add(this.lblKhoCon);
            this.grpNhapHang.Controls.Add(this.txtKhoCon);
            this.grpNhapHang.Controls.Add(this.txtHSD);
            this.grpNhapHang.Controls.Add(this.dtpNgayXuat);
            this.grpNhapHang.Controls.Add(this.bntNhapHang);
            this.grpNhapHang.Controls.Add(this.numSLXuat);
            this.grpNhapHang.Controls.Add(this.lblHSD);
            this.grpNhapHang.Controls.Add(this.lblSLG);
            this.grpNhapHang.Controls.Add(this.lblNgayNhap);
            this.grpNhapHang.Controls.Add(this.txtTenHang);
            this.grpNhapHang.Controls.Add(this.lblTenHangNhap);
            this.grpNhapHang.Controls.Add(this.txtMaHang);
            this.grpNhapHang.Controls.Add(this.lblMaHangNhap);
            this.grpNhapHang.Location = new System.Drawing.Point(24, 242);
            this.grpNhapHang.Margin = new System.Windows.Forms.Padding(6);
            this.grpNhapHang.Name = "grpNhapHang";
            this.grpNhapHang.Padding = new System.Windows.Forms.Padding(6);
            this.grpNhapHang.Size = new System.Drawing.Size(1046, 256);
            this.grpNhapHang.TabIndex = 13;
            this.grpNhapHang.TabStop = false;
            this.grpNhapHang.Text = "Thông tin xuất kho";
            // 
            // lblKhoCon
            // 
            this.lblKhoCon.AutoSize = true;
            this.lblKhoCon.Location = new System.Drawing.Point(32, 188);
            this.lblKhoCon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKhoCon.Name = "lblKhoCon";
            this.lblKhoCon.Size = new System.Drawing.Size(97, 25);
            this.lblKhoCon.TabIndex = 107;
            this.lblKhoCon.Text = "Kho còn:";
            // 
            // txtKhoCon
            // 
            this.txtKhoCon.Location = new System.Drawing.Point(144, 183);
            this.txtKhoCon.Margin = new System.Windows.Forms.Padding(6);
            this.txtKhoCon.MaxLength = 255;
            this.txtKhoCon.Name = "txtKhoCon";
            this.txtKhoCon.ReadOnly = true;
            this.txtKhoCon.Size = new System.Drawing.Size(260, 31);
            this.txtKhoCon.TabIndex = 104;
            this.txtKhoCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHSD
            // 
            this.txtHSD.Location = new System.Drawing.Point(598, 115);
            this.txtHSD.Margin = new System.Windows.Forms.Padding(6);
            this.txtHSD.MaxLength = 255;
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.ReadOnly = true;
            this.txtHSD.Size = new System.Drawing.Size(260, 31);
            this.txtHSD.TabIndex = 103;
            this.txtHSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CustomFormat = "";
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuat.Location = new System.Drawing.Point(144, 117);
            this.dtpNgayXuat.Margin = new System.Windows.Forms.Padding(6);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(260, 31);
            this.dtpNgayXuat.TabIndex = 102;
            // 
            // numSLXuat
            // 
            this.numSLXuat.Location = new System.Drawing.Point(598, 185);
            this.numSLXuat.Margin = new System.Windows.Forms.Padding(6);
            this.numSLXuat.Name = "numSLXuat";
            this.numSLXuat.Size = new System.Drawing.Size(264, 31);
            this.numSLXuat.TabIndex = 105;
            this.numSLXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHSD
            // 
            this.lblHSD.AutoSize = true;
            this.lblHSD.Location = new System.Drawing.Point(490, 123);
            this.lblHSD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHSD.Name = "lblHSD";
            this.lblHSD.Size = new System.Drawing.Size(92, 25);
            this.lblHSD.TabIndex = 10;
            this.lblHSD.Text = "Hạn SD:";
            // 
            // lblSLG
            // 
            this.lblSLG.AutoSize = true;
            this.lblSLG.Location = new System.Drawing.Point(498, 188);
            this.lblSLG.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSLG.Name = "lblSLG";
            this.lblSLG.Size = new System.Drawing.Size(91, 25);
            this.lblSLG.TabIndex = 6;
            this.lblSLG.Text = "SL xuất:";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(12, 121);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(115, 25);
            this.lblNgayNhap.TabIndex = 4;
            this.lblNgayNhap.Text = "Ngày xuất:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(598, 48);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenHang.MaxLength = 255;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(260, 31);
            this.txtTenHang.TabIndex = 3;
            this.txtTenHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTenHangNhap
            // 
            this.lblTenHangNhap.AutoSize = true;
            this.lblTenHangNhap.Location = new System.Drawing.Point(474, 54);
            this.lblTenHangNhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTenHangNhap.Name = "lblTenHangNhap";
            this.lblTenHangNhap.Size = new System.Drawing.Size(109, 25);
            this.lblTenHangNhap.TabIndex = 2;
            this.lblTenHangNhap.Text = "Tên hàng:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(144, 48);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaHang.MaxLength = 10;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(260, 31);
            this.txtMaHang.TabIndex = 1;
            this.txtMaHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaHangNhap
            // 
            this.lblMaHangNhap.AutoSize = true;
            this.lblMaHangNhap.Location = new System.Drawing.Point(32, 54);
            this.lblMaHangNhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaHangNhap.Name = "lblMaHangNhap";
            this.lblMaHangNhap.Size = new System.Drawing.Size(102, 25);
            this.lblMaHangNhap.TabIndex = 0;
            this.lblMaHangNhap.Text = "Mã hàng:";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.lblMaHang);
            this.grpThongTin.Controls.Add(this.bntChonHang);
            this.grpThongTin.Controls.Add(this.cboMaHang);
            this.grpThongTin.Controls.Add(this.cboTenHang);
            this.grpThongTin.Controls.Add(this.lblTenHang);
            this.grpThongTin.Location = new System.Drawing.Point(24, 90);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(6);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(6);
            this.grpThongTin.Size = new System.Drawing.Size(1046, 140);
            this.grpThongTin.TabIndex = 12;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin hàng hoá";
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Location = new System.Drawing.Point(32, 63);
            this.lblMaHang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(102, 25);
            this.lblMaHang.TabIndex = 3;
            this.lblMaHang.Text = "Mã hàng:";
            // 
            // bntChonHang
            // 
            this.bntChonHang.Location = new System.Drawing.Point(874, 60);
            this.bntChonHang.Margin = new System.Windows.Forms.Padding(6);
            this.bntChonHang.Name = "bntChonHang";
            this.bntChonHang.Size = new System.Drawing.Size(150, 44);
            this.bntChonHang.TabIndex = 102;
            this.bntChonHang.Text = "Chọn";
            this.bntChonHang.UseVisualStyleBackColor = true;
            this.bntChonHang.Click += new System.EventHandler(this.bntChonHang_Click);
            // 
            // cboMaHang
            // 
            this.cboMaHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Items.AddRange(new object[] {
            "01. CO_CANHGA",
            "02. CO_DUIGO4",
            "03. CO_9MIENG",
            "04. CO_PHILE0",
            "05. CO_PHILE1",
            "06. CO_GAVIEN",
            "07. CO_GXUONG",
            "08. SU_KHOAIT",
            "09. SU_BANHTA",
            "10. SU_BANHMO",
            "11. SU_BUGTOM",
            "12. SU_BUGOCN",
            "13. SU_CATHAN",
            "14. SU_BANHTR",
            "15. SU_KEMSUA",
            "16. SU_PHOMAI",
            "17. SU_LOLOXA",
            "18. SU_CACHUA",
            "19. SU_DUALEO",
            "20. SU_CARROT",
            "21. SU_KHOAIC",
            "22. SU_BCAITR",
            "23. SU_HANHLA",
            "24. SU_SALADM",
            "25. SU_CAITHI",
            "26. SU_GUNGNO",
            "27. SU_TDAUCO",
            "28. CS_PEPSIT",
            "29. CS_PEPSIL",
            "30. CS_BANHKE",
            "31. CS_SOCOLA",
            "32. CS_BOTKEM",
            "33. CS_KRSRVQ",
            "34. CS_KRSRCN",
            "35. CS_KRSRKW"});
            this.cboMaHang.Location = new System.Drawing.Point(144, 58);
            this.cboMaHang.Margin = new System.Windows.Forms.Padding(6);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(260, 33);
            this.cboMaHang.TabIndex = 100;
            this.cboMaHang.SelectedIndexChanged += new System.EventHandler(this.cboMaHang_SelectedIndexChanged);
            // 
            // cboTenHang
            // 
            this.cboTenHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Items.AddRange(new object[] {
            "01. Cánh gà đông lạnh",
            "02. Đùi gà góc tư",
            "03. Gà 9 miếng",
            "04. Gà phi-lê không da",
            "05. Gà phi-lê có da",
            "06. Gà viên",
            "07. Xương gà",
            "08. Khoai tây chiên",
            "09. Bánh pie táo",
            "10. Bánh pie môn",
            "11. Miếng Burger tôm",
            "12. Miếng Burger hải sản",
            "13. Cá thanh",
            "14. Vỏ bánh trứng",
            "15. Kem sữa",
            "16. Phô mai lát",
            "17. Lolo xanh",
            "18. Cà chua",
            "19. Dưa leo",
            "20. Cà rốt",
            "21. Khoai tây củ",
            "22. Bắp cải trộn",
            "23. Hành lá",
            "24. Salad Mỹ",
            "25. Cải thìa",
            "26. Gừng non",
            "27. Dầu cọ",
            "28. Pepsi tươi",
            "29. Pepsi lon",
            "30. Ống bánh kem",
            "31. Socola lỏng",
            "32. Bột kem",
            "33. Kruser Việt quất",
            "34. Kruser Cam nha đam",
            "35. Kruser Kiwi"});
            this.cboTenHang.Location = new System.Drawing.Point(598, 60);
            this.cboTenHang.Margin = new System.Windows.Forms.Padding(6);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(260, 33);
            this.cboTenHang.TabIndex = 101;
            this.cboTenHang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(420, 65);
            this.lblTenHang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(162, 25);
            this.lblTenHang.TabIndex = 5;
            this.lblTenHang.Text = "hoặc Tên hàng:";
            // 
            // lblXuatWG
            // 
            this.lblXuatWG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblXuatWG.AutoSize = true;
            this.lblXuatWG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXuatWG.ForeColor = System.Drawing.Color.Blue;
            this.lblXuatWG.Location = new System.Drawing.Point(162, 17);
            this.lblXuatWG.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblXuatWG.Name = "lblXuatWG";
            this.lblXuatWG.Size = new System.Drawing.Size(777, 63);
            this.lblXuatWG.TabIndex = 11;
            this.lblXuatWG.Text = "QUẢN LÝ XUẤT WETGOODS";
            this.lblXuatWG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmXuatWetGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 577);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.grpNhapHang);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblXuatWG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmXuatWetGoods";
            this.Text = "Quản ký xuất WetGoods";
            this.Load += new System.EventHandler(this.frmXuatWetGoods_Load);
            this.grpNhapHang.ResumeLayout(false);
            this.grpNhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLXuat)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Button bntNhapHang;
        private System.Windows.Forms.GroupBox grpNhapHang;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.NumericUpDown numSLXuat;
        private System.Windows.Forms.Label lblHSD;
        private System.Windows.Forms.Label lblSLG;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblTenHangNhap;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lblMaHangNhap;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Button bntChonHang;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblXuatWG;
        private System.Windows.Forms.TextBox txtHSD;
        private System.Windows.Forms.Label lblKhoCon;
        private System.Windows.Forms.TextBox txtKhoCon;
    }
}