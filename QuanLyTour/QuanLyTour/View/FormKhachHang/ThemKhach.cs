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

namespace QuanLyTour.View.FormKhachHang
{
    public partial class ThemKhach : Form
    {
        public ThemKhach()
        {
            InitializeComponent();
        }

        int i = KhachHangModel.getCount() + 1;
        private void ThemKhach_Load(object sender, EventArgs e)
        {
            //Thêm dữ liệu
            cbbGioiTinh.Text = "Nam";
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            txtQuocTich.Text = "Việt Nam";
            
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            KhachHangModel khach = new KhachHangModel();
            khach.MaKhachHang = "MKH" + i;
            khach.HoTen = txtHoTen.Text;
            khach.SoCMND = txtCMND.Text;
            khach.DiaChi = txtDiaChi.Text;
            khach.GioiTinh = cbbGioiTinh.Text;
            khach.SDT = txtSDT.Text;
            khach.QuocTich = txtQuocTich.Text;
            

            if (khach.InserToDB())
            {
                MessageBox.Show("Them thanh cong");
                DialogResult = DialogResult.OK;
                //   c.dtgvTour.DataSource = null;
                //   c.dtgvTour.DataSource = c.allTours;
                i++;
            }
            else
            {
               
                DialogResult = DialogResult.Cancel;

            }
            i = i + 1;
        }
    }
}
