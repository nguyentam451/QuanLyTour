using QuanLyTour.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyTour.Models;
using QuanLyTour.View;
using QuanLyTour;

namespace QuanLyTour.View
{
    public partial class ThemTour : Form
    {
        List<LoaiHinhDuLichModel> listLoaiHinh;
        List<DiaDiemModel> listDiaDiem;
        Dictionary<string, string> loaiHinh, diaDiem;

        public ThemTour()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TourDuLichModel tour = new TourDuLichModel();
            tour.MaTour = textBox1.Text;
            tour.TenTour = textBox2.Text;
            tour.DacDiem = comboBox1.SelectedValue.ToString();
            tour.MaLoaiHinh = comboBox2.SelectedValue.ToString();

            if ( tour.InserToDB() )
            {
                MessageBox.Show("Them thanh cong");
                DialogResult = DialogResult.OK;


            } else
            {
                MessageBox.Show("Them that bai:\n"
                    + tour.MaTour + "\n"
                    + tour.TenTour + "\n"
                    + tour.DacDiem + "\n"
                    + tour.MaLoaiHinh);
                DialogResult = DialogResult.Cancel;

            }

            //MessageBox.Show(comboBox1.SelectedValue.ToString() + "A:A" + comboBox2.SelectedValue.ToString());



            /*Form3 c = new Form3();
            this.Hide();
            c.ShowDialog();
            this.Close();*/
        }

        private void ThemTour_Load(object sender, EventArgs e)
        {
            listLoaiHinh = LoaiHinhDuLichModel.GetAll();
            listDiaDiem = DiaDiemModel.GetAll();

            textBox1.Text = "MT" + (TourDuLichModel.getCount() + 1);

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

            comboBox1.SelectedIndex = 0;

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

        private void lbTittle_Click(object sender, EventArgs e)
        {

        }
    }
}
