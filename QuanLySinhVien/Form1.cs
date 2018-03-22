using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            
        //     //string a = null;
        //     // int b = cboKhoa1.SelectedIndex;
        //     //switch(b)
        //     //{
        //     //    case 0: a = "KHOA"; break;
        //     //    case 1: a = "LOP"; break;
        //     //    case 2: a = "SINHVIEN"; break;
        //     //}             string sql = "select * from " + a;
        //    //SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        //    //con.Open();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        //    //SqlCommand cmd = new SqlCommand(sql, con);
        //    //DataTable dt = new DataTable();
        //    //SqlDataAdapter da = new SqlDataAdapter();
        //    //da.SelectCommand = cmd;
        //    //da.Fill(dt);
        //    //csdl csdl = new csdl();
        //    //csdl.KetNoi();
        //    //dtgKhoa.DataSource = csdl.GetData(sql);
        //      //con.Close();
        //    //string sql = "select * from KHOA where MaKhoa = " + "'" + cboKhoa1.SelectedValue.ToString() + "'";
        //    //SqlConnection con = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        //    //con.Open();
        //    //SqlCommand cmd = new SqlCommand(sql, con);
        //    //DataTable dt = new DataTable();
        //    //SqlDataAdapter da = new SqlDataAdapter();
        //    //da.SelectCommand = cmd;
        //    //da.Fill(dt);
        //    //dtgKhoa.DataSource = dt;
        //    //con.Close();
        //}
        
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
            dtgKhoa.DataSource = csdl.GetData(sql);
            btnSave1.Enabled = false;
            btnSave2.Enabled = false;
            btnSave3.Enabled = false;
            
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

        private void dtgKhoa_SelectionChanged(object sender, EventArgs e)
        {
            tbMaKhoa.Text = dtgKhoa[0, dtgKhoa.CurrentRow.Index].Value.ToString();
            tbTenKhoa.Text = dtgKhoa[1, dtgKhoa.CurrentRow.Index].Value.ToString();
            tbSDT.Text = dtgKhoa[2, dtgKhoa.CurrentRow.Index].Value.ToString();
            btnSave1.Enabled = false;
        }

        private void cboKhoa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from LOP where MaKhoa = " + "'" + cboKhoa2.SelectedValue.ToString() + "'";
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

        private void dtgLop_SelectionChanged(object sender, EventArgs e)
        {
            string a = dtgLop[0, dtgLop.CurrentRow.Index].Value.ToString();
            tbKhoaL2.Text = a.Substring(0, 3);
            tbLop2.Text = a.Substring(3, 1);
            tbSiSo2.Text = dtgLop[3, dtgLop.CurrentRow.Index].Value.ToString();
            string[] s;
            string b = dtgLop[2, dtgLop.CurrentRow.Index].Value.ToString();
            s = b.Split(' ');
            string c = null;
            for (int i = 1; i < s.Length; i++)
                c = c + s[i] + " ";
            c = c.TrimEnd();
            tbNganh2.Text = c;
        }

        private void DtgSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = dtgSinhVien[4, dtgSinhVien.CurrentRow.Index].Value.ToString();
            tbHoTen3.Text = dtgSinhVien[2, dtgSinhVien.CurrentRow.Index].Value.ToString();
            tbSDT3.Text = dtgSinhVien[5, dtgSinhVien.CurrentRow.Index].Value.ToString();
            if ( String.Compare(dtgSinhVien[3, dtgSinhVien.CurrentRow.Index].Value.ToString(), "True") == 0)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;

           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            tbMaKhoa.Clear();
            tbMaKhoa.Focus();
            tbTenKhoa.Clear();
            tbSDT.Clear();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbNganh2.Clear();
            tbKhoaL2.Focus();
            tbSiSo2.Clear();
            tbKhoaL2.Clear();
            tbLop2.Clear();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbSDT3.Clear();
            tbHoTen3.Clear();
            tbHoTen3.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Refresh();
            

        }

        private void CboLop1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Button2_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult key = MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (key == DialogResult.Yes)
                    {
                        try
                        {
                            //SqlConnection cn = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
                            //string sql = "insert into KHOA values(N'" + textBox1.Text.ToString() + "', N'" + textBox2.Text.ToString() + "', " + textBox3.Text.ToString() + ")";
                            //SqlCommand cmd = new SqlCommand(sql, cn);
                            //cmd.CommandType = CommandType.Text;
                            //cn.Open();
                            //cmd.ExecuteNonQuery();
                            //cn.Close();
                            //cn.Dispose();
                            string khoa = "select * from KHOA";
                            csdl csdl = new csdl();
                            string sql = "insert into KHOA values(N'" + tbMaKhoa.Text.ToString() + "', N'" + tbTenKhoa.Text.ToString() + "', " + tbSDT.Text.ToString() + ")";
                            csdl.Them(sql);
                            csdl.KetNoi();
                            dtgKhoa.DataSource = csdl.GetData(khoa);
                            cboKhoa2.DataSource = csdl.GetData(khoa);
                            cboKhoa2.DisplayMember = "TenKhoa";
                            cboKhoa2.ValueMember = "MaKhoa";
                            cboKhoa3.DataSource = csdl.GetData(khoa);
                            cboKhoa3.DisplayMember = "TenKhoa";
                            cboKhoa3.ValueMember = "MaKhoa";

                    }

                        catch (Exception LOI)
                        {
                            MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                }

            }

        }

        

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            btnSave3.Enabled = true;
        }

        

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (btnSave1.Enabled == true)
            {
                Button2_Click_1(sender, e);
                this.Close();
            }
            else
                this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            {
                
                DialogResult key = MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (key == DialogResult.Yes)
                {
                    try
                    {
                        string[] s;
                        s = tbNganh2.Text.ToString().Split(' ');
                        string c = null;
                        for (int i = 0; i < s.Length; i++)
                            c = c + s[i].Substring(0, 1);
                        string d = tbKhoaL2.Text.ToString() + tbLop2.Text.ToString() + c.ToUpper();
                        string sql = "insert into LOP values(N'" + d + "', N'" + cboKhoa2.SelectedValue.ToString() + "', N'" + tbKhoaL2.Text.ToString() + tbLop2.Text.ToString() + " " + tbNganh2.Text.ToString() + "', N'" + tbSiSo2.Text.ToString() + "')";
                        csdl csdl = new csdl();
                        csdl.Them(sql);
                        csdl.KetNoi();
                        string lop = "select * from LOP where MaKhoa = " + "'" + cboKhoa2.SelectedValue.ToString() + "'"; 
                        dtgLop.DataSource = csdl.GetData(lop);
                    }

                    catch (Exception LOI)
                    {
                        MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            {
                DialogResult key = MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (key == DialogResult.Yes)
                {
                    try
                    {
                        StreamReader sr = new StreamReader("data.txt");
                        string maSV = sr.ReadLine();
                        sr.Close();
                        int maSV1 = 1 + int.Parse(maSV);
                        StreamWriter sw = new StreamWriter("data.txt");
                        sw.Write(maSV1);
                        sw.Close();
                        string sql = "insert into SINHVIEN values(N'" + maSV1.ToString() + "', N'" + cboLop1.SelectedValue.ToString() + 
                                                                    "',N' " + tbHoTen3.Text.ToString() + "', N'" + (radioButton1.Checked == true ? "True":"False") + 
                                                                    "', N'" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "', N'" + tbSDT3.Text.ToString() + "')";
                        csdl csdl = new csdl();
                        csdl.Them(sql);
                        csdl.KetNoi();
                        string sinhvien = "select * from SINHVIEN where MaLop = " + "'" + cboLop1.SelectedValue.ToString() + "'";
                        dtgSinhVien.DataSource = csdl.GetData(sinhvien);
                    }

                    catch (Exception LOI)
                    {
                        MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (btnSave2.Enabled == true)
            {
                Button5_Click(sender, e);
                this.Close();
            }
            else
                this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (btnSave3.Enabled == true)
            {
                Button8_Click(sender, e);
                this.Close();
            }
            else
                this.Close();
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn cập nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    //SqlConnection cn = new SqlConnection("Data Source=AME\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
                    //string sql = "insert into KHOA values(N'" + textBox1.Text.ToString() + "', N'" + textBox2.Text.ToString() + "', " + textBox3.Text.ToString() + ")";
                    //SqlCommand cmd = new SqlCommand(sql, cn);
                    //cmd.CommandType = CommandType.Text;
                    //cn.Open();
                    //cmd.ExecuteNonQuery();
                    //cn.Close();
                    //cn.Dispose();
                    string khoa = "select * from KHOA";
                    csdl csdl = new csdl();
                    string sql = "UPDATE KHOA set TenKhoa =  N'" + tbTenKhoa.Text.ToString() + "', SDT = N' " + tbSDT.Text.ToString() + "' WHERE MaKhoa = N'" + tbMaKhoa.Text.ToString() + "'";
                    csdl.Them(sql);
                    csdl.KetNoi();
                    dtgKhoa.DataSource = csdl.GetData(khoa);

                }

                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCapNhap2_Click(object sender, EventArgs e)
        {

            DialogResult key = MessageBox.Show("Bạn có muốn cập nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    string sql = "UPDATE LOP set SiSo = N'" 
                        + tbSiSo2.Text.ToString() + 
                        "', MaKhoa =N'" + cboKhoa2.SelectedValue.ToString() 
                        + "',TenLop= N'" + tbKhoaL2.Text.ToString() + tbLop2.Text.ToString() + " " + tbNganh2.Text.ToString() 
                        + "'where MaLop = '" + dtgLop[0, dtgLop.CurrentRow.Index].Value.ToString() + "'";
                    csdl csdl = new csdl();
                    csdl.Them(sql);
                    csdl.KetNoi();
                    string lop = "select * from LOP where MaKhoa = " + "'" + cboKhoa2.SelectedValue.ToString() + "'";
                    dtgLop.DataSource = csdl.GetData(lop);
                }

                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCapNhap3_Click(object sender, EventArgs e)
        {
            {
                DialogResult key = MessageBox.Show("Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (key == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "update SINHVIEN set MaLop = N'" + cboLop1.SelectedValue.ToString() +
                                                                    "', TenSV =N' " + tbHoTen3.Text.ToString() + "',GioiTinh = N'" + (radioButton1.Checked == true ? "True" : "False") +
                                                                    "',NgaySinh = N'" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "',SDT = N'" + tbSDT3.Text.ToString() 
                                                                    + "' where MaSV = '"+ dtgSinhVien[0, dtgSinhVien.CurrentRow.Index].Value.ToString() + "'";
                        csdl csdl = new csdl();
                        csdl.Them(sql);
                        csdl.KetNoi();
                        string sinhvien = "select * from SINHVIEN where MaLop = " + "'" + cboLop1.SelectedValue.ToString() + "'";
                        dtgSinhVien.DataSource = csdl.GetData(sinhvien);
                    }

                    catch (Exception LOI)
                    {
                        MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnXoa3_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE SINHVIEN where MaSV = '" + dtgSinhVien[0, dtgSinhVien.CurrentRow.Index].Value.ToString() + "'";
                    csdl csdl = new csdl();
                    csdl.Them(sql);
                    csdl.KetNoi();
                    string sinhvien = "select * from SinhVien where MaLop = " + "'" + cboLop1.SelectedValue.ToString() + "'";
                    dtgSinhVien.DataSource = csdl.GetData(sinhvien);
                }

                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE KHOA where MaKhoa = '" + tbMaKhoa.Text.ToString() + "'";
                    csdl csdl = new csdl();
                    csdl.Them(sql);
                    csdl.KetNoi();
                    string khoa = "select * from Khoa ";
                    dtgKhoa.DataSource = csdl.GetData(khoa);
                    cboKhoa2.DataSource = csdl.GetData(khoa);
                    cboKhoa2.DisplayMember = "TenKhoa";
                    cboKhoa2.ValueMember = "MaKhoa";
                    cboKhoa3.DataSource = csdl.GetData(khoa);
                    cboKhoa3.DisplayMember = "TenKhoa";
                    cboKhoa3.ValueMember = "MaKhoa";
                }

                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (key == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE LOP where MaLop = '" + dtgLop[0, dtgLop.CurrentRow.Index].Value.ToString() + "'";
                    csdl csdl = new csdl();
                    csdl.Them(sql);
                    csdl.KetNoi();
                    string lop = "select * from LOP where MaKhoa = " + "'" + cboKhoa2.SelectedValue.ToString() + "'";
                    dtgLop.DataSource = csdl.GetData(lop);
                }

                catch (Exception LOI)
                {
                    MessageBox.Show(LOI.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tbHoTen3_TextChanged(object sender, EventArgs e)
        {
            btnSave3.Enabled = true;
        }

        private void tbKhoaL2_TextChanged(object sender, EventArgs e)
        {
            btnSave2.Enabled = true;
        }

        private void tbMaKhoa_TextChanged(object sender, EventArgs e)
        {
            btnSave3.Enabled = true;
        }
    }
}
