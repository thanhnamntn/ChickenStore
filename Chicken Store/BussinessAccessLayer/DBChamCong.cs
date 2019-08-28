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

    public class DBChamCong
    {
        DBLayer db;
          public DBChamCong()
        {
            db = new DBLayer();
        }

          public DataSet getChamCong(string s)
          {
              return db.ExecuteQueryDataSet(
                  "Select ChamCong.MSNV,NhanVien.HoTenNV,NgayThangLamViec,DiLam from ChamCong,NhanVien where ChamCong.MSNV=NhanVien.MSNV " + s,
                  CommandType.Text,
                  null);
          }

          public DataSet getChamCong2(string s)
          {
              return db.ExecuteQueryDataSet(
                  "Select ChamCong.MSNV,NhanVien.HoTenNV from ChamCong,NhanVien where ChamCong.MSNV=NhanVien.MSNV " + s,
                  CommandType.Text,
                  null);
          }

          public DataSet tongGioCong(string s)
          {
              return db.ExecuteQueryDataSet(
                  " select ChamCong.MSNV,NhanVien.HoTenNV,COUNT(DiLam) as TongNgayDiLam from ChamCong,NhanVien where ChamCong.MSNV=NhanVien.MSNV and DiLam=1 group by ChamCong.MSNV,NhanVien.HoTenNV" + s,
                  CommandType.Text,
                  null);
          }





          public bool insertGioCong(ref string err, string MSNV,DateTime NgayThangLamViec,float GioCong)
          {
              return db.MyExecuteNonQuery(
                  "sp_insertGioCongtoChamCong",
                  CommandType.StoredProcedure,
                  ref err,
                  new SqlParameter("@MSNV", MSNV),
                  new SqlParameter("@NgayThangLamViec", NgayThangLamViec),
                  new SqlParameter("@GioCong", GioCong));

          }



        

       
    }
}
