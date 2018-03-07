namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgKhoa = new System.Windows.Forms.DataGridView();
            this.sINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QuanLySinhVien.QuanLySinhVienDataSetTableAdapters.SINHVIENTableAdapter();
            this.cboKhoa1 = new System.Windows.Forms.ComboBox();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tenbang = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLop = new System.Windows.Forms.Button();
            this.dtgLop = new System.Windows.Forms.DataGridView();
            this.cboKhoa2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.dtgSinhVien = new System.Windows.Forms.DataGridView();
            this.cboLop1 = new System.Windows.Forms.ComboBox();
            this.cboKhoa3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLop)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgKhoa
            // 
            this.dtgKhoa.AllowUserToOrderColumns = true;
            this.dtgKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgKhoa.Location = new System.Drawing.Point(3, 35);
            this.dtgKhoa.Name = "dtgKhoa";
            this.dtgKhoa.Size = new System.Drawing.Size(536, 211);
            this.dtgKhoa.TabIndex = 0;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // cboKhoa1
            // 
            this.cboKhoa1.FormattingEnabled = true;
            this.cboKhoa1.Items.AddRange(new object[] {
            "KHOA",
            "LỚP",
            "SINH VIÊN"});
            this.cboKhoa1.Location = new System.Drawing.Point(73, 6);
            this.cboKhoa1.Name = "cboKhoa1";
            this.cboKhoa1.Size = new System.Drawing.Size(121, 21);
            this.cboKhoa1.TabIndex = 1;
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(218, 6);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnKhoa.TabIndex = 2;
            this.btnKhoa.Text = "Hiển thị";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 275);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tenbang);
            this.tabPage1.Controls.Add(this.cboKhoa1);
            this.tabPage1.Controls.Add(this.btnKhoa);
            this.tabPage1.Controls.Add(this.dtgKhoa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khoa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tenbang
            // 
            this.tenbang.AutoSize = true;
            this.tenbang.Location = new System.Drawing.Point(4, 9);
            this.tenbang.Name = "tenbang";
            this.tenbang.Size = new System.Drawing.Size(40, 13);
            this.tenbang.TabIndex = 3;
            this.tenbang.Text = "KHOA:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnLop);
            this.tabPage2.Controls.Add(this.dtgLop);
            this.tabPage2.Controls.Add(this.cboKhoa2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KHOA:";
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(195, 4);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(75, 23);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "Ok";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgLop
            // 
            this.dtgLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgLop.Location = new System.Drawing.Point(3, 33);
            this.dtgLop.Name = "dtgLop";
            this.dtgLop.Size = new System.Drawing.Size(536, 213);
            this.dtgLop.TabIndex = 1;
            // 
            // cboKhoa2
            // 
            this.cboKhoa2.FormattingEnabled = true;
            this.cboKhoa2.Location = new System.Drawing.Point(68, 6);
            this.cboKhoa2.Name = "cboKhoa2";
            this.cboKhoa2.Size = new System.Drawing.Size(121, 21);
            this.cboKhoa2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnSinhVien);
            this.tabPage3.Controls.Add(this.dtgSinhVien);
            this.tabPage3.Controls.Add(this.cboLop1);
            this.tabPage3.Controls.Add(this.cboKhoa3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(542, 249);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sinh Viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LỚP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "KHOA:";
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Location = new System.Drawing.Point(346, 17);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(75, 23);
            this.btnSinhVien.TabIndex = 3;
            this.btnSinhVien.Text = "OK";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgSinhVien
            // 
            this.dtgSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgSinhVien.Location = new System.Drawing.Point(3, 46);
            this.dtgSinhVien.Name = "dtgSinhVien";
            this.dtgSinhVien.Size = new System.Drawing.Size(536, 200);
            this.dtgSinhVien.TabIndex = 2;
            // 
            // cboLop1
            // 
            this.cboLop1.FormattingEnabled = true;
            this.cboLop1.Location = new System.Drawing.Point(219, 19);
            this.cboLop1.Name = "cboLop1";
            this.cboLop1.Size = new System.Drawing.Size(121, 21);
            this.cboLop1.TabIndex = 1;
            // 
            // cboKhoa3
            // 
            this.cboKhoa3.FormattingEnabled = true;
            this.cboKhoa3.Location = new System.Drawing.Point(54, 19);
            this.cboKhoa3.Name = "cboKhoa3";
            this.cboKhoa3.Size = new System.Drawing.Size(121, 21);
            this.cboKhoa3.TabIndex = 0;
            this.cboKhoa3.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 275);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLop)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgKhoa;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QuanLySinhVienDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource1;
        private System.Windows.Forms.ComboBox cboKhoa1;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.DataGridView dtgLop;
        private System.Windows.Forms.ComboBox cboKhoa2;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.DataGridView dtgSinhVien;
        private System.Windows.Forms.ComboBox cboLop1;
        private System.Windows.Forms.ComboBox cboKhoa3;
        private System.Windows.Forms.Label tenbang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

