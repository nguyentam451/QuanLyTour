using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTour.View.FormTour;
using QuanLyTour;
using QuanLyTour.Model;
using QuanLyTour.Models;
using QuanLyTour.View;
using System.IO;
using QuanLyTour.View.FormDoanDuLich;
using QuanLyTour.View.FormKhachHang;
using QuanLyTour.View.FormNhanVien;

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
        public List<TourDuLichModel> allTours;
        List<ThamQuanModel> allThamQuans;
        List<GiaTourModel> allGias;
        int currentTourIndex;
        int currentDoanIndex;
        int currentKhachIndex;
        int currentGiaTourIndex;
        int currentNhanVienIndex;

        // load data từ combobox
        // TOUR
        List<LoaiHinhDuLichModel> listLoaiHinh;
        List<DiaDiemModel> listDiaDiem;
        Dictionary<string, string> loaiHinh, diaDiem;
        
        // DOAN
        List<TourDuLichModel> listTour;
        List<LoaiChiPhiModel> listChiPhi;
        List<KhachHangModel> listKhach;
        Dictionary<string, string> tour, chiphi;
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
            // đoàn
            
            allDoanDuLichs = DoanDuLichModel.GetAll();
            dtgvDoan.DataSource = allDoanDuLichs;
            dtgvDoan.Columns["TourDuLich"].Visible = false;
            dtgvDoan.Columns["NoiDungTour"].Visible = false;
            dtgvDoan.Columns["MaTour"].Visible = false;
            dtgvDoan.Columns["MaDoan"].Visible = false;

            // khách
            allKhachHangs = KhachHangModel.GetAll();
            dtgvKhach.DataSource = allKhachHangs;
            dtgvKhach.Columns["MaKhachHang"].Visible = false;

            // nhân viên
            allNhanViens = NhanVienModel.GetAll();
            dtgvNhanVien.DataSource = allNhanViens;
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanVien.Columns["MaNhanVien"].Visible = false;
            dtgvNhanVien.Columns["id_doan"].Visible = false;

            /*   allPhanBos = PhanBoNhanVienModel.GetAll();
               dtgvPhanBoNhanVien.DataSource = allPhanBos;
               dtgvPhanBoNhanVien.Columns["MaNhanVien"].Visible = false;
               dtgvPhanBoNhanVien.Columns["NhanVien"].Visible = false;
               dtgvPhanBoNhanVien.Columns["DoanDuLich"].Visible = false;
               dtgvPhanBoNhanVien.Columns["MaTour"].Visible = false;*/



            // tour
            allTours = TourDuLichModel.GetAll();
            dtgvTour.DataSource = allTours;
            dtgvTour.Columns["MaLoaiHinh"].Visible = false;
            dtgvTour.Columns["LoaiHinhDuLich"].Visible = false;
            dtgvTour.Columns["MaTour"].Visible = false;
            dtgvTour.Columns["DacDiem"].Visible = false;

            // tham quan
            /* allThamQuans = ThamQuanModel.GetAll();
             dtgvThamQuan.DataSource = allThamQuans;
             dtgvThamQuan.Columns["DiaDiem"].Visible = false;*/

            // giá tour
            allGias = GiaTourModel.GetAll();
            dtgvGiaTour.DataSource = allGias;
            dtgvGiaTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // load combobox
               loadComBoBoxTour();
               loadComboboxDoan();
               loadComboboxKhach();

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
            doan.MaDoan = cbbTenTour.Text;
            doan.MaTour = txtHanhTrinh.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtKhachSan.Text);
            doan.NgayKetThuc = DateTime.Parse(txtDiaDiemThamQuan.Text);
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
            /*string id = cbbTenTour.Text;

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
            }*/
        }

        private void dtgvChiTietTour_SelectionChanged(object sender, EventArgs e)
        {
           

        }

        private void btnSuaChiTietTour_Click(object sender, EventArgs e)
        {
            var doan = allDoanDuLichs[currentDoanIndex];
            doan.MaDoan = cbbTenTour.Text;
            doan.MaTour = txtHanhTrinh.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtKhachSan.Text);
            doan.NgayKetThuc = DateTime.Parse(txtDiaDiemThamQuan.Text);
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
            currentKhachIndex = dtgvKhach.CurrentCell.RowIndex;

            // update current tour details
            var khach = allKhachHangs[currentKhachIndex];
            if (khach != null)
            {
              //  txtMaKhach.Text = khach.MaKhachHang.ToString();
                txtHoTen.Text = khach.HoTen.ToString();
                txtCMND.Text = khach.SoCMND.ToString();
                txtDiaChi.Text = khach.DiaChi.ToString();
                cbbGioiTinh.Text = khach.GioiTinh.ToString();
                txtSoDT.Text = khach.SDT.ToString();
                txtQuocTich.Text = khach.QuocTich.ToString();

            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
           

            ThemKhach khach = new ThemKhach();
            khach.ShowDialog();

            if (khach.DialogResult == DialogResult.OK)
            {
                reloadData();
            }
            khach.Dispose();
        }

        private void btnXoaKhach_Click(object sender, EventArgs e)
        {
            var khach = allKhachHangs[currentKhachIndex];

            if (khach.DeleteToDB())
            {
                MessageBox.Show("Xóa thành công");

                reloadData();

            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSuaKhach_Click(object sender, EventArgs e)
        {
            var kh = allKhachHangs[currentKhachIndex];
  //          kh.MaKhachHang = txtMaKhach.Text;
            kh.HoTen = txtHoTen.Text;
            kh.SoCMND = txtCMND.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.GioiTinh = cbbGioiTinh.Text;
            kh.SDT = txtSoDT.Text;
            kh.QuocTich = txtQuocTich.Text;

            if (kh.UpdateToDB())
            {
                MessageBox.Show("Sửa thành công");
                reloadData();
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
            currentNhanVienIndex = dtgvNhanVien.CurrentCell.RowIndex;

            // update current tour details
            var nv = allNhanViens[currentNhanVienIndex];
            if (nv != null)
            {
                txtNhiemVu.Text = nv.NhiemVu.ToString();
                txtTenNhanVien.Text = nv.TenNhanVien.ToString();
                txtNgayBD_NhanVien.Text = nv.NgayBatDau.ToString();
                txtNgayKT_NhanVien.Text = nv.NgayKetThuc.ToString();

            }

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

        private void dtgvChiTietTour_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void dtgvDoan_SelectionChanged(object sender, EventArgs e)
        {
            /*currentDoanIndex = dtgvDoan.CurrentCell.RowIndex;
            // update current tour details
            var doan = allDoanDuLichs[currentDoanIndex];
            if (doan != null)
            {
                cbbTenTour.Text = doan.TourDuLich.TenTour.ToString();
                txtHanhTrinh.Text = doan.HanhTrinh.ToString();
                txtKhachSan.Text = doan.KhachSan.ToString();
                txtDiaDiemThamQuan.Text = doan.DiaDiemThamQuan.ToString();
                txtNgayKH.Text = doan.NgayKhoiHanh.ToString();
                txtNgayKT.Text = doan.NgayKetThuc.ToString();
                cbbChiPhi.Text = doan.TenChiPhi.ToString();
                txtSoTien.Text = doan.SoTien.ToString();
*//*              txtTenKhach.Text = doan.TenKhachHang.ToString();
                txtSDT.Text = doan.SoDienThoai.ToString();*//*
            }*/
        }

        private void btnThemChiTietTour_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThemDoan_Click_1(object sender, EventArgs e)
        {
          
            ThemDoan doan = new ThemDoan();
            doan.ShowDialog();

            if (doan.DialogResult == DialogResult.OK)
            {
                reloadData();
            }
            doan.Dispose();

        }

        private void btnXoaDoan_Click(object sender, EventArgs e)
        {
            var doan = allDoanDuLichs[currentDoanIndex];

            if (doan.DeleteToDB())
            {
                MessageBox.Show("Xóa thành công");
              
                dtgvDoan.DataSource = null;
                allDoanDuLichs.Remove(doan);
                dtgvDoan.DataSource = allDoanDuLichs;
                dtgvDoan.Columns["TourDuLich"].Visible = false;
                dtgvDoan.Columns["NoiDungTour"].Visible = false;
                dtgvDoan.Columns["MaTour"].Visible = false;
                dtgvDoan.Columns["MaDoan"].Visible = false;

            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSuaDoan_Click(object sender, EventArgs e)
        {
            var doan = allDoanDuLichs[currentDoanIndex];
            doan.TourDuLich.TenTour = cbbTenTour.SelectedValue.ToString();
            doan.NgayKhoiHanh = DateTime.Parse(txtNgayBatDau.Text);
            doan.NgayKetThuc = DateTime.Parse(txtNgayKetThuc.Text);
            doan.HanhTrinh = txtHanhTrinh.Text;
            doan.KhachSan = txtKhachSan.Text;
            doan.DiaDiemThamQuan = txtDiaDiemThamQuan.Text;
            doan.TenChiPhi = cbbChiPhi.SelectedValue.ToString();
            doan.SoTien = int.Parse(txtSoTien.Text);

            if (doan.UpdateToDB())
            {
                MessageBox.Show("Sửa thành công");
                dtgvDoan.DataSource = null;
                dtgvDoan.DataSource = allDoanDuLichs;
                dtgvDoan.Columns["TourDuLich"].Visible = false;
                dtgvDoan.Columns["NoiDungTour"].Visible = false;
                dtgvDoan.Columns["MaTour"].Visible = false;
                dtgvDoan.Columns["MaDoan"].Visible = false;
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        private void dtgvKhach_SelectionChanged(object sender, EventArgs e)
        {
           /* currentKhachIndex = dtgvKhach.CurrentCell.RowIndex;
           
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

            }*/
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
         /*   currentNhanVienIndex = dtgvNhanVien.CurrentCell.RowIndex;

            // update current tour details
            var nv = allNhanViens[currentNhanVienIndex];
            if (nv != null)
            {
                txtNhiemVu.Text = nv.MaNhanVien.ToString();
                txtTenNhanVien.Text = nv.TenNhanVien.ToString();;

            }
*/
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void loadComBoBoxTour()
        {
            listLoaiHinh = LoaiHinhDuLichModel.GetAll();
            listDiaDiem = DiaDiemModel.GetAll();

            //    textBox1.Text = "MT" + (TourDuLichModel.getCount() + 1);

            // DIA DIEM
            diaDiem = new Dictionary<string, string>();

            for (int i = 0; i < listDiaDiem.Count; i++)
            {
                DiaDiemModel a = listDiaDiem[i];

                diaDiem.Add(a.MaDiaDiem, a.TenDiaDiem);
            }
            cbbTenDiaDiem_form1.DataSource = new BindingSource(diaDiem, null);
            cbbTenDiaDiem_form1.DisplayMember = "Value";
            cbbTenDiaDiem_form1.ValueMember = "Value";

            cbbTenDiaDiem_form1.SelectedIndex = 0;

            // LOAI HINH
            loaiHinh = new Dictionary<string, string>();

            for (int i = 0; i < listLoaiHinh.Count; i++)
            {
                LoaiHinhDuLichModel a = listLoaiHinh[i];

                loaiHinh.Add(a.MaLoaiHinh, a.TenLoaiHinh);
            }
            cbbTenLoaiHinh_form1.DataSource = new BindingSource(loaiHinh, null);
            cbbTenLoaiHinh_form1.DisplayMember = "Value";
            cbbTenLoaiHinh_form1.ValueMember = "Value";

            cbbTenLoaiHinh_form1.SelectedIndex = 0;
        }

        private void loadComboboxKhach()
        {
            cbbGioiTinh.Text = "Nam";
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            txtQuocTich.Text = "Việt Nam";
        }
        private void loadComboboxDoan()
        {
            listTour = TourDuLichModel.GetAll();
            listChiPhi = LoaiChiPhiModel.GetAll();
            listKhach = KhachHangModel.GetAll();


            // TOUR
            tour = new Dictionary<string, string>();

            for (int i = 0; i < listTour.Count; i++)
            {
                TourDuLichModel a = listTour[i];

                tour.Add(a.MaTour, a.TenTour);
            }
            cbbTenTour.DataSource = new BindingSource(tour, null);
            cbbTenTour.DisplayMember = "Value";
            cbbTenTour.ValueMember = "Value";

            cbbTenTour.SelectedIndex = 0;

            // CHIPHI
            chiphi = new Dictionary<string, string>();

            for (int i = 0; i < listChiPhi.Count; i++)
            {
                LoaiChiPhiModel a = listChiPhi[i];

                chiphi.Add(a.MaLoaiChiPhi, a.TenLoaiChiPhi);
            }
            cbbChiPhi.DataSource = new BindingSource(chiphi, null);
            cbbChiPhi.DisplayMember = "Value";
            cbbChiPhi.ValueMember = "Value";

            cbbChiPhi.SelectedIndex = 0;
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            var tour = allTours[currentTourIndex];
            tour.TenTour = txtTenTour.Text;
            tour.LoaiHinhDuLich.TenLoaiHinh = cbbTenLoaiHinh_form1.SelectedValue.ToString();
            tour.TenDiaDiem = cbbTenDiaDiem_form1.SelectedValue.ToString();
            tour.ThanhTien = int.Parse(txtGiaTien.Text);
            tour.ThoiGianBatDau = DateTime.Parse(txtNgayBatDau.Text);
            tour.ThoiGianKetThuc = DateTime.Parse(txtNgayKetThuc.Text);


            if (tour.UpdateDB())
            {
                MessageBox.Show("Sửa thành công");
                dtgvTour.DataSource = null;
                dtgvTour.DataSource = allTours;
                dtgvTour.Columns["MaLoaiHinh"].Visible = false;
                dtgvTour.Columns["LoaiHinhDuLich"].Visible = false;
                dtgvTour.Columns["MaTour"].Visible = false;
                dtgvTour.Columns["DacDiem"].Visible = false;
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dtgvThamQuan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentTourIndex = dtgvTour.CurrentCell.RowIndex;

            // update current tour details
            var tour = allTours[currentTourIndex];
            if (tour != null)
            {
                txtTenTour.Text = tour.TenTour.ToString();
                cbbTenLoaiHinh_form1.Text = tour.TenLoaiTour.ToString();
                cbbTenDiaDiem_form1.Text = tour.TenDiaDiem.ToString();
                txtGiaTien.Text = tour.ThanhTien.ToString();
                txtNgayBatDau.Text = tour.ThoiGianBatDau.ToString();
                txtNgayKetThuc.Text = tour.ThoiGianKetThuc.ToString();

            }

        }

        private void dtgvTour_SelectionChanged(object sender, EventArgs e)
        {
           
             /*   currentTourIndex = dtgvTour.CurrentCell.RowIndex;

                // update current tour details
                var tour = allTours[currentTourIndex];
                if (tour != null)
                {
                    txtTenTour.Text = tour.TenTour.ToString();
                    cbbTenLoaiHinh_form1.Text = tour.TenLoaiTour.ToString();    
                    cbbTenDiaDiem_form1.Text = tour.TenDiaDiem.ToString();
                    txtGiaTien.Text = tour.ThanhTien.ToString();
                    txtNgayBatDau.Text = tour.ThoiGianBatDau.ToString();
                    txtNgayKetThuc.Text = tour.ThoiGianKetThuc.ToString();

                }*/
            
            
          
        }
        public void readData()
        {
            // tour
            allTours = TourDuLichModel.GetAll();
            dtgvTour.DataSource = allTours;
            dtgvTour.Columns["MaLoaiHinh"].Visible = false;
            dtgvTour.Columns["LoaiHinhDuLich"].Visible = false;
            dtgvTour.Columns["MaTour"].Visible = false;
            dtgvTour.Columns["DacDiem"].Visible = false;

            // đoàn
            allDoanDuLichs = DoanDuLichModel.GetAll();
            dtgvDoan.DataSource = allDoanDuLichs;
            dtgvDoan.Columns["TourDuLich"].Visible = false;
            dtgvDoan.Columns["NoiDungTour"].Visible = false;
            dtgvDoan.Columns["MaTour"].Visible = false;
            dtgvDoan.Columns["MaDoan"].Visible = false;

            // khách
            allKhachHangs = KhachHangModel.GetAll();
            dtgvKhach.DataSource = allKhachHangs;
            dtgvKhach.Columns["MaKhachHang"].Visible = false;

            // nhân viên
            allNhanViens = NhanVienModel.GetAll();
            dtgvNhanVien.DataSource = allNhanViens;
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanVien.Columns["MaNhanVien"].Visible = false;
            dtgvNhanVien.Columns["id_doan"].Visible = false;
        }

        public void reloadData()
        {
            allTours = null;
            allDoanDuLichs = null;
            allKhachHangs = null;
            allNhanViens = null;
            readData();
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            ThemTour c = new ThemTour();
            c.ShowDialog();

            if(c.DialogResult == DialogResult.OK)
            {
                reloadData();
            }
            c.Dispose();

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            ThemNhanVien nv = new ThemNhanVien();
            nv.ShowDialog();

            if (nv.DialogResult == DialogResult.OK)
            {
                reloadData();
            }
            nv.Dispose();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            var nhanvien = allNhanViens[currentNhanVienIndex];

            if (nhanvien.DeleteToDB())
            {
                MessageBox.Show("Xóa thành công");
                reloadData();   
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            var nhanvien = allNhanViens[currentNhanVienIndex];
            //          kh.MaKhachHang = txtMaKhach.Text;
            nhanvien.TenNhanVien = txtTenNhanVien.Text;
            nhanvien.NhiemVu = txtNhiemVu.Text;

            if (nhanvien.UpdateDB())
            {
                MessageBox.Show("Sửa thành công");
                reloadData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dtgvDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentDoanIndex = dtgvDoan.CurrentCell.RowIndex;
            // update current tour details
            var doan = allDoanDuLichs[currentDoanIndex];
            if (doan != null)
            {
                cbbTenTour.Text = doan.TourDuLich.TenTour.ToString();
                txtHanhTrinh.Text = doan.HanhTrinh.ToString();
                txtKhachSan.Text = doan.KhachSan.ToString();
                txtDiaDiemThamQuan.Text = doan.DiaDiemThamQuan.ToString();
                txtNgayKH.Text = doan.NgayKhoiHanh.ToString();
                txtNgayKT.Text = doan.NgayKetThuc.ToString();
                cbbChiPhi.Text = doan.TenChiPhi.ToString();
                txtSoTien.Text = doan.SoTien.ToString();
                /*              txtTenKhach.Text = doan.TenKhachHang.ToString();
                                txtSDT.Text = doan.SoDienThoai.ToString();*/
            }
        }

       

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            var tour = allTours[currentTourIndex];
   
            if (tour.DeleteToDB())
            {
                MessageBox.Show("Xóa thành công");
              ///  allTours = TourDuLichModel.GetAll();
                dtgvTour.DataSource = null;
                allTours.Remove(tour);
                dtgvTour.DataSource = allTours;
                dtgvTour.Columns["MaLoaiHinh"].Visible = false;
                dtgvTour.Columns["LoaiHinhDuLich"].Visible = false;
                dtgvTour.Columns["MaTour"].Visible = false;
                dtgvTour.Columns["DacDiem"].Visible = false;
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

        }

      
    }
}
