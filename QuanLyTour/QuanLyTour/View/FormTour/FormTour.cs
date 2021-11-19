using QuanLyTour.Model;
using QuanLyTour.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTour.View.FormTour
{
    public partial class FormTour : Form
    {
        List<DoanDuLichModel> allDoanDuLichs;
        int currentIndex;
        public FormTour()
        {
            InitializeComponent();
        }
        void AddBindingDoanDuLich()
        {
            txtMaDoan.DataBindings.Add(new Binding("Text", dtgvChiTietTour.DataSource, "MaDoan"));
            txtMaTour1.DataBindings.Add(new Binding("Text", dtgvChiTietTour.DataSource, "MaTour"));
            txtNgayKH.DataBindings.Add(new Binding("Text", dtgvChiTietTour.DataSource, "NgayKhoiHanh"));
            txtNgayKT.DataBindings.Add(new Binding("Text", dtgvChiTietTour.DataSource, "NgayKetThuc"));
            txtHanhTrinh.DataBindings.Add(new Binding("Text", dtgvChiTietTour.DataSource, "HanhTrinh"));
            txtKhachSan.DataBindings.Add(new Binding("Text", dtgvChiTietTour.DataSource, "KhachSan"));
            txtDiaDiem.DataBindings.Add(new Binding("Text", dtgvChiTietTour.DataSource, "DiaDiemThamQuan"));
        }

        private void FormTour_Load(object sender, EventArgs e)
        {
            allDoanDuLichs = DoanDuLichModel.GetAll();
            dtgvChiTietTour.DataSource = allDoanDuLichs;
            //   dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChiTietTour.Columns["TourDuLich"].Visible = false;
            dtgvChiTietTour.Columns["NoiDungTour"].Visible = false;

        }

        private void dtgvChiTietTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPageChiTietTour_Click(object sender, EventArgs e)
        {

        }

        private void btnThemChiTietTour_Click(object sender, EventArgs e)
        {
            DoanDuLichModel doan = new DoanDuLichModel();
            doan.MaDoan = txtMaDoan.Text;
            doan.MaTour = txtMaTour1.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtNgayKH.Text);
            doan.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);
            doan.NoiDungTour = new ndTourModel(txtHanhTrinh.Text, txtKhachSan.Text, txtDiaDiem.Text);

            
            if (doan.InsertToDB() == true)
            {
                MessageBox.Show("Thêm thành công");
                allDoanDuLichs.Add(doan);
                dtgvChiTietTour.DataSource = null;
                dtgvChiTietTour.DataSource = allDoanDuLichs;

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
           

           



            /* Form1 c = new Form1();
             this.Hide();
             c.ShowDialog();
             this.Close();*/
        }

        private void btnXoaChiTietTour_Click(object sender, EventArgs e)
        {
            string id = txtMaDoan.Text;
          
            if (DoanDuLichModel.DeleteToDB(id))
            {
                MessageBox.Show("Xóa thành công");
                dtgvChiTietTour.DataSource = null;
                dtgvChiTietTour.DataSource = allDoanDuLichs;
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
          
        }

        private void dtgvChiTietTour_SelectionChanged(object sender, EventArgs e)
        {
            currentIndex = dtgvChiTietTour.CurrentCell.RowIndex;

            // update current tour details
            var doan = allDoanDuLichs[currentIndex];
            if (doan != null)
            {
                txtMaDoan.Text = doan.MaDoan;
                //cbLoaiTour.SelectedValue = tour.MaLoai;
                txtMaTour1.Text = doan.MaTour;
                txtNgayKH.Text = doan.NgayKhoiHanh.ToString();
                txtNgayKT.Text = doan.NgayKetThuc.ToString();
                txtHanhTrinh.Text = doan.HanhTrinh;
                txtKhachSan.Text = doan.KhachSan;
                txtDiaDiem.Text = doan.DiaDiemThamQuan;
            }
        }

        private void btnSuaChiTietTour_Click(object sender, EventArgs e)
        {

            var doan = allDoanDuLichs[currentIndex];
            doan.MaDoan = txtMaDoan.Text;
            doan.MaTour = txtMaTour.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtNgayKH.Text);
            doan.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);
            doan.NoiDungTour = new ndTourModel(txtHanhTrinh.Text, txtKhachSan.Text, txtDiaDiem.Text);



            if (doan.UpdateToDB())
            {
                MessageBox.Show("Sửa thành công");
                dtgvChiTietTour.DataSource = null;
                dtgvChiTietTour.DataSource = allDoanDuLichs;
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }


            // refresh GUI
            dtgvChiTietTour.DataSource = null;
            dtgvChiTietTour.DataSource = allDoanDuLichs;//TourBUS.GetAll();
        }
    }
}
