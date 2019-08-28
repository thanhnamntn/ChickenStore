using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickStore.PhanAn
{
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
            // Định dạng và hiển thị số tiền khách phải trả
            lblCash.Text = "Tổng số tiền phải trả: " + Gvar.TongTienPhaiTra.ToString("### ### ### VND");
        }

        // Hàm kiểm tra số tiền thanh toán
        private void KiemTraThanhToan()
        {
            // Kiểm tra số tiền nhập vào hoặc được chọn có đủ hay không
            if (float.Parse(Gvar.SoTienKhachTra.ToString()) < float.Parse(Gvar.TongTienPhaiTra.ToString()))
            {
                MessageBox.Show("Số tiền nhập vào không đủ!\nVui lòng kiểm tra lại!", "Thanh toán không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thanh toán thành công!\nSố tiền trả lại là: " + (float.Parse(Gvar.SoTienKhachTra.ToString()) - float.Parse(Gvar.TongTienPhaiTra.ToString())).ToString("### ### ###"), "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Gvar.DaTinhTien = true;
            }
        }

        private void bntThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                Gvar.SoTienKhachTra = float.Parse(txtKhachTra.Text.Replace(" ", ""));
                KiemTraThanhToan();
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào đúng!\nVui lòng kiểm tra lại!", "Thanh toán không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnt20k_Click(object sender, EventArgs e)
        {
            Gvar.SoTienKhachTra = 20000;
            KiemTraThanhToan();
        }

        private void bnt50k_Click(object sender, EventArgs e)
        {
            Gvar.SoTienKhachTra = 50000;
            KiemTraThanhToan();
        }

        private void bnt100k_Click(object sender, EventArgs e)
        {
            Gvar.SoTienKhachTra = 100000;
            KiemTraThanhToan();
        }

        private void bnt200k_Click(object sender, EventArgs e)
        {
            Gvar.SoTienKhachTra = 200000;
            KiemTraThanhToan();
        }

        private void bnt500k_Click(object sender, EventArgs e)
        {
            Gvar.SoTienKhachTra = 500000;
            KiemTraThanhToan();
        }

        private void frmTinhTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Huỷ tính tiền, tiếp tục đặt phần ăn
            Gvar.DaTinhTien = false;
        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {
            // Huỷ tính tiền, tiếp tục đặt phần ăn
            Gvar.DaTinhTien = false;
            this.Close();
        }
    }
}
