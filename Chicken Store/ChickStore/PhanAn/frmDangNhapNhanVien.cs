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
    public partial class frmDangNhapNhanVien : Form
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

        public frmDangNhapNhanVien()
        {
            // Chạy Timer đồng hồ
            StartTimer();
            // Khởi tạo giá trị Loading Percent ban đầu
            Gvar.LoadPercent = 0;
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNV = DAL.DAL_DangNhap.DangNhap(txtIDNV.Text, txtPwd.Text);
                if (tenNV != "")
                {
                    // Khởi tạo giá trị mặc định ban đầu
                    Gvar.TenNvDungCa = tenNV;
                    Gvar.TienVay = 1000000;
                    Gvar.DoanhThu = 0;
                    Gvar.MaNvDungCa = txtIDNV.Text;
                    // Đóng form đăng nhập, chuyển qua giao diện chính
                    this.Hide();
                    var frm = new PhanAn.frmTiepNhanPhanAn();
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

        private void bntHelp1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên truy cập và mật khẩu dành cho Testing:\n\t- Username: 1\n\t- Password: 1", "TESTING HELP");
        }

    }
}
