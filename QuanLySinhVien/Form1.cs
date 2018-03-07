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
            
             string a = null;
              int b = cboKhoa1.SelectedIndex;
             switch(b)
             {
                 case 0: a = "KHOA"; break;
                 case 1: a = "LOP"; break;
                 case 2: a = "SINHVIEN"; break;
             }
             string sql = "select * from " + a;
            //SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            //con.Open();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            //SqlCommand cmd = new SqlCommand(sql, con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            csdl csdl = new csdl();
            csdl.KetNoi();
            dtgKhoa.DataSource = csdl.GetData(sql);
              //con.Close();
            //string sql = "select * from KHOA where MaKhoa = " + "'" + cboKhoa1.SelectedValue.ToString() + "'";
            //SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            //dtgKhoa.DataSource = dt;
            //con.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from LOP where MaKhoa = " + "'"+ cboKhoa2.SelectedValue.ToString() + "'";
            //SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            csdl csdl = new csdl();
            csdl.KetNoi();
            dtgLop.DataSource = csdl.GetData(sql);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from KHOA";
            //SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            csdl csdl = new csdl();
            csdl.KetNoi();
            cboKhoa2.DataSource = csdl.GetData(sql);
            cboKhoa2.DisplayMember = "TenKhoa";
            cboKhoa2.ValueMember = "MaKhoa";
            cboKhoa3.DataSource = csdl.GetData(sql);
            cboKhoa3.DisplayMember = "TenKhoa";
            cboKhoa3.ValueMember = "MaKhoa";
           // cboKhoa1.DataSource = dt;
            //cboKhoa1.DisplayMember = "TenKhoa";
            //cboKhoa1.ValueMember = "MaKhoa";
            
        }

        private void cbbKhoa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from LOP where MaKhoa = " + "'" + cboKhoa3.SelectedValue.ToString() + "'";
            //SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            csdl csdl = new csdl();
            csdl.KetNoi();
            cboLop1.DataSource = csdl.GetData(sql);
            cboLop1.DisplayMember = "TenLop";
            cboLop1.ValueMember = "MaLop";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from SINHVIEN where MaLop = " + "'" + cboLop1.SelectedValue.ToString() + "'";
            //SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand(sql, con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            csdl csdl = new csdl();
            csdl.KetNoi();
            dtgSinhVien.DataSource = csdl.GetData(sql);
        }
    }
}
