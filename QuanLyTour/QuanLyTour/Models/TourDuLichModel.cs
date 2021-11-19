using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyTour.Model
{
    public class TourDuLichModel
    {
        public TourDuLichModel() { }
        public TourDuLichModel(string tentour, string dacdiem)
        {

            this.TenTour = tentour;
            this.DacDiem = dacdiem;

        }

        public TourDuLichModel(string maTour, string tenTour, string dacDiem, string maLoaiHinh, LoaiHinhDuLichModel loaiHinhDuLich)
        {
            this.MaTour = maTour;
            this.TenTour = tenTour;
            this.DacDiem = dacDiem;
            this.MaLoaiHinh = maLoaiHinh;
            this.LoaiHinhDuLich = loaiHinhDuLich;
        }

        public string MaTour { get; set; }

        public string TenTour { get; set; }
        public string DacDiem { get; set; }

        public string MaLoaiHinh { get; set; }
        
        public LoaiHinhDuLichModel LoaiHinhDuLich { get; set; }

        public string TenLoaiTour
        {
            get { return LoaiHinhDuLich.TenLoaiHinh; }

        }

        public string TenDacDiem { get; set; }

        public static List<TourDuLichModel> GetAll()
        {
            return TourDuLichDAL.getAll();
        }

        public bool InserToDB()
        {
            return TourDuLichDAL.Insert(this);
        }

        public bool DeleteToDB()
        {
            return TourDuLichDAL.Delete(this);
        }
        public bool UpdateDB()
        {
            return TourDuLichDAL.Update(this);
        }

        public static int getCount()
        {
            return TourDuLichDAL.getCount();
        }

        public static TourDuLichModel findTourDuLich_Ma(List<TourDuLichModel> list , string maTour)
        {
            TourDuLichModel res = new TourDuLichModel();
            for (int i = 0; i < list.Count; i++)
            {
                TourDuLichModel a = list[i];
                if (a.MaTour.Equals(maTour))
                {
                    res.MaTour = a.MaTour;
                    res.TenTour = a.TenTour;
                    res.DacDiem = a.DacDiem;
                    res.MaLoaiHinh = a.MaLoaiHinh;
                }
            }
            return res;
        }

        
    }
}
