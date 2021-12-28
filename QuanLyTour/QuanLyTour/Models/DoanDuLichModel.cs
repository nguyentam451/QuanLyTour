using QuanLyTour.DAL;
using QuanLyTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class DoanDuLichModel
    {
        public DoanDuLichModel() { }
        public DoanDuLichModel(string matour, DateTime ngaykh, DateTime ngaykt)
        {
            this.MaTour = matour;
            this.NgayKhoiHanh = ngaykh;
            this.NgayKetThuc = ngaykt;
        }
        public string MaDoan { get; set; }
        public string MaTour { get; set; }      
        public TourDuLichModel TourDuLich { get; set; }
        public string TenTour
        {
            get { return TourDuLich.TenTour; }
        }
        public List<ChiTietDoanModel> chiTietDoans { get; set; }
      
        public ndTourModel NoiDungTour { get; set; }

        public string HanhTrinh { get; set; }
        public string KhachSan { get; set; }
        public string DiaDiemThamQuan { get; set; }
        public DateTime NgayKhoiHanh { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public string TenChiPhi { get; set; }
        public int SoTien { get; set; }
/*        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }*/

        public static List<DoanDuLichModel> GetAll()
        {
            return DoanDuLichDAL.getAll();
        }

        public bool InsertToDB()
        {
            return DoanDuLichDAL.Insert(this);
        }

        public  bool DeleteToDB()
        {
            return DoanDuLichDAL.Delete(this);
        }
        public bool UpdateToDB()
        {
            return DoanDuLichDAL.Update(this);
        }

        public static int getCount()
        {
            return DoanDuLichDAL.getCount();
        }
    }
}
