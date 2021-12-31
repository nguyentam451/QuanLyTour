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

        public static int getCount()
        {
            return LoaiHinhDuLichDAL.getCount();
        }

        public string MaLoaiHinh { get; set; }

        public string TenLoaiHinh { get; set; }

        public List<TourDuLichModel> Tours { get; set; }

        public static List<LoaiHinhDuLichModel> GetAll()
        {
            return DAL.LoaiHinhDuLichDAL.getAll();
        }

        public List<LoaiHinhDuLichModel> getAll()
        {
            return DAL.LoaiHinhDuLichDAL.getAll();
        }

        public bool InserToDB()
        {
            return LoaiHinhDuLichDAL.Insert(this);
        }

        public bool DeleteToDB()
        {
            return LoaiHinhDuLichDAL.Delete(this);
        }
        public bool UpdateDB()
        {
            return LoaiHinhDuLichDAL.Update(this);
        }

        public static LoaiHinhDuLichModel findLHDLByID(List<LoaiHinhDuLichModel> list, string maloai)
        {
            LoaiHinhDuLichModel res = new LoaiHinhDuLichModel();

            list.ForEach(x =>
            {
                if (x.MaLoaiHinh.Contains(maloai))
                {
                    res.MaLoaiHinh = x.MaLoaiHinh;
                    res.TenLoaiHinh = x.TenLoaiHinh;
                }
            });

            return res;
        }
    }
}
