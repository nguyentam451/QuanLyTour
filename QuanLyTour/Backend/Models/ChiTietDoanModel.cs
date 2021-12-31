using QuanLyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class ChiTietDoanModel
    {
        public string MaDoan { get; set; }
        public string MaKhachHang { get; set; }
        
        public DoanDuLichModel DoanDuLich { get; set; }
        public KhachHangModel KhachHang { get; set; }


        public string HoTen
        {
            get { return KhachHang.HoTen; }
          
        }
        public string SoCMND
        {
            get { return KhachHang.SoCMND; }
        }
        public string DiaChi
        {
            get { return KhachHang.DiaChi; }
        }
        public string GioiTinh
        {
            get { return KhachHang.GioiTinh; }
        }
        public string SDT
        {
            get { return KhachHang.SDT; }
        }
        public string QuocTich
        {
            get { return KhachHang.QuocTich; }
        }


        public static List<ChiTietDoanModel> GetAll()
        {
            return ChiTietDoanDAL.getAll();
        }

        public List<ChiTietDoanModel> getAll()
        {
            return ChiTietDoanDAL.getAll();
        }

       
    }
}
