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
        List<TourDuLichModel> allTours;
        List<DoanDuLichModel> allDoanDuLichs;
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
            txtMaTour.DataBindings.Add(new Binding("Text", dataGridViewTourDuLich.DataSource, "MaTour"));
            txtTenTour.DataBindings.Add(new Binding("Text", dataGridViewTourDuLich.DataSource, "TenTour"));
            txtDacDiem.DataBindings.Add(new Binding("Text", dataGridViewTourDuLich.DataSource, "DacDiem"));
            txtMaLoaiHinh.DataBindings.Add(new Binding("Text", dataGridViewTourDuLich.DataSource, "MaLoaiHinh"));
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

            allTours = TourDuLichModel.GetAll();
            dataGridViewTourDuLich.DataSource = allTours;
            dataGridViewTourDuLich.Columns.Remove("LoaiHinhDuLich");

            allDoanDuLichs = DoanDuLichModel.GetAll();
            dataGridView1.DataSource = allDoanDuLichs;


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
    }
}
