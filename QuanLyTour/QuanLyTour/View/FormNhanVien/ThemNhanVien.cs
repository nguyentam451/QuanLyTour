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

namespace QuanLyTour.View.FormNhanVien
{
    public partial class ThemNhanVien : Form
    {
        List<DoanDuLichModel> listDoans;

        Dictionary<string, string> doan1,doan2;

        int i = (NhanVienModel.getCount() + 1);
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienModel nv = new NhanVienModel();
            nv.MaNhanVien = "MNV" + i;
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.NhiemVu = txtNhiemVu.Text;
         //   nv.NgayBatDau = DateTime.Parse(cbbNgayBD.SelectedValue.ToString());
         //   nv.NgayKetThuc = DateTime.Parse(cbbNgayKT.SelectedValue.ToString());
            nv.id_doan =cbbNgayBD.SelectedValue.ToString();





            if (nv.InserToDB())
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

        private void cbbNgayBD_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cbbNgayKT.Text = cbbNgayBD.Text;
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
          

            listDoans = DoanDuLichModel.GetAll();
            


            // DOAN
            doan1 = new Dictionary<string, string>();
       //     doan2 = new Dictionary<string, string>();

            for (int i = 0; i < listDoans.Count; i++)
            {
                DoanDuLichModel a = listDoans[i];

                doan1.Add(a.MaDoan, a.NgayKhoiHanh.ToString());
            //    doan2.Add(a.MaDoan, a.NgayKetThuc.ToString());
            }
            cbbNgayBD.DataSource = new BindingSource(doan1, null);
            cbbNgayBD.DisplayMember = "Value";
            cbbNgayBD.ValueMember = "Key";
            cbbNgayBD.SelectedIndex = 0;

       /*     cbbNgayKT.DataSource = new BindingSource(doan2, null);
            cbbNgayKT.DisplayMember = "Value";
            cbbNgayKT.ValueMember = "Key";
            cbbNgayKT.SelectedIndex = 0;*/

           
        }
    }
}
