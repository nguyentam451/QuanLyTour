using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyTour;
using Model;
using QuanLyTour.Model;
using QuanLyTour.Models;

namespace QuanLyTour
{
    public partial class Form1 : Form
    {
        //     QuanLyTourEntities db = new QuanLyTourEntities();
      
        List<DoanDuLichModel> allDoanDuLichs;
        int currentIndex;
        public Form1()
        {
            InitializeComponent();
        }

        #region methods
        void LoadData()
        {
          //  using (QuanLyTourEntities db = new QuanLyTourEntities())
           /* {

                var result = from u in db.TOURDULICH
                             select new
                             {
                                 MaTour = u.MaTour,
                                 TenTour = u.TenGoi,
                                 DacDiem = u.DacDiem,
                                 TenLoaiHinh = u.LOAIHINHDULICH.TenLoaiHinh,

                             };
                dataGridViewTourDuLich.DataSource = result.ToList();

            }    
               

            dataGridViewTourDuLich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/
        }

        void AddBinding()
        {

        }

        void addTour()
        {
           // using (QuanLyTourEntities db = new QuanLyTourEntities())
          /*  {
                
                db.TOURDULICH.Add(new TOURDULICH() 
                { MaTour = txtMaTour.Text, 
                  TenGoi = txtTenTour.Text,
                  DacDiem = txtDacDiem.Text,
                  MaLoaiHinh = "MLH1"});

                db.SaveChanges();

                MessageBox.Show("Thêm thành công");
                LoadData();
            }*/
        }
        void deleteTour()
        {
          /*  String id = txtMaTour.Text;
            TOURDULICH tour = db.TOURDULICH.Where(p => p.MaTour == id).SingleOrDefault();
            db.TOURDULICH.Remove(tour);
    

            db.SaveChanges();

            MessageBox.Show("Xóa thành công");
            LoadData();*/
        }

        void updateTour()
        {
          /*  String id = txtMaTour.Text;
            TOURDULICH tour = db.TOURDULICH.Where(p => p.MaTour == id).SingleOrDefault();
            tour.MaTour = txtMaTour.Text;
            tour.TenGoi = txtTenTour.Text;
            tour.DacDiem = txtDacDiem.Text;

            db.SaveChanges();
            MessageBox.Show("Sửa thành công");
            LoadData();*/

        }
        #endregion 
        private void Form1_Load(object sender, EventArgs e)
        {

            allDoanDuLichs = DoanDuLichModel.GetAll();
            dtgvChiTietTour.DataSource = allDoanDuLichs;
            //   dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChiTietTour.Columns["TourDuLich"].Visible = false;
            dtgvChiTietTour.Columns["NoiDungTour"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
       //     addTour();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        //    deleteTour();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        //    updateTour();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbDacDiem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
               
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbQuanLyKhach_Click(object sender, EventArgs e)
        {

        }

        private void lbTrangChu_Click(object sender, EventArgs e)
        {
           // tabControl1.Dispose();
           
        }

        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbBangGia_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

                dtgvChiTietTour.Columns["TourDuLich"].Visible = false;
                dtgvChiTietTour.Columns["NoiDungTour"].Visible = false;

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }

        private void btnXoaChiTietTour_Click(object sender, EventArgs e)
        {
            string id = txtMaDoan.Text;

            if (DoanDuLichModel.DeleteToDB(id))
            {
                MessageBox.Show("Xóa thành công");
                allDoanDuLichs.RemoveAt(currentIndex);
                dtgvChiTietTour.DataSource = null;
                dtgvChiTietTour.DataSource = allDoanDuLichs;

                dtgvChiTietTour.Columns["TourDuLich"].Visible = false;
                dtgvChiTietTour.Columns["NoiDungTour"].Visible = false;
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

        private void dtgvChiTietTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuaChiTietTour_Click(object sender, EventArgs e)
        {
            var doan = allDoanDuLichs[currentIndex];
            doan.MaDoan = txtMaDoan.Text;
            doan.MaTour = txtMaTour1.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtNgayKH.Text);
            doan.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);
            doan.NoiDungTour = new ndTourModel(txtHanhTrinh.Text, txtKhachSan.Text, txtDiaDiem.Text);



            if (doan.UpdateToDB())
            {
                MessageBox.Show("Sửa thành công");
                dtgvChiTietTour.DataSource = null;
                dtgvChiTietTour.DataSource = allDoanDuLichs;
                dtgvChiTietTour.Columns["TourDuLich"].Visible = false;
                dtgvChiTietTour.Columns["NoiDungTour"].Visible = false;
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }


            // refresh GUI
            dtgvChiTietTour.DataSource = null;
            dtgvChiTietTour.DataSource = allDoanDuLichs;//TourBUS.GetAll();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            panelDoanDuLich.Show();
            panelTour.Hide();
        }

        private void lbTourDuLich_Click(object sender, EventArgs e)
        {
            panelTour.Show();
            panelDoanDuLich.Hide();
        }
    }
}
