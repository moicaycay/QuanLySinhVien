using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string a = null;
            //  int b = cbbBang1.SelectedIndex;
            // switch(b)
            // {
            //     case 0: a = "KHOA"; break;
            //     case 1: a = "LOP"; break;
            //     case 2: a = "SINHVIEN"; break;
            // }
            // string sql = "select * from " + a;
            //  SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            //  con.Open();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            //  SqlCommand cmd = new SqlCommand(sql, con);
            //  DataTable dt = new DataTable();
            //  SqlDataAdapter da = new SqlDataAdapter();
            //  da.SelectCommand = cmd;
            //  da.Fill(dt);
            //  dataGridView1.DataSource = dt;
            //  con.Close();
            string a = cbbBang1.SelectedValue.ToString();
            string sql = "select * from KHOA where MaKhoa = " + "'" + a + "'";
            SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string a = cbbKhoa1.SelectedValue.ToString();
            string sql = "select * from LOP where MaKhoa = " + "'"+a+ "'";
            SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from KHOA";
            SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cbbKhoa1.DataSource = dt;
            cbbKhoa1.DisplayMember = "TenKhoa";
            cbbKhoa1.ValueMember = "MaKhoa";
            cbbKhoa2.DataSource = dt;
            cbbKhoa2.DisplayMember = "TenKhoa";
            cbbKhoa2.ValueMember = "MaKhoa";
            cbbBang1.DataSource = dt;
            cbbBang1.DisplayMember = "TenKhoa";
            cbbBang1.ValueMember = "MaKhoa";
            con.Close();
        }

        private void cbbKhoa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cbbKhoa2.SelectedValue.ToString();
            string sql = "select * from LOP where MaKhoa = " + "'" + a + "'";
            SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cbbLop1.DataSource = dt;
            cbbLop1.DisplayMember = "TenLop";
            cbbLop1.ValueMember = "MaLop";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = cbbLop1.SelectedValue.ToString();
            string sql = "select * from SINHVIEN where MaLop = " + "'" + a + "'";
            SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }
    }
}
