using QuanLyTour.DAL;
using QuanLyTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class GiaTourModel
    {
        public string MaGia { get; set; }
        public string MaTour { get; set; }
        public int GiaTien { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }

        public List<TourDuLichModel> TourDuLichs { get; set; }

        public static List<GiaTourModel> GetAll()
        {
            return GiaTourDAL.getAll();
        }

    }
}
