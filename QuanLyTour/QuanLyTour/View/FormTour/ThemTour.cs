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

namespace QuanLyTour.View
{
    public partial class ThemTour : Form
    {
        List<LoaiHinhDuLichModel> listLoaiHinh;
        List<DiaDiemModel> listDiaDiem;
        Dictionary<string, string> loaiHinh, diaDiem;
      //  private static Form1 c;
        public ThemTour()
        {
            InitializeComponent();
       //     c = new Form1();
        }
        int i = (TourDuLichModel.getCount() + 1);
        private void btnLuu_Click(object sender, EventArgs e)
        {   
            TourDuLichModel tour = new TourDuLichModel();
            tour.MaTour = "MT" + i;
            tour.TenTour = txtTenTour_formThem.Text;
            tour.MaLoaiHinh = cbbTenLoaiHinh.SelectedValue.ToString();
            tour.DacDiem = cbbDiaDiem.SelectedValue.ToString();
            tour.ThanhTien = int.Parse(txtGiaTour_formThem.Text);
            tour.ThoiGianBatDau = DateTime.Parse(txtThoiGianBD_formThem.Text);
            tour.ThoiGianKetThuc = DateTime.Parse(txtThoiGianKT_formThem.Text);

            if (tour.InserToDB())
            {
                MessageBox.Show("Them thanh cong");
                DialogResult = DialogResult.OK;
             //   c.dtgvTour.DataSource = null;
             //   c.dtgvTour.DataSource = c.allTours;
                i++;
            }
            else
            {
                MessageBox.Show("Them that bai:\n"
                    + tour.MaTour + "\n"
                    + tour.TenTour + "\n"
                    + tour.DacDiem + "\n"
                    + tour.MaLoaiHinh);
                DialogResult = DialogResult.Cancel;

            }

        //    MessageBox.Show(cbbTenLoaiHinh.SelectedValue.ToString() + "A:A" + cbbDiaDiem.SelectedValue.ToString());



            /*Form3 c = new Form3();
            this.Hide();
            c.ShowDialog();
            this.Close();*/
        }

        private void ThemTour_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            txtThoiGianBD_formThem.Text = date.ToString();
            txtThoiGianKT_formThem.Text = date.ToString();

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
            cbbDiaDiem.DataSource = new BindingSource(diaDiem, null);
            cbbDiaDiem.DisplayMember = "Value";
            cbbDiaDiem.ValueMember = "Key";

            cbbDiaDiem.SelectedIndex = 0;

            // LOAI HINH
            loaiHinh = new Dictionary<string, string>();

            for (int i = 0; i < listLoaiHinh.Count; i++)
            {
                LoaiHinhDuLichModel a = listLoaiHinh[i];

                loaiHinh.Add(a.MaLoaiHinh, a.TenLoaiHinh);
            }
            cbbTenLoaiHinh.DataSource = new BindingSource(loaiHinh, null);
            cbbTenLoaiHinh.DisplayMember = "Value";
            cbbTenLoaiHinh.ValueMember = "Key";

            cbbTenLoaiHinh.SelectedIndex = 0;
        }
    }
}
