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
    public partial class frmTiepNhanPhanAn : Form
    {
        // Tạo "DataTable Hoá đơn"
        DataTable tbOrder = new DataTable();
        // Timer phục vụ hiển thị đồng hồ trong phần mềm
        Timer t = null;
        bool fomatedOrderCell = false;
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

        public frmTiepNhanPhanAn()
        {
            // Chạy Timer đồng hồ
            StartTimer();
            // Thêm cột cho "DataTable Hoá đơn"
            tbOrder.Columns.Add(Gvar.cFoodName, typeof(string));
            tbOrder.Columns.Add(Gvar.cCount, typeof(Int32));
            tbOrder.Columns.Add(Gvar.cCost, typeof(float));
            //
            InitializeComponent();
            // Load dữ liệu về Nhóm Sản phẩm và Tên Sản Phẩm từ CSDL lên giao diện
            LoadFoodGroup();
            LoadFoodsName();
            // Làm rỗng "DataTable Hoá đơn"
            tbOrder.Clear();
            // Mã Hoá đơn mặc định ban đầu
            txtMaHD.Text = "1";
            // Biến Bool dùng cho sự kiện "Huỷ Tính Tiền" (Trở về tiếp tục đặt phần ăn)
            Gvar.DaTinhTien = false;
            // Biến số "Loại phục vụ", chi tiết xem thêm trong Gvar.cs - Line 52
            Gvar.LoaiPhucVu = 0;
            // Hiển thị tên NV đang đăng nhập, Loại phục vụ
            txtSignedInID.Text = Gvar.TenNvDungCa;
            sttType.Text = Gvar.AnODauString(Gvar.LoaiPhucVu);
            // Hiển thị các giá trị mặc định khác
            txtDiscount.Text = "";
            txtCash.Text = "";
            txtTotalCash.Text = "";
            Gvar.SoHDHientai = DAL.DAL_PhanAn.SoHDHienTai();
            txtMaHD.Text = Gvar.SoHDHientai.ToString();
        }
        /// <summary>
        /// Hàm định dạng Cột trong "DataGirdView Hoá đơn"
        /// </summary>
        private void FormatOrderCell()
        {
            fomatedOrderCell = true;
            dgvOrder.Columns[0].HeaderText = "Tên sản phẩm";
            dgvOrder.Columns[0].Width = 130;
            //
            dgvOrder.Columns[1].Width = 25;
            dgvOrder.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            dgvOrder.Columns[2].HeaderText = "Giá";
            dgvOrder.Columns[2].Width = 77;
            dgvOrder.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrder.Columns[2].DefaultCellStyle.Format = "### ### ###";
        }

        /// <summary>
        /// Hàm thêm sản phẩm dựa vào Name của Button, đồng thời cũng là mã sản phẩm
        /// </summary>
        /// <param name="bntName">Tên button</param>
        private void ThemSanPham(string bntName)
        {
            // Tìm Button thông qua Name
            var arr = this.Controls.Find(bntName, true);
            var c = arr.FirstOrDefault();
            //
            int giaSP = DAL.DAL_PhanAn.LayGiaSPTheoTen(bntName);
            int solg = 0;
            // Chuẩn hoá tên sản phẩm
            string food0 = c.Text;
            string food = food0.Substring(0, food0.Length - 6);
            char[] fod = food.ToArray();
            // Tìm số lượng mặc định phải bán của sản phẩm (VD: phải bán 1/3/5 sp mỗi lần bán ra)
            if (fod[0] >= '2' && fod[0] <= '9')
            {
                solg = Int32.Parse(fod[0].ToString());
            }
            else
            {
                solg = 1;
            }
            // Kiểm tra xem đã có sản phẩm này trong "DataGirdView Hoá đơn" chưa
            bool haveFood = this.tbOrder.AsEnumerable().Any(row => food == row.Field<String>(Gvar.cFoodName));
            if (haveFood) // đã có
            {
                DataRow r = tbOrder.Select(Gvar.cFoodName + " = '" + food + "'").FirstOrDefault();
                int t1 = Int32.Parse(r[1].ToString());
                int t2 = Int32.Parse(r[2].ToString());
                r[1] = t1 + solg;
                r[2] = t2 + giaSP;
                float sum = 0;
                for (int i = 0; i < dgvOrder.Rows.Count; i++) //++i
                {
                    sum += float.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString());
                }
                txtCash.Text = sum.ToString("### ### ###");
                txtTotalCash.Text = (sum - (sum * Gvar.Discount)).ToString("### ### ###");
                txtDiscount.Text = (sum * Gvar.Discount).ToString("### ### ###");
            }
            else // chưa có, tạo mới
            {
                DataRow r = tbOrder.NewRow();
                r[Gvar.cFoodName] = food;
                r[Gvar.cCount] = solg;
                r[Gvar.cCost] = giaSP;
                tbOrder.Rows.Add(r);
                float sum;
                if (tbOrder.Rows.Count == 1)
                {
                    sum = giaSP;
                    for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                    {
                        sum += float.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString());
                    }
                }
                else
                {
                    sum = 0;
                    for (int i = 0; i < dgvOrder.Rows.Count; i++)
                    {
                        sum += float.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString());
                    }
                }

                // Định dạng tiền
                txtCash.Text = sum.ToString("### ### ###");
                txtTotalCash.Text = (sum - (sum * Gvar.Discount)).ToString("### ### ###");
                txtDiscount.Text = (sum * Gvar.Discount).ToString("### ### ###");
            }
            // Hiển thị dữ liệu ra "DataGirdView Hoá đơn" và định dạng nếu cần
            dgvOrder.DataSource = tbOrder;
            if (!fomatedOrderCell)
                FormatOrderCell();
        }
        private void bntEatIn_Click(object sender, EventArgs e)
        {
            Gvar.LoaiPhucVu = 0;
            sttType.Text = Gvar.AnODauString(Gvar.LoaiPhucVu);
        }

        private void bntTA_Click(object sender, EventArgs e)
        {
            Gvar.LoaiPhucVu = 1;
            sttType.Text = Gvar.AnODauString(Gvar.LoaiPhucVu);
        }

        private void bntHomeD_Click(object sender, EventArgs e)
        {
            Gvar.LoaiPhucVu = 2;
            sttType.Text = Gvar.AnODauString(Gvar.LoaiPhucVu);
        }

        private void bntSignOut_Click(object sender, EventArgs e)
        {
            try
            {
                // Biến "Giờ ra" lưu thời gian đăng xuất của NV
                //DateTime gioRa = DateTime.Now;
                //int doanhthu = DAL.DAL_PhanAn.LayDuLieuDoanhThu(gioRa.ToString("yyyy-MM-dd"), Gvar.MaNvDungCa);
                // Ghi dữ liệu đăng xuất vào CSDL
                //if (DAL.DAL_PhanAn.GhiDuLieuDangXuat(gioRa.TimeOfDay.ToString(), doanhthu, Gvar.MaNvDungCa))
                //{
                // Trả Mã NV hiện tại về mặc đinh (rỗng)
                Gvar.MaNvDungCa = "";
                // Đóng form chính và hiện form đăng nhập
                this.Hide();
                var frm = new PhanAn.frmDangNhapNhanVien();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Đăng xuất KHÔNG thành công!", "Đăng xuất lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch
            {
                Application.Exit();
            }
        }

        private void bntVoid_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác nhận xoá phần ăn
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xoá phần ăn này?", "Xoá phần ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    // Tìm và xoá phần ăn tại vị trí (hàng) đã chọn
                    int selectedrowindex = dgvOrder.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvOrder.Rows[selectedrowindex];
                    int tienVoid = Convert.ToInt32(selectedRow.Cells[Gvar.cCost].Value);
                    tbOrder.Rows.RemoveAt(dgvOrder.CurrentCell.RowIndex);

                    //if (!DAL.DAL_Main.GhiDuLieuVoid(Gvar.MaNvDungCa, tienVoid))
                    //{
                    //    MessageBox.Show("Dữ liệu Xoá phần ăn chưa được lưu lại!", "Có lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                    // Cộng lại tiền sau khi xoá phần ăn, hiển thị và định dạng tiền
                    float sum = 0;
                    for (int i = 0; i < dgvOrder.Rows.Count; i++)
                    {
                        sum += float.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString());
                    }
                    txtCash.Text = sum.ToString("### ### ###");
                    txtDiscount.Text = (sum * Gvar.Discount).ToString("### ### ###");
                    txtTotalCash.Text = (sum - (sum * Gvar.Discount)).ToString("### ### ###");
                }
            }
            catch
            {
                MessageBox.Show("Danh sách đang trống!", "Không thể xoá phần ăn!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void bntDisCount_Click(object sender, EventArgs e)
        {
            // Thực hiện Giảm giá
            PhanAn.frmGiamGia frm = new PhanAn.frmGiamGia();
            frm.ShowDialog();
            // Cộng lại tiền sau khi giảm giá, hiển thị và định dạng tiền
            float sum = 0;
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                sum += float.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString());
            }
            txtCash.Text = sum.ToString("### ### ###");
            txtDiscount.Text = (sum * Gvar.Discount).ToString("### ### ###");
            txtTotalCash.Text = (sum - (sum * Gvar.Discount)).ToString("### ### ###");
        }

        private void bntCash_Click(object sender, EventArgs e)
        {
            // Tính tiền
            if (tbOrder.Rows.Count != 0) // Hoá đơn không rỗng
            {
                //Thêm một số thông tin vào DataGirdView để phục vụ in ấn
                DataRow r = tbOrder.NewRow();
                r[Gvar.cFoodName] = "";
                r[Gvar.cCount] = DBNull.Value;
                r[Gvar.cCost] = 0;
                tbOrder.Rows.Add(r);
                //
                DataRow r1 = tbOrder.NewRow();
                r1[Gvar.cFoodName] = "TỔNG TIỀN (CHƯA GIẢM GIÁ)";
                r1[Gvar.cCount] = DBNull.Value;
                float sum = 0;
                for (int i = 0; i < dgvOrder.Rows.Count; i++)
                {
                    sum += float.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString());
                }
                r1[Gvar.cCost] = sum;
                tbOrder.Rows.Add(r1);
                //
                DataRow r2 = tbOrder.NewRow();
                r2[Gvar.cFoodName] = "GIẢM GIÁ " + Gvar.Discount * 100 + "%";
                r2[Gvar.cCount] = DBNull.Value;
                r2[Gvar.cCost] = sum * Gvar.Discount;
                tbOrder.Rows.Add(r2);
                //
                DataRow r3 = tbOrder.NewRow();
                r3[Gvar.cFoodName] = "TỔNG TIỀN (ĐÃ GIẢM GIÁ)";
                r3[Gvar.cCount] = DBNull.Value;
                r3[Gvar.cCost] = sum - (sum * Gvar.Discount);
                tbOrder.Rows.Add(r3);
                //
                Gvar.TongTienPhaiTra = sum - (sum * Gvar.Discount);
                //
                PhanAn.frmThanhToan frm = new PhanAn.frmThanhToan();
                frm.ShowDialog();
                //
                if (Gvar.DaTinhTien) // Nếu không huỷ tính tiền
                {
                    DataRow r4 = tbOrder.NewRow();
                    r4[Gvar.cFoodName] = "TIỀN KHÁCH ĐƯA";
                    r4[Gvar.cCount] = DBNull.Value;
                    r4[Gvar.cCost] = Gvar.SoTienKhachTra;
                    tbOrder.Rows.Add(r4);
                    //
                    DataRow r5 = tbOrder.NewRow();
                    r5[Gvar.cFoodName] = "TIỀN TRẢ LẠI";
                    r[Gvar.cCount] = DBNull.Value;
                    r5[Gvar.cCost] = Gvar.SoTienKhachTra - Gvar.TongTienPhaiTra;
                    tbOrder.Rows.Add(r5);
                    // In Hoá đơn
                    ClsPrint _ClsPrint = new ClsPrint(dgvOrder, String.Format("CHICKSTORE - HOÁ ĐƠN #{0} - [{1}] - In ngày {2} - NV: {3}", txtMaHD.Text, sttType.Text, sttTime.Text, txtSignedInID.Text));
                    _ClsPrint.PrintForm();
                    // Lưu thông tin của Hoá đơn vào CSDL
                    if (!DAL.DAL_PhanAn.LuuThongTinHD(txtDiscount.Text, Gvar.SoHDHientai, Gvar.MaNvDungCa, txtTotalCash.Text))
                    {
                        MessageBox.Show("Không thể lưu trữ trông tin vào CSDL!", "Lỗi lưu trữ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Lưu thông tin CHI TIẾT của Hoá đơn vào CSDL
                    // (trừ các thông tin thừa là 6 hàng cuối phục vụ in ấn)
                    if (!DAL.DAL_PhanAn.LuuThongTinChiTietHD(tbOrder, Gvar.SoHDHientai, sttType.Text))/////////////////////////////////DONGNAY
                    {
                        MessageBox.Show("Không thể lưu trữ trông tin vào CSDL!", "Lỗi lưu trữ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Tăng mã hoá đơn và hiển thị
                    Gvar.SoHDHientai += 1;
                    txtMaHD.Text = Gvar.SoHDHientai.ToString();
                    // Đặt giao diện về giá trị mặc định
                    tbOrder.Clear();
                    txtCash.Text = "";
                    txtDiscount.Text = "";
                    txtTotalCash.Text = "";
                }
                else // Huỷ tính tiền giữa chừng để tiếp tục đặt phần ăn
                {
                    try
                    {
                        // Xoá các hàng thông tin không cần thiết
                        for (int i = 0; i < 4; i++)
                        {
                            tbOrder.Rows.RemoveAt(dgvOrder.Rows.Count - 1);
                        }
                    }
                    catch
                    {
                        //Hoá đơn rỗng ko thể xoá các hàng thông tin
                    }
                }
            }

            else
            {
                MessageBox.Show("Không thể thanh toán hoá đơn rỗng!", "Thanh toán không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntManage_Click(object sender, EventArgs e)
        {
            QuanLyChung.frmDangNhapQuanLy frm = new QuanLyChung.frmDangNhapQuanLy();
            frm.ShowDialog();
        }

        private void bntAbout_Click(object sender, EventArgs e)
        {
            Khac.frmAbout frm = new Khac.frmAbout();
            frm.ShowDialog();
        }

        /// <summary>
        /// Hàm load tên sản phẩm từ CSDL
        /// </summary>
        private void LoadFoodsName()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    var arr = this.Controls.Find("bntSP" + i + j, true);
                    var c = arr.FirstOrDefault();
                    //
                    string kq = DAL.DAL_PhanAn.LoadTenSP(i, j);
                    if (kq != "")
                    {
                        c.Visible = true;
                        c.Text = kq;
                    }
                    else
                    {
                        c.Visible = false;
                    }
                }
            }
        }

        /// <summary>
        /// Hàm load Nhóm sản phẩm từ CSDL
        /// </summary>
        private void LoadFoodGroup()
        {
            // Nhóm Sản phẩm có tên không hợp lệ (không có tên) thì ẩn Tab tương ứng
            // CSDL này có MAX là 5 nhóm (để hiển thị lên giao diện cân đối nhất)
            for (int i = 0; i <= 4; i++)
            {
                string kq = DAL.DAL_PhanAn.LoadNhomSP(i);
                if (kq.ToString() != "")
                {
                    tabFoodList.TabPages[i].Text = kq;
                }
            }
        }

        // Hàm thêm sản phẩm bất kỳ dựa vào "object sender" được cung cấp khi bấm vào Button
        private void bntX_ThemSP_Click(object sender, EventArgs e)
        {
            var bnt = (Button)sender;
            ThemSanPham(bnt.Name);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            bntSignOut_Click(sender, e);
        }

        private void frmTiepNhanPhanAn_Load(object sender, EventArgs e)
        {

        }
    }
}
