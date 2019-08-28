using System;
using System.Data;
using System.Data.SqlClient;

namespace ChickStore.DAL
{
    class DAL_PhanAn
    {
        /// <summary>
        /// Hàm lấy mã hoá đơn mới (hoá đơn tiếp theo)
        /// </summary>
        /// <returns>Số hoá đơn</returns>
        public static int SoHDHienTai()
        {
            int so = 0;
            //Truy vấn
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ChickStore.Gvar.cnnString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            // Truy vấn lấy mã hoá đơn mới nhất để xác định mã hoá đơn tiếp theo
            String sql = String.Format("Select MAX(MSHoaDon) as SoHDHienTai From HoaDon");
            cmd.CommandText = sql;
            try
            {
                SqlDataReader n = cmd.ExecuteReader();
                while (n.Read())
                {
                    so = Int32.Parse(n["SoHDHienTai"].ToString()) + 1;
                }
            }
            catch
            {
                so = 1;
            }
            cnn.Close();
            return so;
        }

        /// <summary>
        /// Hàm lấy giá SP theo tên SP
        /// </summary>
        /// <param name="tenSP">Tên SP</param>
        /// <returns>Giá SP</returns>
        public static int LayGiaSPTheoTen(string tenSP)
        {
            // Truy vấn
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ChickStore.Gvar.cnnString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            // Khởi tạo biến dùng cho truy vấn
            int giaSP = 0;
            try
            {
                // Lấy ra giá sản phẩm tương ứng theo tên SP
                String sql = String.Format("Select GiaSP from QuanLySanPham where IDSP='{0}'", tenSP);
                cmd.CommandText = sql;
                object result = cmd.ExecuteScalar();
                if (result.ToString() != "")
                {
                    giaSP = Int32.Parse(result.ToString());
                }
            }
            catch
            {
                giaSP = -1;
            }
            return giaSP;
        }

        /// <summary>
        /// Hàm ghi thông tin hoá đơn
        /// </summary>
        /// <param name="discount">Số tiền đã giảm giá</param>
        /// <param name="MSHoaDon">Mã hoá đơn</param>
        /// <param name="MSNV">Mã nhân viên</param>
        /// <param name="totalCash">Tổng tiền khách phải trả</param>
        /// <param name="khachtra">Tiền khách đưa</param>
        /// <returns>Kết quả thành công hay thất bại</returns>
        public static bool LuuThongTinHD(string discount, int MSHoaDon, string MSNV, string totalCash)
        {
            bool kq = true;
            // Truy vấn Lưu thông tin của Hoá đơn vào CSDL
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ChickStore.Gvar.cnnString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            try
            {
                String sql;
                if (discount.Replace(" ", "") == "")
                {
                    //sql = String.Format("INSERT INTO HoaDon(MSHoaDon, MSNV, TongTien, DaGiamGia, NgayIn, GioIn, TienKhachDua) VALUES ({0}, N'{1}', {2}, {3}, '{4}', '{5}', {6})", MSHoaDon, MSNV, totalCash.Replace(" ", ""), 0, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("H:mm:ss"), khachtra.ToString().Replace(" ", ""));
                    sql = String.Format("INSERT INTO HoaDon(MSHoaDon, MSNV, Pos, LoaiPhucVu, ThoiGianXuatHD, TienGiamGia, TongThanhToan) VALUES ('{0}', N'{1}', {2}, '{3}', '{4}', {5}, {6})",
                        MSHoaDon, MSNV, 0, Gvar.LoaiPhucVu, DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"), 0, totalCash.Replace(" ", ""));
                }
                else
                {
                    //sql = String.Format("INSERT INTO HoaDon(MSHoaDon, MSNV, TongTien, DaGiamGia, NgayIn, GioIn, TienKhachDua) VALUES ({0}, N'{1}', {2}, {3}, '{4}', '{5}', {6})", MSHoaDon, MSNV, totalCash.Replace(" ", ""), discount.Replace(" ", ""), DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("H:mm:ss"), khachtra.ToString().Replace(" ", ""));
                    sql = String.Format("INSERT INTO HoaDon(MSHoaDon, MSNV, Pos, LoaiPhucVu, ThoiGianXuatHD, TienGiamGia, TongThanhToan) VALUES ('{0}', N'{1}', {2}, '{3}', '{4}', {5}, {6})",
                        MSHoaDon, MSNV, 0, Gvar.LoaiPhucVu, DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"), discount.Replace(" ", ""), totalCash.Replace(" ", ""));
                }
                cmd.CommandText = sql;
                int n = cmd.ExecuteNonQuery();
                if (n != 1)
                {
                    kq = false;
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
                kq = false;
            }
            cnn.Close();
            return kq;
        }

        /// <summary>
        /// Hàm ghi thông tin chi tiết của hoá đơn
        /// </summary>
        /// <param name="tbOrder">Danh sách phần ăn đã đặt</param>
        /// <param name="MSHoaDon">Mã hoá đơn</param>
        /// <param name="type">Loại phục vụ</param>
        /// <param name="khachtra">Số tiền khách đưa</param>
        /// <returns>Kết quả thành công hay thất bại</returns>
        /// //CSDL: MSHoaDon, PhanAn, SL, ThanhTien
        public static bool LuuThongTinChiTietHD(DataTable tbOrder, int MSHoaDon, string type)
        {
            bool kq = true;
            // Truy vấn Lưu thông tin CHI TIẾT của Hoá đơn vào CSDL
            // (trừ các thông tin thừa là 6 hàng cuối phục vụ in ấn)
            // Truy vấn Lưu thông tin của Hoá đơn vào CSDL
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ChickStore.Gvar.cnnString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            try
            {
                for (int i = 0; i < tbOrder.Rows.Count - 6; i++)
                {
                    string TenSP = tbOrder.Rows[i][Gvar.cFoodName].ToString().Trim();
                    //int sl = 0;
                    //for (int j = 0; j < tbOrder.Rows.Count - 6; j++)
                    //{
                    //    if (tbOrder.Rows[j][Gvar.cFoodName].ToString().Trim() == TenSP)
                    //    {
                    //        sl = sl + Int32.Parse(tbOrder.Rows[j][Gvar.cCount].ToString().Trim());
                    //    }
                    //}
                    String sql = String.Format("Select IDSP from QuanLySanPham where TenSP LIKE N'{0}%'", TenSP);
                    cmd.CommandText = sql;
                    object result = cmd.ExecuteScalar();
                    string idsp = "";
                    if (result.ToString() != "")
                    {
                        idsp = result.ToString();
                    }
                    sql = String.Format("INSERT INTO ChiTietHoaDon(MSHoaDon, PhanAn, SL, ThanhTien) VALUES ('{0}', '{1}', {2}, {3})", MSHoaDon.ToString(), idsp.ToString(), tbOrder.Rows[i][Gvar.cCount].ToString().Replace(" ", ""), tbOrder.Rows[i][Gvar.cCost].ToString().Replace(" ", ""));
                    cmd.CommandText = sql;
                    int n = cmd.ExecuteNonQuery();
                    if (n != 1)
                    {
                        kq = false;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
                kq = false;
            }
            cnn.Close();
            return kq;
        }

        /// <summary>
        /// Hàm load tên sản phẩm từ CSDL
        /// </summary>
        /// <param name="i">Phần Nhóm trong Mã SP</param>
        /// <param name="j">Phần Mã nhận biết SP trong Mã SP</param>
        /// <returns>Tên SP</returns>
        public static string LoadTenSP(int i, int j)
        {
            // Truy vấn và load tên sản phẩm từ CSDL
            // Sản phẩm có tên không hợp lệ (không có tên) thì ẩn Button tương ứng
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ChickStore.Gvar.cnnString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();

            try
            {
                String sql = String.Format("Select TenSP from QuanLySanPham where IDSP='bntSP{0}{1}'", i, j);
                cmd.CommandText = sql;
                //
                object result = cmd.ExecuteScalar();
                //
                return result.ToString();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Hàm load Tên nhóm SP từ CSDL
        /// </summary>
        /// <param name="i">Mã nhóm SP</param>
        /// <returns>Tên nhóm SP</returns>
        public static string LoadNhomSP(int i)
        {
            // Truy vấn và load tên sản phẩm từ CSDL
            // Sản phẩm có tên không hợp lệ (không có tên) thì ẩn Button tương ứng
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ChickStore.Gvar.cnnString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();

            try
            {
                String sql = String.Format("Select TenNhomSP from NhomSanPham where IDNhomSP='subtab{0}'", i + 1);
                cmd.CommandText = sql;
                //
                object result = cmd.ExecuteScalar();
                //
                return result.ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}
