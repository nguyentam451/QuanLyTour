
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbQuanLyTour = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourDuLich)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTourDuLich
            // 
            this.dataGridViewTourDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourDuLich.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewTourDuLich.Name = "dataGridViewTourDuLich";
            this.dataGridViewTourDuLich.RowHeadersWidth = 51;
            this.dataGridViewTourDuLich.RowTemplate.Height = 24;
            this.dataGridViewTourDuLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTourDuLich.Size = new System.Drawing.Size(965, 422);
            this.dataGridViewTourDuLich.TabIndex = 0;
            this.dataGridViewTourDuLich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 579);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 37);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(208, 579);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(394, 579);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 37);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(866, 579);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 37);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.Color.SlateBlue;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTittle.Location = new System.Drawing.Point(280, 33);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(994, 60);
            this.lbTittle.TabIndex = 6;
            this.lbTittle.Text = "Quản lý tour du lịch";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTour.Location = new System.Drawing.Point(8, 43);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(73, 24);
            this.lbMaTour.TabIndex = 7;
            this.lbMaTour.Text = "Mã tour";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(114, 36);
            this.txtMaTour.Multiline = true;
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(167, 31);
            this.txtMaTour.TabIndex = 8;
            // 
            // txtDacDiem
            // 
            this.txtDacDiem.Location = new System.Drawing.Point(114, 94);
            this.txtDacDiem.Multiline = true;
            this.txtDacDiem.Name = "txtDacDiem";
            this.txtDacDiem.Size = new System.Drawing.Size(167, 31);
            this.txtDacDiem.TabIndex = 9;
            // 
            // lbTenTour
            // 
            this.lbTenTour.AutoSize = true;
            this.lbTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTour.Location = new System.Drawing.Point(670, 43);
            this.lbTenTour.Name = "lbTenTour";
            this.lbTenTour.Size = new System.Drawing.Size(81, 24);
            this.lbTenTour.TabIndex = 10;
            this.lbTenTour.Text = "Tên tour";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(811, 36);
            this.txtTenTour.Multiline = true;
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(167, 31);
            this.txtTenTour.TabIndex = 11;
            // 
            // lbDacDiem
            // 
            this.lbDacDiem.AutoSize = true;
            this.lbDacDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDacDiem.Location = new System.Drawing.Point(8, 101);
            this.lbDacDiem.Name = "lbDacDiem";
            this.lbDacDiem.Size = new System.Drawing.Size(91, 24);
            this.lbDacDiem.TabIndex = 12;
            this.lbDacDiem.Text = "Đặc điểm";
            this.lbDacDiem.Click += new System.EventHandler(this.lbDacDiem_Click);
            // 
            // lbMaLoaiHinh
            // 
            this.lbMaLoaiHinh.AutoSize = true;
            this.lbMaLoaiHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiHinh.Location = new System.Drawing.Point(670, 101);
            this.lbMaLoaiHinh.Name = "lbMaLoaiHinh";
            this.lbMaLoaiHinh.Size = new System.Drawing.Size(118, 24);
            this.lbMaLoaiHinh.TabIndex = 13;
            this.lbMaLoaiHinh.Text = "Mã Loại hình";
            // 
            // txtMaLoaiHinh
            // 
            this.txtMaLoaiHinh.Location = new System.Drawing.Point(811, 94);
            this.txtMaLoaiHinh.Multiline = true;
            this.txtMaLoaiHinh.Name = "txtMaLoaiHinh";
            this.txtMaLoaiHinh.Size = new System.Drawing.Size(167, 31);
            this.txtMaLoaiHinh.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbQuanLyTour);
            this.panel1.Location = new System.Drawing.Point(29, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 670);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 71);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý khách ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbQuanLyTour
            // 
            this.lbQuanLyTour.BackColor = System.Drawing.Color.SkyBlue;
            this.lbQuanLyTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyTour.ForeColor = System.Drawing.Color.White;
            this.lbQuanLyTour.Location = new System.Drawing.Point(3, 10);
            this.lbQuanLyTour.Name = "lbQuanLyTour";
            this.lbQuanLyTour.Size = new System.Drawing.Size(239, 71);
            this.lbQuanLyTour.TabIndex = 0;
            this.lbQuanLyTour.Text = "Quản lý tour";
            this.lbQuanLyTour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(569, 576);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(262, 37);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 629);
            this.panel2.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(286, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 670);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 842);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourDuLich)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbQuanLyTour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

