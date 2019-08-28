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
    public class DBKhoWetGoods
    {
        DBLayer db;
        public DBKhoWetGoods()
        {
            db = new DBLayer();
        }

        public DataSet getMatHang(string s)
        {
            return db.ExecuteQueryDataSet(
                "Select * from  MatHangWetGoods  " + s,
                CommandType.Text,
                null);
        }


        public DataSet thongtinXuatKho(string s)
        {
            return db.ExecuteQueryDataSet(
                "select MaHang,NgayHetHan,SUM(ThucNhan) as KhoWetGoods"+
                " from NhapWetGoods "+
                "where MaHang='"+s+"'"+
                " group by MaHang,NgayHetHan " ,
                CommandType.Text,
                null);
        }

        public DataSet QLKho(string s)
        {
            return db.ExecuteQueryDataSet(
                "select MatHangWetGoods.MaHang,TenHang,DonViTinh,SL,ThucNhan,NgayNhap,NgayHetHan from NhapWetGoods,MatHangWetGoods where NhapWetGoods.MaHang=MatHangWetGoods.MaHang " + s,
                CommandType.Text,
                null);
        }



        public bool insertNhapKhoWetGoods(ref string err,string MaNhap, string MaHang, DateTime NgayNhap, int SL,int ThucNhan, DateTime NgayHetHan )
        {
            return db.MyExecuteNonQuery(
                "sp_insertNhapWetGoods",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaNhap", MaNhap),
                new SqlParameter("@MaHang", MaHang),
                new SqlParameter("@NgayNhap", NgayNhap),
                new SqlParameter("@SL", SL),
                new SqlParameter("@ThucNhan", ThucNhan),
                new SqlParameter("@NgayHetHan", NgayHetHan));

        }


        public bool UpdateNhap_XuatWetGoods(ref string err, string MaHang, string MaXuat, DateTime NgayXuat, int SLXuat )
        {
            return db.MyExecuteNonQuery(
                "spUpdateNhap_XuatWetGoods",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHang", MaHang),
                new SqlParameter("@MaXuat", MaXuat),
                new SqlParameter("@NgayXuat",NgayXuat),
                new SqlParameter("@SLXuat", SLXuat));

        }

        public bool UpdateNhapWetGoods(ref string err, string MaHang, int SL,int ThucNhan,DateTime NgayNhap,DateTime NgayHetHan)
        {
            return db.MyExecuteNonQuery(
                "spUpdateNhap_XuatWetGoods",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHang", MaHang),
                new SqlParameter("@SL", SL),
                new SqlParameter("@ThucNhan", ThucNhan),
                new SqlParameter("@NgayNhap",NgayNhap),
                new SqlParameter("@NgayHetHan",NgayHetHan));

        }
        




        public string TaoMa_NhapHang(string St, int Lenght)
        {
            string Result = "";
            db.cnn.Open();
            string Schuoi = "Select Top 1 Convert(int,Right(MaNhap,3))+1 From NhapWetGoods Order By MaNhap desc";

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


        public string TaoMa_XuatHang(string St, int Lenght)
        {
            string Result = "";
            db.cnn.Open();
            string Schuoi = "Select Top 1 Convert(int,Right(MaXuat,3))+1 From XuatWetGoods Order By MaXuat desc";

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

          public bool checkExist(string strTest)
        {

            string sqlcommand = "Select * from NhapWetGoods Where MaHang='" + strTest + "'";
            SqlCommand cmd = db.cmd;
            cmd.Connection = db.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlcommand;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
         
                return true;
            }
            else
            {

                return false;
            }
        }
    



    }
}
