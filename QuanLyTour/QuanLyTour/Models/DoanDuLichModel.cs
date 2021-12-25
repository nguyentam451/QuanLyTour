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
        public DateTime NgayKhoiHanh { get; set; }
        public DateTime NgayKetThuc { get; set; }
        
        public TourDuLichModel TourDuLich { get; set; }
        public List<ChiTietDoanModel> chiTietDoans { get; set; }
      
        public ndTourModel NoiDungTour { get; set; }
      /*  public string HanhTrinh
        {
            get { return NoiDungTour.HanhTrinh;  }
        }
        public string KhachSan
        {
            get { return NoiDungTour.KhachSan; }
        }
        public string DiaDiemThamQuan
        {
            get { return NoiDungTour.DiaDiemThamQuan; }
        }*/

        public static List<DoanDuLichModel> GetAll()
        {
            return DoanDuLichDAL.getAll();
        }

        public bool InsertToDB()
        {
            return DoanDuLichDAL.Insert(this);
        }

        public static bool DeleteToDB(string id)
        {
            return DoanDuLichDAL.Delete(id);
        }
        public bool UpdateToDB()
        {
            return DoanDuLichDAL.Update(this);
        }
    }
}
