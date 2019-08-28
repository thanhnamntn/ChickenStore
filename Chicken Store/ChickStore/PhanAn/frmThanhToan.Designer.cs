namespace ChickStore.PhanAn
{
    partial class frmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.grpFastActive = new System.Windows.Forms.GroupBox();
            this.bnt500k = new System.Windows.Forms.Button();
            this.bnt200k = new System.Windows.Forms.Button();
            this.bnt100k = new System.Windows.Forms.Button();
            this.bnt50k = new System.Windows.Forms.Button();
            this.bnt20k = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Label();
            this.bntQuayLai = new System.Windows.Forms.Button();
            this.bntThanhToan = new System.Windows.Forms.Button();
            this.txtKhachTra = new System.Windows.Forms.TextBox();
            this.lblNhapTien = new System.Windows.Forms.Label();
            this.grpFastActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFastActive
            // 
            this.grpFastActive.Controls.Add(this.bnt500k);
            this.grpFastActive.Controls.Add(this.bnt200k);
            this.grpFastActive.Controls.Add(this.bnt100k);
            this.grpFastActive.Controls.Add(this.bnt50k);
            this.grpFastActive.Controls.Add(this.bnt20k);
            this.grpFastActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpFastActive.Location = new System.Drawing.Point(13, 84);
            this.grpFastActive.Name = "grpFastActive";
            this.grpFastActive.Size = new System.Drawing.Size(412, 104);
            this.grpFastActive.TabIndex = 104;
            this.grpFastActive.TabStop = false;
            this.grpFastActive.Text = "Thao tác nhanh";
            // 
            // bnt500k
            // 
            this.bnt500k.Location = new System.Drawing.Point(329, 21);
            this.bnt500k.Name = "bnt500k";
            this.bnt500k.Size = new System.Drawing.Size(75, 68);
            this.bnt500k.TabIndex = 4;
            this.bnt500k.Text = "500.000";
            this.bnt500k.UseVisualStyleBackColor = true;
            this.bnt500k.Click += new System.EventHandler(this.bnt500k_Click);
            // 
            // bnt200k
            // 
            this.bnt200k.Location = new System.Drawing.Point(249, 21);
            this.bnt200k.Name = "bnt200k";
            this.bnt200k.Size = new System.Drawing.Size(75, 68);
            this.bnt200k.TabIndex = 3;
            this.bnt200k.Text = "200.000";
            this.bnt200k.UseVisualStyleBackColor = true;
            this.bnt200k.Click += new System.EventHandler(this.bnt200k_Click);
            // 
            // bnt100k
            // 
            this.bnt100k.Location = new System.Drawing.Point(168, 21);
            this.bnt100k.Name = "bnt100k";
            this.bnt100k.Size = new System.Drawing.Size(75, 68);
            this.bnt100k.TabIndex = 2;
            this.bnt100k.Text = "100.000";
            this.bnt100k.UseVisualStyleBackColor = true;
            this.bnt100k.Click += new System.EventHandler(this.bnt100k_Click);
            // 
            // bnt50k
            // 
            this.bnt50k.Location = new System.Drawing.Point(87, 21);
            this.bnt50k.Name = "bnt50k";
            this.bnt50k.Size = new System.Drawing.Size(75, 68);
            this.bnt50k.TabIndex = 1;
            this.bnt50k.Text = "50.000";
            this.bnt50k.UseVisualStyleBackColor = true;
            this.bnt50k.Click += new System.EventHandler(this.bnt50k_Click);
            // 
            // bnt20k
            // 
            this.bnt20k.Location = new System.Drawing.Point(6, 21);
            this.bnt20k.Name = "bnt20k";
            this.bnt20k.Size = new System.Drawing.Size(75, 68);
            this.bnt20k.TabIndex = 0;
            this.bnt20k.Text = "20.000";
            this.bnt20k.UseVisualStyleBackColor = true;
            this.bnt20k.Click += new System.EventHandler(this.bnt20k_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCash.ForeColor = System.Drawing.Color.Green;
            this.lblCash.Location = new System.Drawing.Point(13, 15);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(244, 25);
            this.lblCash.TabIndex = 105;
            this.lblCash.Text = "Tổng số tiền phải trả: ";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntQuayLai
            // 
            this.bntQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntQuayLai.ForeColor = System.Drawing.Color.Green;
            this.bntQuayLai.Location = new System.Drawing.Point(13, 194);
            this.bntQuayLai.Name = "bntQuayLai";
            this.bntQuayLai.Size = new System.Drawing.Size(412, 41);
            this.bntQuayLai.TabIndex = 106;
            this.bntQuayLai.Text = "Quay lại đặt phần ăn";
            this.bntQuayLai.UseVisualStyleBackColor = true;
            this.bntQuayLai.Click += new System.EventHandler(this.bntQuayLai_Click);
            // 
            // bntThanhToan
            // 
            this.bntThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntThanhToan.Location = new System.Drawing.Point(321, 56);
            this.bntThanhToan.Name = "bntThanhToan";
            this.bntThanhToan.Size = new System.Drawing.Size(86, 22);
            this.bntThanhToan.TabIndex = 102;
            this.bntThanhToan.Text = "Thanh toán";
            this.bntThanhToan.UseVisualStyleBackColor = true;
            this.bntThanhToan.Click += new System.EventHandler(this.bntThanhToan_Click);
            // 
            // txtKhachTra
            // 
            this.txtKhachTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKhachTra.Location = new System.Drawing.Point(155, 56);
            this.txtKhachTra.Name = "txtKhachTra";
            this.txtKhachTra.Size = new System.Drawing.Size(160, 22);
            this.txtKhachTra.TabIndex = 101;
            // 
            // lblNhapTien
            // 
            this.lblNhapTien.AutoSize = true;
            this.lblNhapTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapTien.Location = new System.Drawing.Point(32, 59);
            this.lblNhapTien.Name = "lblNhapTien";
            this.lblNhapTien.Size = new System.Drawing.Size(117, 16);
            this.lblNhapTien.TabIndex = 103;
            this.lblNhapTien.Text = "Số tiền khách đưa:";
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 251);
            this.Controls.Add(this.grpFastActive);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.bntQuayLai);
            this.Controls.Add(this.bntThanhToan);
            this.Controls.Add(this.txtKhachTra);
            this.Controls.Add(this.lblNhapTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán và in hoá đơn";
            this.grpFastActive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFastActive;
        private System.Windows.Forms.Button bnt500k;
        private System.Windows.Forms.Button bnt200k;
        private System.Windows.Forms.Button bnt100k;
        private System.Windows.Forms.Button bnt50k;
        private System.Windows.Forms.Button bnt20k;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Button bntQuayLai;
        private System.Windows.Forms.Button bntThanhToan;
        private System.Windows.Forms.TextBox txtKhachTra;
        private System.Windows.Forms.Label lblNhapTien;
    }
}