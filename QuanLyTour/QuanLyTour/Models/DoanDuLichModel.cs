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

        public string MaDoan { get; set; }
        public DateTime NgayKhoiHanh { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string MaTour { get; set; }
        public TourDuLichModel TourDuLich { get; set; }

        public string TenTour
        {
            get { return TourDuLich.TenTour; }

        }
        public string DacDiem
        {
            get { return TourDuLich.DacDiem; }
        }
        public static List<DoanDuLichModel> GetAll()
        {
            return DoanDuLichDAL.getAll();
        }



    }
}
