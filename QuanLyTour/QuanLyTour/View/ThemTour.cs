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

namespace QuanLyTour.View
{
    public partial class ThemTour : Form
    {
        public ThemTour()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TourDuLichModel tour = new TourDuLichModel();
          /*  tour.MaTour = txtMaTour.Text;
            tour.MaLoaiHinh = txtMaLoaiHinh.Text;
            tour.TenTour = txtTenTour.Text;
            tour.DacDiem = txtDacDiem.Text;*/

            tour.InserToDB();

            Form1 c = new Form1();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}
