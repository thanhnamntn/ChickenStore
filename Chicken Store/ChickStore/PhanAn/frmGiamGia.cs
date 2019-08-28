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
    public partial class frmGiamGia : Form
    {
        public frmGiamGia()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Điền thông tin đăng nhập của quản lý, sau đó chọn mục giảm giá tương ứng.", "Hướng dẫn giảm giá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Tên truy cập và mật khẩu dành cho Testing:\n\t- Username: ad\n\t- Password: ad", "TESTING HELP");
        }


        private void bntDis10_Click(object sender, EventArgs e)
        {
            GiamGia(10);
        }

        private void bntDis15_Click(object sender, EventArgs e)
        {
            GiamGia(15);
        }

        private void bntDis20_Click(object sender, EventArgs e)
        {
            GiamGia(20);
        }

        /// <summary>
        /// Hàm giảm giá
        /// </summary>
        /// <param name="percent">Phần trăm sẽ giảm (10%, 15%, 20% là phần trăm, khác 3 số này là 0%)</param>

        private void GiamGia(int percent)
        {
            try
            {
                // Kiểm tra phân quyền
                bool kq = DAL.DAL_DangNhap.DangNhapQuanLy(txtIDQL.Text, txtPwdQL.Text);
                if (kq) // Phân quyền thành công
                {
                    if (percent == 10)
                    {
                        Gvar.Discount = 0.1f;
                    }
                    else if (percent == 15)
                    {
                        Gvar.Discount = 0.15f;
                    }
                    else if (percent == 20)
                    {
                        Gvar.Discount = 0.2f;
                    }
                    else
                    {
                        Gvar.Discount = 0;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Phân quyền KHÔNG thành công!\nVui lòng kiểm tra lại.", "Phân quyền không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("KHÔNG thể giảm giá!\nLỗi không xác định ở truy vấn đăng nhập!", "Đăng nhập Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Huỷ bỏ giảm giá
        private void bntDelDis_Click(object sender, EventArgs e)
        {
            Gvar.Discount = 0;
            this.Close();
        }
    }
}
