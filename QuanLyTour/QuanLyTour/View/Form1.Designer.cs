
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
            this.lbTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDoanDuLich = new System.Windows.Forms.Label();
            this.lbTourDuLich = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDoanDuLich = new System.Windows.Forms.Panel();
            this.btnSuaChiTietTour = new System.Windows.Forms.Button();
            this.btnXoaChiTietTour = new System.Windows.Forms.Button();
            this.btnThemChiTietTour = new System.Windows.Forms.Button();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtKhachSan = new System.Windows.Forms.TextBox();
            this.txtHanhTrinh = new System.Windows.Forms.TextBox();
            this.txtNgayKT = new System.Windows.Forms.TextBox();
            this.txtNgayKH = new System.Windows.Forms.TextBox();
            this.txtMaTour1 = new System.Windows.Forms.TextBox();
            this.txtMaDoan = new System.Windows.Forms.TextBox();
            this.lbDiaDiem = new System.Windows.Forms.Label();
            this.lbKhachSan = new System.Windows.Forms.Label();
            this.lbHanhTrinh = new System.Windows.Forms.Label();
            this.lbNgayKT = new System.Windows.Forms.Label();
            this.lbNgayKH = new System.Windows.Forms.Label();
            this.lbMaTour1 = new System.Windows.Forms.Label();
            this.lbMaDoan = new System.Windows.Forms.Label();
            this.dtgvChiTietTour = new System.Windows.Forms.DataGridView();
            this.panelTour = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelDoanDuLich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietTour)).BeginInit();
            this.panelTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.Color.SlateBlue;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTittle.Location = new System.Drawing.Point(280, 33);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(1223, 60);
            this.lbTittle.TabIndex = 6;
            this.lbTittle.Text = "Quản lý tour du lịch";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.lbDoanDuLich);
            this.panel1.Controls.Add(this.lbTourDuLich);
            this.panel1.Location = new System.Drawing.Point(29, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 772);
            this.panel1.TabIndex = 15;
            // 
            // lbDoanDuLich
            // 
            this.lbDoanDuLich.BackColor = System.Drawing.Color.SlateGray;
            this.lbDoanDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanDuLich.ForeColor = System.Drawing.Color.White;
            this.lbDoanDuLich.Location = new System.Drawing.Point(3, 113);
            this.lbDoanDuLich.Name = "lbDoanDuLich";
            this.lbDoanDuLich.Size = new System.Drawing.Size(239, 71);
            this.lbDoanDuLich.TabIndex = 3;
            this.lbDoanDuLich.Text = "Đoàn du lịch";
            this.lbDoanDuLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDoanDuLich.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbTourDuLich
            // 
            this.lbTourDuLich.BackColor = System.Drawing.Color.SkyBlue;
            this.lbTourDuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTourDuLich.ForeColor = System.Drawing.Color.White;
            this.lbTourDuLich.Location = new System.Drawing.Point(3, 10);
            this.lbTourDuLich.Name = "lbTourDuLich";
            this.lbTourDuLich.Size = new System.Drawing.Size(239, 71);
            this.lbTourDuLich.TabIndex = 2;
            this.lbTourDuLich.Text = "Tour du lịch";
            this.lbTourDuLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTourDuLich.Click += new System.EventHandler(this.lbTourDuLich_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Image = global::QuanLyTour.Properties.Resources.flight__1___1_;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 133);
            this.label1.TabIndex = 17;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDoanDuLich
            // 
            this.panelDoanDuLich.BackColor = System.Drawing.Color.GhostWhite;
            this.panelDoanDuLich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDoanDuLich.Controls.Add(this.btnSuaChiTietTour);
            this.panelDoanDuLich.Controls.Add(this.btnXoaChiTietTour);
            this.panelDoanDuLich.Controls.Add(this.btnThemChiTietTour);
            this.panelDoanDuLich.Controls.Add(this.txtDiaDiem);
            this.panelDoanDuLich.Controls.Add(this.txtKhachSan);
            this.panelDoanDuLich.Controls.Add(this.txtHanhTrinh);
            this.panelDoanDuLich.Controls.Add(this.txtNgayKT);
            this.panelDoanDuLich.Controls.Add(this.txtNgayKH);
            this.panelDoanDuLich.Controls.Add(this.txtMaTour1);
            this.panelDoanDuLich.Controls.Add(this.txtMaDoan);
            this.panelDoanDuLich.Controls.Add(this.lbDiaDiem);
            this.panelDoanDuLich.Controls.Add(this.lbKhachSan);
            this.panelDoanDuLich.Controls.Add(this.lbHanhTrinh);
            this.panelDoanDuLich.Controls.Add(this.lbNgayKT);
            this.panelDoanDuLich.Controls.Add(this.lbNgayKH);
            this.panelDoanDuLich.Controls.Add(this.lbMaTour1);
            this.panelDoanDuLich.Controls.Add(this.lbMaDoan);
            this.panelDoanDuLich.Controls.Add(this.dtgvChiTietTour);
            this.panelDoanDuLich.Location = new System.Drawing.Point(280, 145);
            this.panelDoanDuLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDoanDuLich.Name = "panelDoanDuLich";
            this.panelDoanDuLich.Size = new System.Drawing.Size(1220, 698);
            this.panelDoanDuLich.TabIndex = 20;
            this.panelDoanDuLich.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnSuaChiTietTour
            // 
            this.btnSuaChiTietTour.Location = new System.Drawing.Point(953, 574);
            this.btnSuaChiTietTour.Name = "btnSuaChiTietTour";
            this.btnSuaChiTietTour.Size = new System.Drawing.Size(125, 37);
            this.btnSuaChiTietTour.TabIndex = 33;
            this.btnSuaChiTietTour.Text = "Sửa";
            this.btnSuaChiTietTour.UseVisualStyleBackColor = true;
            this.btnSuaChiTietTour.Click += new System.EventHandler(this.btnSuaChiTietTour_Click);
            // 
            // btnXoaChiTietTour
            // 
            this.btnXoaChiTietTour.Location = new System.Drawing.Point(635, 574);
            this.btnXoaChiTietTour.Name = "btnXoaChiTietTour";
            this.btnXoaChiTietTour.Size = new System.Drawing.Size(125, 37);
            this.btnXoaChiTietTour.TabIndex = 32;
            this.btnXoaChiTietTour.Text = "Xóa";
            this.btnXoaChiTietTour.UseVisualStyleBackColor = true;
            this.btnXoaChiTietTour.Click += new System.EventHandler(this.btnXoaChiTietTour_Click);
            // 
            // btnThemChiTietTour
            // 
            this.btnThemChiTietTour.Location = new System.Drawing.Point(287, 574);
            this.btnThemChiTietTour.Name = "btnThemChiTietTour";
            this.btnThemChiTietTour.Size = new System.Drawing.Size(125, 37);
            this.btnThemChiTietTour.TabIndex = 31;
            this.btnThemChiTietTour.Text = "Thêm";
            this.btnThemChiTietTour.UseVisualStyleBackColor = true;
            this.btnThemChiTietTour.Click += new System.EventHandler(this.btnThemChiTietTour_Click);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(102, 493);
            this.txtDiaDiem.Multiline = true;
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(159, 27);
            this.txtDiaDiem.TabIndex = 30;
            // 
            // txtKhachSan
            // 
            this.txtKhachSan.Location = new System.Drawing.Point(102, 416);
            this.txtKhachSan.Multiline = true;
            this.txtKhachSan.Name = "txtKhachSan";
            this.txtKhachSan.Size = new System.Drawing.Size(159, 27);
            this.txtKhachSan.TabIndex = 29;
            // 
            // txtHanhTrinh
            // 
            this.txtHanhTrinh.Location = new System.Drawing.Point(102, 333);
            this.txtHanhTrinh.Multiline = true;
            this.txtHanhTrinh.Name = "txtHanhTrinh";
            this.txtHanhTrinh.Size = new System.Drawing.Size(159, 27);
            this.txtHanhTrinh.TabIndex = 28;
            // 
            // txtNgayKT
            // 
            this.txtNgayKT.Location = new System.Drawing.Point(102, 253);
            this.txtNgayKT.Multiline = true;
            this.txtNgayKT.Name = "txtNgayKT";
            this.txtNgayKT.Size = new System.Drawing.Size(159, 27);
            this.txtNgayKT.TabIndex = 27;
            // 
            // txtNgayKH
            // 
            this.txtNgayKH.Location = new System.Drawing.Point(102, 174);
            this.txtNgayKH.Multiline = true;
            this.txtNgayKH.Name = "txtNgayKH";
            this.txtNgayKH.Size = new System.Drawing.Size(159, 27);
            this.txtNgayKH.TabIndex = 26;
            // 
            // txtMaTour1
            // 
            this.txtMaTour1.Location = new System.Drawing.Point(102, 94);
            this.txtMaTour1.Multiline = true;
            this.txtMaTour1.Name = "txtMaTour1";
            this.txtMaTour1.Size = new System.Drawing.Size(159, 27);
            this.txtMaTour1.TabIndex = 25;
            // 
            // txtMaDoan
            // 
            this.txtMaDoan.Location = new System.Drawing.Point(102, 28);
            this.txtMaDoan.Multiline = true;
            this.txtMaDoan.Name = "txtMaDoan";
            this.txtMaDoan.Size = new System.Drawing.Size(159, 27);
            this.txtMaDoan.TabIndex = 24;
            // 
            // lbDiaDiem
            // 
            this.lbDiaDiem.AutoSize = true;
            this.lbDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaDiem.Location = new System.Drawing.Point(12, 500);
            this.lbDiaDiem.Name = "lbDiaDiem";
            this.lbDiaDiem.Size = new System.Drawing.Size(78, 20);
            this.lbDiaDiem.TabIndex = 23;
            this.lbDiaDiem.Text = "Địa Điểm";
            // 
            // lbKhachSan
            // 
            this.lbKhachSan.AutoSize = true;
            this.lbKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachSan.Location = new System.Drawing.Point(8, 423);
            this.lbKhachSan.Name = "lbKhachSan";
            this.lbKhachSan.Size = new System.Drawing.Size(90, 20);
            this.lbKhachSan.TabIndex = 22;
            this.lbKhachSan.Text = "Khách Sạn";
            // 
            // lbHanhTrinh
            // 
            this.lbHanhTrinh.AutoSize = true;
            this.lbHanhTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHanhTrinh.Location = new System.Drawing.Point(8, 340);
            this.lbHanhTrinh.Name = "lbHanhTrinh";
            this.lbHanhTrinh.Size = new System.Drawing.Size(92, 20);
            this.lbHanhTrinh.TabIndex = 21;
            this.lbHanhTrinh.Text = "Hành Trình";
            // 
            // lbNgayKT
            // 
            this.lbNgayKT.AutoSize = true;
            this.lbNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKT.Location = new System.Drawing.Point(8, 260);
            this.lbNgayKT.Name = "lbNgayKT";
            this.lbNgayKT.Size = new System.Drawing.Size(73, 20);
            this.lbNgayKT.TabIndex = 20;
            this.lbNgayKT.Text = "Ngày KT";
            // 
            // lbNgayKH
            // 
            this.lbNgayKH.AutoSize = true;
            this.lbNgayKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKH.Location = new System.Drawing.Point(8, 181);
            this.lbNgayKH.Name = "lbNgayKH";
            this.lbNgayKH.Size = new System.Drawing.Size(76, 20);
            this.lbNgayKH.TabIndex = 19;
            this.lbNgayKH.Text = "Ngày KH";
            // 
            // lbMaTour1
            // 
            this.lbMaTour1.AutoSize = true;
            this.lbMaTour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour1.Location = new System.Drawing.Point(8, 101);
            this.lbMaTour1.Name = "lbMaTour1";
            this.lbMaTour1.Size = new System.Drawing.Size(71, 20);
            this.lbMaTour1.TabIndex = 18;
            this.lbMaTour1.Text = "Mã Tour";
            // 
            // lbMaDoan
            // 
            this.lbMaDoan.AutoSize = true;
            this.lbMaDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaDoan.Location = new System.Drawing.Point(5, 35);
            this.lbMaDoan.Name = "lbMaDoan";
            this.lbMaDoan.Size = new System.Drawing.Size(76, 20);
            this.lbMaDoan.TabIndex = 17;
            this.lbMaDoan.Text = "Mã Đoàn";
            // 
            // dtgvChiTietTour
            // 
            this.dtgvChiTietTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietTour.Location = new System.Drawing.Point(287, 28);
            this.dtgvChiTietTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvChiTietTour.Name = "dtgvChiTietTour";
            this.dtgvChiTietTour.RowHeadersWidth = 51;
            this.dtgvChiTietTour.RowTemplate.Height = 24;
            this.dtgvChiTietTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietTour.Size = new System.Drawing.Size(791, 492);
            this.dtgvChiTietTour.TabIndex = 0;
            this.dtgvChiTietTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChiTietTour_CellContentClick);
            this.dtgvChiTietTour.SelectionChanged += new System.EventHandler(this.dtgvChiTietTour_SelectionChanged);
            // 
            // panelTour
            // 
            this.panelTour.Controls.Add(this.dataGridView1);
            this.panelTour.Location = new System.Drawing.Point(280, 144);
            this.panelTour.Name = "panelTour";
            this.panelTour.Size = new System.Drawing.Size(1223, 772);
            this.panelTour.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 928);
            this.Controls.Add(this.panelTour);
            this.Controls.Add(this.panelDoanDuLich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTittle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelDoanDuLich.ResumeLayout(false);
            this.panelDoanDuLich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietTour)).EndInit();
            this.panelTour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDoanDuLich;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtKhachSan;
        private System.Windows.Forms.TextBox txtHanhTrinh;
        private System.Windows.Forms.TextBox txtNgayKT;
        private System.Windows.Forms.TextBox txtNgayKH;
        private System.Windows.Forms.TextBox txtMaTour1;
        private System.Windows.Forms.TextBox txtMaDoan;
        private System.Windows.Forms.Label lbDiaDiem;
        private System.Windows.Forms.Label lbKhachSan;
        private System.Windows.Forms.Label lbHanhTrinh;
        private System.Windows.Forms.Label lbNgayKT;
        private System.Windows.Forms.Label lbNgayKH;
        private System.Windows.Forms.Label lbMaTour1;
        private System.Windows.Forms.Label lbMaDoan;
        private System.Windows.Forms.DataGridView dtgvChiTietTour;
        private System.Windows.Forms.Button btnThemChiTietTour;
        private System.Windows.Forms.Button btnXoaChiTietTour;
        private System.Windows.Forms.Button btnSuaChiTietTour;
        private System.Windows.Forms.Label lbDoanDuLich;
        private System.Windows.Forms.Label lbTourDuLich;
        private System.Windows.Forms.Panel panelTour;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

