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
    public partial class FormTour : Form
    {
        List<TourDuLichModel> allTours;
        List<DoanDuLichModel> allDoanDuLichs;
        List<ChiTietDoanModel> allThongTinKhachHangs;
        List<GiaTourModel> allBangGias;

        public FormTour()
        {
            InitializeComponent();
        }

        public void reloadData()
        {
            allTours = null;
            readData();
        }

        public void readData()
        {
            allTours = TourDuLichModel.GetAll();
            dataGridViewTourDuLich.DataSource = allTours;

            dataGridViewTourDuLich.Columns["MaLoaiHinh"].Visible = false;
            dataGridViewTourDuLich.Columns["LoaiHinhDuLich"].Visible = false;
            //dataGridViewTourDuLich.Columns["MaTour"].Visible = false;
            dataGridViewTourDuLich.Columns["DacDiem"].Visible = false;

            dataGridViewTourDuLich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormTour_Load(object sender, EventArgs e)
        {
            readData();


            allDoanDuLichs = DoanDuLichModel.GetAll();
            dataGridView1.DataSource = allDoanDuLichs;
            //   dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["TourDuLich"].Visible = false;
            dataGridView1.Columns["NoiDungTour"].Visible = false;


            /*allThongTinKhachHangs = ChiTietDoanModel.GetAll();
            dtgvKhachHang.DataSource = allThongTinKhachHangs;
            dtgvKhachHang.Columns["DoanDuLich"].Visible = false;
            dtgvKhachHang.Columns["KhachHang"].Visible = false;

            allBangGias = GiaTourModel.GetAll();
            dtgvGia.DataSource = allBangGias;
            dtgvGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // add and remove tabpages
            tabControl1.TabPages.Remove(tabPageKhach);
            tabControl1.TabPages.Remove(tabPageGia);*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void lbTenTour_Click(object sender, EventArgs e)
        {

        }

        private void txtTenTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaLoaiHinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMaLoaiHinh_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemTour c = new ThemTour();
            //this.Hide();
            c.ShowDialog();
            //this.Close();

            if (c.DialogResult == DialogResult.OK)
            {
                reloadData();
            }
            c.Dispose();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TourDuLichModel a = new TourDuLichModel();

            a.MaTour = dataGridViewTourDuLich.SelectedCells[0].Value.ToString();

            if (a.DeleteToDB())
            {
                reloadData();
                MessageBox.Show("xoa thanh cong");
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TourDuLichModel a = new TourDuLichModel();

            a.MaTour = dataGridViewTourDuLich.SelectedCells[0].Value.ToString();

            SuaTour c = new SuaTour(a.MaTour);
            c.ShowDialog();


            if (c.DialogResult == DialogResult.OK)
            {
                reloadData();
            }
            c.Dispose();

        }
    }
}
