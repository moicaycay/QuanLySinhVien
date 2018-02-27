using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySinhVien
{
    class Untill
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public SqlConnection OpenDB()
        {
            con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            return con;
        }
        public static void OpenCon()
        {
            string sql = "Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            try
            {
                con = new SqlConnection(sql);
                con.Open();
            }
            catch(SqlException Ex)
            { }
        }
        public static void CloseCon()
        {
            con.Close();
            con.Dispose();
            con = null;
        }
        public static DataTable TaoBang(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable ds = new DataTable();
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            return ds;

        }
        public static void ThaoTac(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
