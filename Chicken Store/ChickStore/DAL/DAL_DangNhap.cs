using System;
using System.Data.SqlClient;

namespace ChickStore.DAL
{
    class DAL_DangNhap
    {
        /// <summary>
        /// Hàm đăng nhập Nhân viên
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="pw">Mật khẩu</param>
        /// <returns>Tên của nhân viên đó</returns>
        public static string DangNhap(string id, string pw)
        {
            string tenNV = "";
            // Truy vấn
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Gvar.cnnString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            try
            {
                // Biến "Giờ vào" lưu thời gian đăng nhập của NV
                DateTime gioVao = DateTime.Now;
                // Truy vấn đăng nhập
                String sql = String.Format("Select * From NhanVien Where MSNV='{0}' And Password='{1}' And LaQL=0", id, pw);
                cmd.CommandText = sql;
                SqlDataReader n = cmd.ExecuteReader();
                while (n.Read())
                {
                    // Lấy ra tên Nhân viên đã đăng nhập
                    tenNV = (string)n["HoTenNV"];
                }
            }
            catch
            {
                tenNV = "";
            }
            cnn.Close();
            return tenNV;
        }

        /// <summary>
        /// Hàm Đăng nhập Quản lý
        /// </summary>
        /// <param name="idQL">Mã QL</param>
        /// <param name="pwQL">Mật khẩu của QL</param>
        /// <returns>Kết quả thành công hay thất bại</returns>
        public static bool DangNhapQuanLy(string idQL, string pwQL)
        {
            bool kq = false;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ChickStore.Gvar.cnnString;
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            try
            {
                String sql = String.Format("Select * From NhanVien Where MSNV='{0}' And Password='{1}' and LaQL=1", idQL, pwQL);
                cmd.CommandText = sql;
                SqlDataReader n = cmd.ExecuteReader();
                int count = 0;
                while (n.Read())
                {
                    count++;
                }
                if (count == 1)
                    kq = true;
                else
                    kq = false;
            }
            catch
            {
                kq = false;
            }
            cnn.Close();
            return kq;
        }
    }
}
