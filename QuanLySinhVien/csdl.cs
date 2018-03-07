using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    class csdl
    {
        SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        public void KetNoi()
        {
            con.Open();
        }
        public DataTable GetData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, this.con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public void Dong()
        {
            con.Close();
            con.Dispose();
        }
    }
}
