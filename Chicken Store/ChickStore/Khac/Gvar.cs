using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChickStore
{
    public static class Gvar
    {
        // Chuỗi kết nối
        public static string cnnString = "Data Source=DESKTOP-R3MLR1D;Initial Catalog=ChickStore;Integrated Security=True";
        //public static string cnnString = @"Data Source=localhost;AttachDbFilename=D:\ChickyStoreDatabase\CuaHangGa.mdf;Initial Catalog=CuaHangGa;Integrated Security=True";

        // Phần trăm loading
        private static int loadPercent;
        public static int LoadPercent
        {
            get { return Gvar.loadPercent; }
            set { Gvar.loadPercent = value; }
        }

        // Mã Nhân viên đứng ca
        private static string maNVDungCa; 
        public static string MaNvDungCa
        {
            get { return Gvar.maNVDungCa; }
            set { Gvar.maNVDungCa = value; }
        }

        // Tên Nhân viên đứng ca
        private static string tenNvDungCa; 
        public static string TenNvDungCa
        {
            get { return Gvar.tenNvDungCa; }
            set { Gvar.tenNvDungCa = value; }
        }

        // Tiền vay khi vào ca, Mặc định luôn là 1.000.000, thay đổi ở form PhanAn.frmTiepNhanPhanAn
        private static int tienVay;
        public static int TienVay
        {
            get { return tienVay; }
            set { tienVay = value; }
        }

        // Doanh thu
        private static int doanhThu;
        public static int DoanhThu
        {
            get { return Gvar.doanhThu; }
            set { Gvar.doanhThu = value; }
        }

        // Loại phục vụ: Gồm các tuỳ chọn: (0 = tại đây), (1 = đem về), (2 = giao hàng)
        private static int loaiPhucVu; 
        public static int LoaiPhucVu
        {
            get { return Gvar.loaiPhucVu; }
            set { Gvar.loaiPhucVu = value; }
        }

        // Chuyển tuỳ chọn "Loại phục vụ" ra chuỗi để hiển thị
        public static string AnODauString(int type) 
        {
            if (type == 0)
                return "Ăn tại đây";
            else if (type == 1)
                return "Mang về";
            else if (type == 2)
                return "Giao hàng";
            else
                return "LỖI!";
        }

        // 3 biến lưu trữ tên cột trong các DataGirdView với mục đích đồng bộ
        public static string cFoodName = "TenSP";   // [Tên cột 1]
        public static string cCount = "SL";         // [Tên cột 2]
        public static string cCost = "ThanhTien";   // [Tên cột 3]

        // Phần trăm giảm giá
        private static float discount;
        public static float Discount
        {
            get { return Gvar.discount; }
            set { Gvar.discount = value; }
        }

        // Mã Hoá đơn hiện tại
        private static int soHDHientai;
        public static int SoHDHientai
        {
            get { return Gvar.soHDHientai; }
            set { Gvar.soHDHientai = value; }
        }

        // Tổng tiền khách phải trả
        private static float tongTienPhaiTra;
        public static float TongTienPhaiTra
        {
            get { return Gvar.tongTienPhaiTra; }
            set { Gvar.tongTienPhaiTra = value; }
        }

        // Số tiền khách đưa cho nhân viên
        private static float soTienKhachTra;
        public static float SoTienKhachTra
        {
            get { return Gvar.soTienKhachTra; }
            set { Gvar.soTienKhachTra = value; }
        }

        // Số tiền Nhân viên thối lại cho khách
        private static float soTienThoi;
        public static float SoTienThoi
        {
            get { return Gvar.soTienThoi; }
            set { Gvar.soTienThoi = value; }
        }

        // Cờ kiểm tra xem có huỷ tính tiền giữa chừng để đặt phần ăn tiếp hay không
        private static bool huyTinhTien;
        public static bool DaTinhTien
        {
            get { return Gvar.huyTinhTien; }
            set { Gvar.huyTinhTien = value; }
        }
    }

}
