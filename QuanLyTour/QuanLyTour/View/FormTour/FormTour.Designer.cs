
namespace QuanLyTour.View.FormTour
{
    partial class FormTour
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTour = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.lbMaLoaiHinh = new System.Windows.Forms.Label();
            this.lbTenTour = new System.Windows.Forms.Label();
            this.txtMaLoaiHinh = new System.Windows.Forms.TextBox();
            this.dataGridViewTourDuLich = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbDacDiem = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.txtDacDiem = new System.Windows.Forms.TextBox();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.tabPageChiTietTour = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.tabControl1.SuspendLayout();
            this.tabPageTour.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourDuLich)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTour);
            this.tabControl1.Controls.Add(this.tabPageChiTietTour);
            this.tabControl1.Location = new System.Drawing.Point(26, 67);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 671);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPageTour
            // 
            this.tabPageTour.Controls.Add(this.panel2);
            this.tabPageTour.Location = new System.Drawing.Point(4, 25);
            this.tabPageTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTour.Name = "tabPageTour";
            this.tabPageTour.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTour.Size = new System.Drawing.Size(1034, 642);
            this.tabPageTour.TabIndex = 0;
            this.tabPageTour.Text = "Tour du lịch";
            this.tabPageTour.UseVisualStyleBackColor = true;
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 628);
            this.panel2.TabIndex = 18;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(867, 578);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 37);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(569, 576);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(263, 37);
            this.txtTimKiem.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(395, 578);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 37);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(811, 36);
            this.txtTenTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTour.Multiline = true;
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(167, 31);
            this.txtTenTour.TabIndex = 11;
            // 
            // lbMaLoaiHinh
            // 
            this.lbMaLoaiHinh.AutoSize = true;
            this.lbMaLoaiHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiHinh.Location = new System.Drawing.Point(669, 101);
            this.lbMaLoaiHinh.Name = "lbMaLoaiHinh";
            this.lbMaLoaiHinh.Size = new System.Drawing.Size(118, 24);
            this.lbMaLoaiHinh.TabIndex = 13;
            this.lbMaLoaiHinh.Text = "Mã Loại hình";
            // 
            // lbTenTour
            // 
            this.lbTenTour.AutoSize = true;
            this.lbTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTour.Location = new System.Drawing.Point(669, 43);
            this.lbTenTour.Name = "lbTenTour";
            this.lbTenTour.Size = new System.Drawing.Size(81, 24);
            this.lbTenTour.TabIndex = 10;
            this.lbTenTour.Text = "Tên tour";
            // 
            // txtMaLoaiHinh
            // 
            this.txtMaLoaiHinh.Location = new System.Drawing.Point(811, 94);
            this.txtMaLoaiHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLoaiHinh.Multiline = true;
            this.txtMaLoaiHinh.Name = "txtMaLoaiHinh";
            this.txtMaLoaiHinh.Size = new System.Drawing.Size(167, 31);
            this.txtMaLoaiHinh.TabIndex = 14;
            // 
            // dataGridViewTourDuLich
            // 
            this.dataGridViewTourDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourDuLich.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewTourDuLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTourDuLich.Name = "dataGridViewTourDuLich";
            this.dataGridViewTourDuLich.RowHeadersWidth = 51;
            this.dataGridViewTourDuLich.RowTemplate.Height = 24;
            this.dataGridViewTourDuLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTourDuLich.Size = new System.Drawing.Size(846, 422);
            this.dataGridViewTourDuLich.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(208, 578);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
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
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 578);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 37);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
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
            // txtDacDiem
            // 
            this.txtDacDiem.Location = new System.Drawing.Point(115, 94);
            this.txtDacDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDacDiem.Multiline = true;
            this.txtDacDiem.Name = "txtDacDiem";
            this.txtDacDiem.Size = new System.Drawing.Size(167, 31);
            this.txtDacDiem.TabIndex = 9;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(115, 36);
            this.txtMaTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTour.Multiline = true;
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(167, 31);
            this.txtMaTour.TabIndex = 8;
            // 
            // tabPageChiTietTour
            // 
            this.tabPageChiTietTour.Location = new System.Drawing.Point(4, 25);
            this.tabPageChiTietTour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageChiTietTour.Name = "tabPageChiTietTour";
            this.tabPageChiTietTour.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageChiTietTour.Size = new System.Drawing.Size(1034, 642);
            this.tabPageChiTietTour.TabIndex = 1;
            this.tabPageChiTietTour.Text = "Chi tiết tour";
            this.tabPageChiTietTour.UseVisualStyleBackColor = true;
            this.tabPageChiTietTour.Click += new System.EventHandler(this.tabPageChiTietTour_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // FormTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 749);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTour";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormTour_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTour.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourDuLich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label lbMaLoaiHinh;
        private System.Windows.Forms.Label lbTenTour;
        private System.Windows.Forms.TextBox txtMaLoaiHinh;
        private System.Windows.Forms.DataGridView dataGridViewTourDuLich;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbDacDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbMaTour;
        private System.Windows.Forms.TextBox txtDacDiem;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.TabPage tabPageChiTietTour;
        private System.Windows.Forms.Button button5;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}