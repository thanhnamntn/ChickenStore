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
    public class DBDoanhThu
    {
        DBLayer db;
        public DBDoanhThu()
        {
            db = new DBLayer();
        }

        public DataSet getThuChiCuoiCa(string date)
        {
            return db.ExecuteQueryDataSet(
                "select * from funcDoanhThuTheoNgay('" + date +"')",
                //"select * from DoanhThuNgay('" + date + "')",
                CommandType.Text,
                null);
        }

        public DataSet getDoanhThuThang(string CuoiThang,string DauThang)
        {
            return db.ExecuteQueryDataSet(
                "select * from funcDoanhThuTrongThang('"+CuoiThang+"','"+DauThang+"')",
                CommandType.Text,
                null);
        }

        public DataSet getTongDoanhThuThang(string CuoiThang, string DauThang)
        {
            return db.ExecuteQueryDataSet(
                "select * from funcTongDoanhThuTrongThang('"+CuoiThang+"','"+DauThang+"')",
                CommandType.Text,
                null);
        }

        public bool checkExist(string Thang, string Nam)
        {


            string sqlcommand = "select *from DoanhThuThang where Thang='"+Thang+"' and Nam='"+Nam+"'";

            db.cnn.Open();
            db.cmd.Connection = db.cnn;

            db.cmd.CommandType = CommandType.Text;
            db.cmd.CommandText = sqlcommand;

            SqlDataReader dr = db.cmd.ExecuteReader();
            if (dr.Read())
            {
                db.cnn.Close();
                return true;

            }
            db.cnn.Close();
            return false;
        }


        public string TaoMa_DoanhThuThang(string St, int Lenght)
        {
            string Result = "";
            db.cnn.Open();
            string Schuoi = "Select Top 1 Convert(int,Right(MSBaoCaoThang,3))+1 From DoanhThuThang Order By MSBaoCaoThang desc";

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


        public bool insertDoanhThuThang(ref string err, string MSBaoCaoThang,int Nam,int Thang,double TongDoanhThu)
        {
            return db.MyExecuteNonQuery(
                "spInsertDoanhThuThang",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MSBaoCaoThang",MSBaoCaoThang),
                new SqlParameter("@Nam", Nam),
                new SqlParameter("@Thang", Thang),
                new SqlParameter("@TongDoanhThu", TongDoanhThu));

        }


      




    }
}
