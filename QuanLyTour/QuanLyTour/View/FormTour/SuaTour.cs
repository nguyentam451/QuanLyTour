using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyTour.Model;
using QuanLyTour.Models;

namespace QuanLyTour.View.FormTour
{
    public partial class SuaTour : Form
    {
        public String maTour;
        List<TourDuLichModel> listTours;
        List<LoaiHinhDuLichModel> listLoaiHinh;
        List<DiaDiemModel> listDiaDiem;
        Dictionary<string, string> loaiHinh, diaDiem;

        public SuaTour(String maTour)
        {
            InitializeComponent();
            this.maTour = maTour;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TourDuLichModel tour = new TourDuLichModel();
            tour.MaTour = textBox1.Text;
            tour.TenTour = textBox2.Text;
            tour.DacDiem = comboBox1.SelectedValue.ToString();
            tour.MaLoaiHinh = comboBox2.SelectedValue.ToString();

            if (tour.UpdateDB())
            {
                MessageBox.Show("Sua thanh cong");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sua that bai:\n"
                    + tour.MaTour + "\n"
                    + tour.TenTour + "\n"
                    + tour.DacDiem + "\n"
                    + tour.MaLoaiHinh);
                DialogResult = DialogResult.Cancel;

            }
        }

        private void SuaTour_Load(object sender, EventArgs e)
        {
            listTours = TourDuLichModel.GetAll();
            listLoaiHinh = LoaiHinhDuLichModel.GetAll();
            listDiaDiem = DiaDiemModel.GetAll();

            textBox1.Text = maTour;

            TourDuLichModel tour = TourDuLichModel.findTourDuLich_Ma(listTours, maTour);
            textBox2.Text = tour.TenTour;

            //MessageBox.Show(tour.DacDiem + " " + tour.MaLoaiHinh);

            // DIA DIEM
            diaDiem = new Dictionary<string, string>();

            for (int i = 0; i < listDiaDiem.Count; i++)
            {
                DiaDiemModel a = listDiaDiem[i];
               
                diaDiem.Add(a.MaDiaDiem, a.TenDiaDiem);
            }
            comboBox1.DataSource = new BindingSource(diaDiem, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            comboBox1.SelectedItem = 0;

            // LOAI HINH
            loaiHinh = new Dictionary<string, string>();

            for (int i = 0; i < listLoaiHinh.Count; i++)
            {
                LoaiHinhDuLichModel a = listLoaiHinh[i];

                loaiHinh.Add(a.MaLoaiHinh, a.TenLoaiHinh);
            }
            comboBox2.DataSource = new BindingSource(loaiHinh, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";

            comboBox2.SelectedIndex = 0;
        }
    }
}
