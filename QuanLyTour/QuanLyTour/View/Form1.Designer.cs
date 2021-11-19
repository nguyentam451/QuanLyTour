
namespace QuanLyTour
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
            this.dataGridViewTourDuLich = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.txtDacDiem = new System.Windows.Forms.TextBox();
            this.lbTenTour = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.lbDacDiem = new System.Windows.Forms.Label();
            this.lbMaLoaiHinh = new System.Windows.Forms.Label();
            this.txtMaLoaiHinh = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTour = new System.Windows.Forms.TabPage();
            this.tabPageChiTietTour = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPageKhach = new System.Windows.Forms.TabPage();
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.tabPageGia = new System.Windows.Forms.TabPage();
            this.dtgvGia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourDuLich)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTour.SuspendLayout();
            this.tabPageChiTietTour.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.tabPageGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTourDuLich
            // 
            this.dataGridViewTourDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourDuLich.Location = new System.Drawing.Point(9, 120);
            this.dataGridViewTourDuLich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTourDuLich.Name = "dataGridViewTourDuLich";
            this.dataGridViewTourDuLich.RowHeadersWidth = 51;
            this.dataGridViewTourDuLich.RowTemplate.Height = 24;
            this.dataGridViewTourDuLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTourDuLich.Size = new System.Drawing.Size(724, 343);
            this.dataGridViewTourDuLich.TabIndex = 0;
            this.dataGridViewTourDuLich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 470);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(156, 470);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(296, 470);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 30);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(650, 470);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(84, 30);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.Color.SlateBlue;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTittle.Location = new System.Drawing.Point(210, 27);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(824, 49);
            this.lbTittle.TabIndex = 6;
            this.lbTittle.Text = "Quản lý tour du lịch";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(6, 35);
            this.lbMaTour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(59, 18);
            this.lbMaTour.TabIndex = 7;
            this.lbMaTour.Text = "Mã tour";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(86, 29);
            this.txtMaTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaTour.Multiline = true;
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(126, 26);
            this.txtMaTour.TabIndex = 8;
            // 
            // txtDacDiem
            // 
            this.txtDacDiem.Location = new System.Drawing.Point(86, 76);
            this.txtDacDiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDacDiem.Multiline = true;
            this.txtDacDiem.Name = "txtDacDiem";
            this.txtDacDiem.Size = new System.Drawing.Size(126, 26);
            this.txtDacDiem.TabIndex = 9;
            // 
            // lbTenTour
            // 
            this.lbTenTour.AutoSize = true;
            this.lbTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTour.Location = new System.Drawing.Point(502, 35);
            this.lbTenTour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenTour.Name = "lbTenTour";
            this.lbTenTour.Size = new System.Drawing.Size(63, 18);
            this.lbTenTour.TabIndex = 10;
            this.lbTenTour.Text = "Tên tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(608, 29);
            this.txtTenTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTour.Multiline = true;
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(126, 26);
            this.txtTenTour.TabIndex = 11;
            // 
            // lbDacDiem
            // 
            this.lbDacDiem.AutoSize = true;
            this.lbDacDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDacDiem.Location = new System.Drawing.Point(6, 82);
            this.lbDacDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDacDiem.Name = "lbDacDiem";
            this.lbDacDiem.Size = new System.Drawing.Size(71, 18);
            this.lbDacDiem.TabIndex = 12;
            this.lbDacDiem.Text = "Đặc điểm";
            this.lbDacDiem.Click += new System.EventHandler(this.lbDacDiem_Click);
            // 
            // lbMaLoaiHinh
            // 
            this.lbMaLoaiHinh.AutoSize = true;
            this.lbMaLoaiHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiHinh.Location = new System.Drawing.Point(502, 82);
            this.lbMaLoaiHinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaLoaiHinh.Name = "lbMaLoaiHinh";
            this.lbMaLoaiHinh.Size = new System.Drawing.Size(92, 18);
            this.lbMaLoaiHinh.TabIndex = 13;
            this.lbMaLoaiHinh.Text = "Mã Loại hình";
            // 
            // txtMaLoaiHinh
            // 
            this.txtMaLoaiHinh.Location = new System.Drawing.Point(608, 76);
            this.txtMaLoaiHinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLoaiHinh.Multiline = true;
            this.txtMaLoaiHinh.Name = "txtMaLoaiHinh";
            this.txtMaLoaiHinh.Size = new System.Drawing.Size(126, 26);
            this.txtMaLoaiHinh.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Location = new System.Drawing.Point(22, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 567);
            this.panel1.TabIndex = 15;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(427, 468);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 31);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.txtTenTour);
            this.panel2.Controls.Add(this.lbMaLoaiHinh);
            this.panel2.Controls.Add(this.lbTenTour);
            this.panel2.Controls.Add(this.txtMaLoaiHinh);
            this.panel2.Controls.Add(this.dataGridViewTourDuLich);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.lbDacDiem);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.lbMaTour);
            this.panel2.Controls.Add(this.txtDacDiem);
            this.panel2.Controls.Add(this.txtMaTour);
            this.panel2.Location = new System.Drawing.Point(2, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 511);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTour);
            this.tabControl1.Controls.Add(this.tabPageChiTietTour);
            this.tabControl1.Controls.Add(this.tabPageKhach);
            this.tabControl1.Controls.Add(this.tabPageGia);
            this.tabControl1.Location = new System.Drawing.Point(214, 118);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 542);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPageTour
            // 
            this.tabPageTour.Controls.Add(this.panel2);
            this.tabPageTour.Location = new System.Drawing.Point(4, 22);
            this.tabPageTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTour.Name = "tabPageTour";
            this.tabPageTour.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTour.Size = new System.Drawing.Size(755, 516);
            this.tabPageTour.TabIndex = 0;
            this.tabPageTour.Text = "Tour du lịch";
            this.tabPageTour.UseVisualStyleBackColor = true;
            // 
            // tabPageChiTietTour
            // 
            this.tabPageChiTietTour.Controls.Add(this.panel3);
            this.tabPageChiTietTour.Location = new System.Drawing.Point(4, 22);
            this.tabPageChiTietTour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageChiTietTour.Name = "tabPageChiTietTour";
            this.tabPageChiTietTour.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageChiTietTour.Size = new System.Drawing.Size(755, 516);
            this.tabPageChiTietTour.TabIndex = 1;
            this.tabPageChiTietTour.Text = "Chi tiết tour";
            this.tabPageChiTietTour.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(-1, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 511);
            this.panel3.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 470);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(427, 468);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 31);
            this.textBox1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 470);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(802, 466);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 470);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 470);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPageKhach
            // 
            this.tabPageKhach.Controls.Add(this.dtgvKhachHang);
            this.tabPageKhach.Location = new System.Drawing.Point(4, 22);
            this.tabPageKhach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageKhach.Name = "tabPageKhach";
            this.tabPageKhach.Size = new System.Drawing.Size(755, 516);
            this.tabPageKhach.TabIndex = 2;
            this.tabPageKhach.Text = "Thông tin";
            this.tabPageKhach.UseVisualStyleBackColor = true;
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Location = new System.Drawing.Point(0, 103);
            this.dtgvKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.RowHeadersWidth = 51;
            this.dtgvKhachHang.RowTemplate.Height = 24;
            this.dtgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKhachHang.Size = new System.Drawing.Size(763, 410);
            this.dtgvKhachHang.TabIndex = 1;
            this.dtgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhachHang_CellContentClick);
            // 
            // tabPageGia
            // 
            this.tabPageGia.Controls.Add(this.dtgvGia);
            this.tabPageGia.Location = new System.Drawing.Point(4, 22);
            this.tabPageGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageGia.Name = "tabPageGia";
            this.tabPageGia.Size = new System.Drawing.Size(755, 516);
            this.tabPageGia.TabIndex = 3;
            this.tabPageGia.Text = "Bảng giá";
            this.tabPageGia.UseVisualStyleBackColor = true;
            // 
            // dtgvGia
            // 
            this.dtgvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGia.Location = new System.Drawing.Point(20, 53);
            this.dtgvGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvGia.Name = "dtgvGia";
            this.dtgvGia.RowHeadersWidth = 51;
            this.dtgvGia.RowTemplate.Height = 24;
            this.dtgvGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvGia.Size = new System.Drawing.Size(764, 439);
            this.dtgvGia.TabIndex = 2;
            this.dtgvGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGia_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Image = global::QuanLyTour.Properties.Resources.flight__1___1_;
            this.label1.Location = new System.Drawing.Point(55, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 108);
            this.label1.TabIndex = 17;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTittle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourDuLich)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTour.ResumeLayout(false);
            this.tabPageChiTietTour.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageKhach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.tabPageGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTourDuLich;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.TextBox txtDacDiem;
        private System.Windows.Forms.Label lbTenTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label lbDacDiem;
        private System.Windows.Forms.Label lbMaLoaiHinh;
        private System.Windows.Forms.TextBox txtMaLoaiHinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTour;
        private System.Windows.Forms.TabPage tabPageChiTietTour;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPageKhach;
        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.TabPage tabPageGia;
        private System.Windows.Forms.DataGridView dtgvGia;
    }
}

