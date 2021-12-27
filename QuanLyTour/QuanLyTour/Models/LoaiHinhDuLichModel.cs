using QuanLyTour.DAL;
using System.Collections.Generic;

namespace QuanLyTour.Model
{
    public class LoaiHinhDuLichModel
    {
        
        public LoaiHinhDuLichModel() { }

        public LoaiHinhDuLichModel(string maLoaiHinh, string tenLoaiHinh, List<TourDuLichModel> tours)
        {
            this.MaLoaiHinh = maLoaiHinh;
            this.TenLoaiHinh  = tenLoaiHinh;
            this.Tours = tours;
        }
        public LoaiHinhDuLichModel(string tenLoaiHinh)
        {
          
            this.TenLoaiHinh = tenLoaiHinh;
         
        }


        public string MaLoaiHinh { get; set; }

        public string TenLoaiHinh { get; set ; }

        public List<TourDuLichModel> Tours { get; set; }


        public static List<LoaiHinhDuLichModel> GetAll()
        {
            return LoaiHinhDuLichDAL.getAll();
        }
    }
}
