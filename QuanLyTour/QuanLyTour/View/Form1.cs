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
using QuanLyTour.Model;
using QuanLyTour.Models;

namespace QuanLyTour
{
    public partial class Form1 : Form
    {
        //     QuanLyTourEntities db = new QuanLyTourEntities();
      
        List<DoanDuLichModel> allDoanDuLichs;
        List<KhachHangModel> allKhachHangs;
        List<NhanVienModel> allNhanViens;
        List<PhanBoNhanVienModel> allPhanBos;
        List<ChiTietDoanModel> allChiTietDoans;
        List<TourDuLichModel> allTours;
        List<ThamQuanModel> allThamQuans;
        List<GiaTourModel> allGias;
        int currentTourIndex;
        int currentDoanIndex;
        int currentKhachIndex;
        int currentGiaTourIndex;
        int currentNhanVienIndex;
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
            dtgvDoan.DataSource = allDoanDuLichs;
            dtgvDoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDoan.Columns["TourDuLich"].Visible = false;
            dtgvDoan.Columns["NoiDungTour"].Visible = false;

            allKhachHangs = KhachHangModel.GetAll();
            dtgvKhach.DataSource = allKhachHangs;

            allNhanViens = NhanVienModel.GetAll();
            dtgvNhanVien.DataSource = allNhanViens;

            allPhanBos = PhanBoNhanVienModel.GetAll();
            dtgvPhanBoNhanVien.DataSource = allPhanBos;
            dtgvPhanBoNhanVien.Columns["MaNhanVien"].Visible = false;
            dtgvPhanBoNhanVien.Columns["NhanVien"].Visible = false;
            dtgvPhanBoNhanVien.Columns["DoanDuLich"].Visible = false;
            dtgvPhanBoNhanVien.Columns["MaTour"].Visible = false;


            allChiTietDoans = ChiTietDoanModel.GetAll();
            dtgvChiTietDoan.DataSource = allChiTietDoans;
            dtgvChiTietDoan.Columns["DoanDuLich"].Visible = false;
            dtgvChiTietDoan.Columns["KhachHang"].Visible = false;
            //        dtgvChiTietDoan.Columns["MaDoan"].Visible = false;

            // tour
            allTours = TourDuLichModel.GetAll();
            dtgvTour.DataSource = allTours;
            dtgvTour.Columns["MaLoaiHinh"].Visible = false;
            dtgvTour.Columns["LoaiHinhDuLich"].Visible = false;

            // tham quan
            allThamQuans = ThamQuanModel.GetAll();
            dtgvThamQuan.DataSource = allThamQuans;
            dtgvThamQuan.Columns["DiaDiem"].Visible = false;

            // giá tour
            allGias = GiaTourModel.GetAll();
            dtgvGiaTour.DataSource = allGias;
            dtgvGiaTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbBangGia_Click(object sender, EventArgs e)
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
 //           doan.NoiDungTour = new ndTourModel(txtHanhTrinh.Text, txtKhachSan.Text, txtDiaDiem.Text);


            if (doan.InsertToDB() == true)
            {
                MessageBox.Show("Thêm thành công");
                allDoanDuLichs.Add(doan);
                dtgvDoan.DataSource = null;
                dtgvDoan.DataSource = allDoanDuLichs;

                dtgvDoan.Columns["TourDuLich"].Visible = false;
                dtgvDoan.Columns["NoiDungTour"].Visible = false;

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
                allDoanDuLichs.RemoveAt(currentDoanIndex);
                dtgvDoan.DataSource = null;
                dtgvDoan.DataSource = allDoanDuLichs;

                dtgvDoan.Columns["TourDuLich"].Visible = false;
                dtgvDoan.Columns["NoiDungTour"].Visible = false;
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dtgvChiTietTour_SelectionChanged(object sender, EventArgs e)
        {
            currentDoanIndex = dtgvDoan.CurrentCell.RowIndex;

            // update current tour details
            var doan = allDoanDuLichs[currentDoanIndex];
            if (doan != null)
            {
                txtMaDoan.Text = doan.MaDoan;
                //cbLoaiTour.SelectedValue = tour.MaLoai;
                txtMaTour1.Text = doan.MaTour;
                txtNgayKH.Text = doan.NgayKhoiHanh.ToString();
                txtNgayKT.Text = doan.NgayKetThuc.ToString();
/*                txtHanhTrinh.Text = doan.HanhTrinh;
                txtKhachSan.Text = doan.KhachSan;
                txtDiaDiem.Text = doan.DiaDiemThamQuan;*/
            }

        }

        private void dtgvChiTietTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuaChiTietTour_Click(object sender, EventArgs e)
        {
            var doan = allDoanDuLichs[currentDoanIndex];
            doan.MaDoan = txtMaDoan.Text;
            doan.MaTour = txtMaTour1.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtNgayKH.Text);
            doan.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);
 //           doan.NoiDungTour = new ndTourModel(txtHanhTrinh.Text, txtKhachSan.Text, txtDiaDiem.Text);



            if (doan.UpdateToDB())
            {
                MessageBox.Show("Sửa thành công");
                dtgvDoan.DataSource = null;
                dtgvDoan.DataSource = allDoanDuLichs;
                dtgvDoan.Columns["TourDuLich"].Visible = false;
                dtgvDoan.Columns["NoiDungTour"].Visible = false;
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }


            // refresh GUI
            dtgvDoan.DataSource = null;
            dtgvDoan.DataSource = allDoanDuLichs;//TourBUS.GetAll();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        
        }

        private void lbTourDuLich_Click(object sender, EventArgs e)
        {
            panelTour.Show();
            panelKhach.Hide();
            panelDoanDuLich.Hide();
            panelNhanVien.Hide();
            panelGiaTour.Hide();

        }

        private void panelTour_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            KhachHangModel kh = new KhachHangModel();
            kh.MaKhachHang = txtMaKhach.Text;
            kh.HoTen = txtHoTen.Text;
            kh.SoCMND = txtCMND.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.GioiTinh = txtGioiTinh.Text;
            kh.SDT = txtSoDT.Text;
            kh.QuocTich = txtQuocTich.Text;




            if (kh.InserToDB() == true)
            {
                MessageBox.Show("Thêm thành công");
                allKhachHangs.Add(kh);
                dtgvKhach.DataSource = null;
                dtgvKhach.DataSource = allKhachHangs;

                

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnXoaKhach_Click(object sender, EventArgs e)
        {
            string id = txtMaKhach.Text;

            if (KhachHangModel.DeleteToDB(id))
            {
                MessageBox.Show("Xóa thành công");
                allKhachHangs.RemoveAt(currentKhachIndex);
                dtgvKhach.DataSource = null;
                dtgvKhach.DataSource = allKhachHangs;

            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSuaKhach_Click(object sender, EventArgs e)
        {
            var kh = allKhachHangs[currentKhachIndex];
            kh.MaKhachHang = txtMaKhach.Text;
            kh.HoTen = txtHoTen.Text;
            kh.SoCMND = txtCMND.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.GioiTinh = txtGioiTinh.Text;
            kh.SDT = txtSoDT.Text;
            kh.QuocTich = txtQuocTich.Text;

            if (kh.UpdateToDB())
            {
                MessageBox.Show("Sửa thành công");
                dtgvKhach.DataSource = null;
                dtgvKhach.DataSource = allKhachHangs;
              
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        private void lbKhachHang_Click(object sender, EventArgs e)
        {
            panelKhach.Show();
            panelDoanDuLich.Hide();
            panelNhanVien.Hide();
            panelTour.Hide();
            panelGiaTour.Hide();
        }

        private void lbTenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            panelNhanVien.Show();
            panelDoanDuLich.Hide();
            panelKhach.Hide();
            panelTour.Hide();
            panelGiaTour.Hide();
        }

        private void lbDoanDuLich_Click_1(object sender, EventArgs e)
        {
            panelDoanDuLich.Show();
            panelNhanVien.Hide();
            panelKhach.Hide();
            panelTour.Hide();
            panelGiaTour.Hide();
        }

        private void dtgvChiTietDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvChiTietTour_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void dtgvDoan_SelectionChanged(object sender, EventArgs e)
        {
            currentDoanIndex = dtgvDoan.CurrentCell.RowIndex;

            // update current tour details
            var doan = allDoanDuLichs[currentDoanIndex];
            if (doan != null)
            {
                txtMaDoan.Text = doan.MaDoan.ToString();
                txtMaTour1.Text = doan.MaTour.ToString();
                txtNgayKH.Text = doan.NgayKhoiHanh.ToString();
                txtNgayKT.Text = doan.NgayKetThuc.ToString();
            //    txtHanhTrinh.Text = doan.HanhTrinh.ToString();
            //    txtKhachSan.Text = doan.KhachSan.ToString();
            //    txtDiaDiem.Text = doan.DiaDiemThamQuan.ToString();
            }
        }

        private void btnThemChiTietTour_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThemDoan_Click_1(object sender, EventArgs e)
        {
            DoanDuLichModel doan = new DoanDuLichModel();
            doan.MaDoan = txtMaDoan.Text;
            doan.MaTour = txtMaTour1.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtNgayKH.Text);
            doan.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);
    //        doan.NoiDungTour = new ndTourModel(txtHanhTrinh.Text, txtKhachSan.Text, txtDiaDiem.Text);


            if (doan.InsertToDB() == true)
            {
                MessageBox.Show("Thêm thành công");
                allDoanDuLichs.Add(doan);
                dtgvDoan.DataSource = null;
                dtgvDoan.DataSource = allDoanDuLichs;

                dtgvDoan.Columns["TourDuLich"].Visible = false;
                dtgvDoan.Columns["NoiDungTour"].Visible = false;

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }

        private void btnXoaDoan_Click(object sender, EventArgs e)
        {
            string id = txtMaDoan.Text;

            if (DoanDuLichModel.DeleteToDB(id))
            {
                MessageBox.Show("Xóa thành công");
                allDoanDuLichs.RemoveAt(currentDoanIndex);
                dtgvDoan.DataSource = null;
                dtgvDoan.DataSource = allDoanDuLichs;

                dtgvDoan.Columns["TourDuLich"].Visible = false;
                dtgvDoan.Columns["NoiDungTour"].Visible = false;
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSuaDoan_Click(object sender, EventArgs e)
        {
            var doan = allDoanDuLichs[currentDoanIndex];
            doan.MaDoan = txtMaDoan.Text;
            doan.MaTour = txtMaTour1.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtNgayKH.Text);
            doan.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);
 //           doan.NoiDungTour = new ndTourModel(txtHanhTrinh.Text, txtKhachSan.Text, txtDiaDiem.Text);



            if (doan.UpdateToDB())
            {
                MessageBox.Show("Sửa thành công");
                dtgvDoan.DataSource = null;
                dtgvDoan.DataSource = allDoanDuLichs;
                dtgvDoan.Columns["TourDuLich"].Visible = false;
                dtgvDoan.Columns["NoiDungTour"].Visible = false;
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        private void dtgvKhach_SelectionChanged(object sender, EventArgs e)
        {
            currentKhachIndex = dtgvKhach.CurrentCell.RowIndex;

            // update current tour details
            var khach = allKhachHangs[currentKhachIndex];
            if (khach != null)
            {
                txtMaKhach.Text = khach.MaKhachHang.ToString();
                txtHoTen.Text = khach.HoTen.ToString();
                txtCMND.Text = khach.SoCMND.ToString();
                txtDiaChi.Text = khach.DiaChi.ToString();
                txtGioiTinh.Text = khach.GioiTinh.ToString();
                txtSoDT.Text = khach.SDT.ToString();
                txtQuocTich.Text = khach.QuocTich.ToString();

            }
        }

        private void txtNgayKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelDoanDuLich_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtgvThamQuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            panelGiaTour.Show();
            panelNhanVien.Hide();
            panelDoanDuLich.Hide();
            panelKhach.Hide();
            panelTour.Hide();
            
        }

        private void dtgvGiaTour_SelectionChanged(object sender, EventArgs e)
        {
            currentGiaTourIndex = dtgvGiaTour.CurrentCell.RowIndex;

            // update current tour details
            var gia = allGias[currentGiaTourIndex];
            if (gia != null)
            {
                txtMaGia.Text = gia.MaGia.ToString();
                txtMaTour_Gia.Text = gia.MaTour.ToString();
                txtThanhTien.Text = gia.GiaTien.ToString();
                txtThoiGianBD.Text = gia.ThoiGianBatDau.ToString();
                txtThoiGianKT.Text = gia.ThoiGianKetThuc.ToString();

            }
        }

        private void dtgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            currentNhanVienIndex = dtgvNhanVien.CurrentCell.RowIndex;

            // update current tour details
            var nv = allNhanViens[currentNhanVienIndex];
            if (nv != null)
            {
                txtMaNhanVien.Text = nv.MaNhanVien.ToString();
                txtTenNhanVien.Text = nv.TenNhanVien.ToString();;

            }

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {

        }
    }
}
