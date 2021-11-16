using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class KhachHangModel
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string QuocTich { get; set; }

        List<ChiTietDoanModel> chiTietDoans { get; set; }

    }
}
