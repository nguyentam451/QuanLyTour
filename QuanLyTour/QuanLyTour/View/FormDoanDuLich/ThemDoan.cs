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

namespace QuanLyTour.View.FormDoanDuLich
{
    public partial class ThemDoan : Form
    {
        List<TourDuLichModel> listTour;
        List<LoaiChiPhiModel> listChiPhi;
        List<KhachHangModel> listKhach;
        Dictionary<string, string> tour, chiphi, khach;

        int i = (DoanDuLichModel.getCount() + 1);
        private void button1_Click(object sender, EventArgs e)
        {
            DoanDuLichModel doan = new DoanDuLichModel();
            doan.MaDoan = "MD" + i;
            doan.MaTour = cbbTenTour.SelectedValue.ToString();
            doan.HanhTrinh = txtHanhTrinh.Text;
            doan.KhachSan = txtKhachSan.Text;
            doan.DiaDiemThamQuan = txtDiaDiem.Text;
            doan.NgayKhoiHanh = DateTime.Parse(txtNgayKH.Text);
            doan.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);
            doan.TenChiPhi = cbbLoaiChiPhi.SelectedValue.ToString();
            doan.SoTien = int.Parse (txtSoTien.Text);


            if (doan.InsertToDB())
            {
                MessageBox.Show("Them thanh cong");
                DialogResult = DialogResult.OK;

                i++;
            }
            else
            {
                MessageBox.Show("Them that bai:\n"
                    + doan.MaTour + "\n"
                    + doan.TenTour + "\n"
                    + doan.MaDoan + "\n");
                DialogResult = DialogResult.Cancel;

            }

           // MessageBox.Show(cbbTenLoaiHinh.SelectedValue.ToString() + "A:A" + cbbDiaDiem.SelectedValue.ToString());
        }

        public ThemDoan()
        {
            InitializeComponent();
        }

        private void ThemDoan_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtNgayKH.Text = date.ToString();
            txtNgayKT.Text = date.ToString();

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
            cbbTenTour.ValueMember = "Key";

            cbbTenTour.SelectedIndex = 0;

            // CHIPHI
            chiphi = new Dictionary<string, string>();

            for (int i = 0; i < listChiPhi.Count; i++)
            {
                LoaiChiPhiModel a = listChiPhi[i];

                chiphi.Add(a.MaLoaiChiPhi, a.TenLoaiChiPhi);
            }
            cbbLoaiChiPhi.DataSource = new BindingSource(chiphi, null);
            cbbLoaiChiPhi.DisplayMember = "Value";
            cbbLoaiChiPhi.ValueMember = "Key";

            cbbLoaiChiPhi.SelectedIndex = 0;
        }
    }
}
