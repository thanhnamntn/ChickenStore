using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussinessAccessLayer
{
    public class DBTinhLuong
    {
        DBLayer db;
          public DBTinhLuong()
        {
            db = new DBLayer();
        }

          public DataSet getTinhLuong()
          {
              return db.ExecuteQueryDataSet(
                  " select A.MSNV,A.HoTenNV,A.NgayCongThuong,B.NgayCongLe " +
                    " from (select NhanVien.MSNV,NhanVien.HoTenNV,COUNT(ChamCong.DiLam) as NgayCongThuong " +
                    " From NhanVien,ChamCong " +
                    "where NhanVien.MSNV=ChamCong.MSNV and LaNgayLe=0 " +
                    "group by NhanVien.MSNV,NhanVien.HoTenNV ) as A inner join "+
                    " (select NhanVien.MSNV,COUNT(ChamCong.DiLam)as NgayCongLe " +
                    "From NhanVien,ChamCong "+
                      "where NhanVien.MSNV=ChamCong.MSNV and LaNgayLe=1 "+
                        "group by NhanVien.MSNV,NhanVien.HoTenNV ) as B on A.MSNV=B.MSNV",
                  CommandType.Text,
                  null);
          }

          public bool insertBangLuong(ref string err, string MSNV, DateTime ThangNamTinhLuong, float TongGioCongNgayThuong,float TongGioCongNgayLe,float Luong)
          {
              return db.MyExecuteNonQuery(
                  "sp_insertBangLuong",
                  CommandType.StoredProcedure,
                  ref err,
                  new SqlParameter("@MSNV", MSNV),
                  new SqlParameter("@ThangNamTinhLuong", ThangNamTinhLuong),
                  new SqlParameter("@TongGioCongNgayThuong", TongGioCongNgayThuong),
                  new SqlParameter("@TongGioCongNgayLe", TongGioCongNgayLe),
                  new SqlParameter("@Luong", Luong));

          }
    }
}
