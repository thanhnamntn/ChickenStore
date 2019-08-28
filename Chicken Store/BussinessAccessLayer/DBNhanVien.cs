using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BussinessAccessLayer
{
  public  class DBNhanVien
    {
         DBLayer db;
          public DBNhanVien()
        {
            db = new DBLayer();
        }


          public bool insertNhanVien(ref string err, string MSNV, string HoTenNV, DateTime NgSinh,string GioiTinh,string QueQuan,string MaBoPhan,DateTime NgayTiepNhan)
          {
              return db.MyExecuteNonQuery(
                  "spInsertNhanVien",
                  CommandType.StoredProcedure,
                  ref err,
                  new SqlParameter("@MSNV", MSNV),
                  new SqlParameter("@HoTenNV", HoTenNV),
                  new SqlParameter("@NgSinh", NgSinh),
                  new SqlParameter("@GioiTinh", GioiTinh),
                  new SqlParameter("@QueQuan", QueQuan),
                  new SqlParameter("@MaBoPhan", MaBoPhan),
                  new SqlParameter("@NgayTiepNhan", NgayTiepNhan));

          }
          public DataSet getNhanVien(string s)
          {
              return db.ExecuteQueryDataSet(
                   "select * from NhanVien " +s,                 
                  CommandType.Text,
                  null);
          }

          public DataSet getMaBoPhan(string s)
          {
              return db.ExecuteQueryDataSet(
                 "select MaBoPhan from BoPhan where TenBoPhan ='" + s+"'",
                  CommandType.Text,
                  null);
          }

          public DataSet getTenBoPhan(string s)
          {
              return db.ExecuteQueryDataSet(
                 "select TenBoPhan from BoPhan where MaBoPhan ='" + s + "'",
                  CommandType.Text,
                  null);
          }

          public string TaoMa_NhanVien(string St, int Lenght)
          {
              string Result = "";
              db.cnn.Open();
              string Schuoi = "Select Top 1 Convert(int,Right(MSNV,3))+1 From NhanVien Order By MSNV desc";

              SqlCommand cmd = new SqlCommand();
              cmd.CommandText = Schuoi;
              cmd.Connection = this.db.cnn;
              cmd.CommandType = CommandType.Text;

              int number = 0;
              try
              {
                  object ob = cmd.ExecuteScalar();
                  if (ob == null) number = 1;
                  else
                      number = (int)ob;
              }
              catch
              {
                  return Result;
              }
              int d = Lenght - St.Length - number.ToString().Length;
              Result = St;
              for (int i = 0; i < d; i++)
                  Result += '0';
              Result += number.ToString();
              db.cnn.Close();
              return Result;
          }

    }
}
