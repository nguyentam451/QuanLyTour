using QuanLyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class KhachHangModel
    {
        public KhachHangModel(){}
        public KhachHangModel(string hoten, string socmnd, string diachi, string gioitinh, string sdt, string quoctich)
        {
            this.HoTen = hoten;
            this.SoCMND = socmnd;
            this.DiaChi = diachi;
            this.GioiTinh = gioitinh;
            this.SDT = sdt;
            this.QuocTich = quoctich;
        }
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string QuocTich { get; set; }

        List<ChiTietDoanModel> chiTietDoans { get; set; }
        public static List<KhachHangModel> GetAll()
        {
            return KhachDAL.getAll();
        }
        public bool InserToDB()
        {
            return KhachDAL.Insert(this);
        }

        public bool DeleteToDB()
        {
            return KhachDAL.Delete(this);
        }
        public bool UpdateToDB()
        {
            return KhachDAL.Update(this);
        }

        public static int getCount()
        {
            return KhachDAL.getCount();
        }

    }
}
