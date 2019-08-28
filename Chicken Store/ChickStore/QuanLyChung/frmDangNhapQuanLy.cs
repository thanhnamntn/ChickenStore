using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickStore.QuanLyChung
{
    public partial class frmDangNhapQuanLy : Form
    {
        // Timer phục vụ hiển thị đồng hồ trong phần mềm
        Timer t = null;
        void t_Tick(object sender, EventArgs e)
        {
            sttTime.Text = DateTime.Now.ToString("dd/MM/yyyy - H:mm:ss");
        }
        private void StartTimer()
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        public frmDangNhapQuanLy()
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Đăng nhập quản lý
                bool kq = DAL.DAL_DangNhap.DangNhapQuanLy(txtIDQL.Text, txtPwdQL.Text);
                if (kq) // Đăng nhập thành công
                {
                    // Đóng form đăng nhập QL, chuyển qua giao diện Quản lý
                    this.Hide();
                    var frm = new QuanLyChung.frmTrungTamQuanLy();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập KHÔNG thành công!\nVui lòng kiểm tra lại.", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("KHÔNG thể đăng nhập!\nLỗi không xác định!", "Đăng nhập Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
