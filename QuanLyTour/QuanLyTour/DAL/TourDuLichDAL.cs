using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyTour;
using QuanLyTour.Model;

namespace DAL
{
    public class TourDuLichDAL
    {
        private static TourDuLichDAL instance;
        public static TourDuLichDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TourDuLichDAL();
                return instance;
            }
        }

        private TourDuLichDAL() { }

        public static List<TourDuLichModel> getAll()
        {
            List<TourDuLichModel> dsTour = new List<TourDuLichModel>();


            // sử dụng linq
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                // cách 1
                //  db.DeferredLoadingEnabled = false;
                //   dsTour = db.TOURDULICHes.Select(p => p).ToList();

                // cách 2
                var result = from u in db.TOURDULICHes
                             from t in db.LOAIHINHDULICHes
                             where u.MaLoaiHinh == t.MaLoaiHinh
                             select new
                             {
                                 
                                 MaTour = u.MaTour,
                                 TenTour = u.TenGoi,
                                 DacDiem = u.DacDiem,
                                 MaLoaiHinh = u.LOAIHINHDULICH.MaLoaiHinh,
                                 TenLoaiHinh = u.LOAIHINHDULICH.TenLoaiHinh,
                                    

                             };



                foreach (var i in result)
                {

                    TourDuLichModel tour = new TourDuLichModel();
                  


                    tour.MaTour = i.MaTour;
                    tour.TenTour = i.TenTour;
                    tour.DacDiem = i.DacDiem;
                    tour.MaLoaiHinh = i.MaLoaiHinh;


                    tour.LoaiHinhDuLich = new LoaiHinhDuLichModel(i.TenLoaiHinh);
                    tour.LoaiHinhDuLich.TenLoaiHinh = i.TenLoaiHinh;



                    dsTour.Add(tour);
                }


            }

            return dsTour;
        }

        public static int getCount()
        {
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                int count = (from u in db.TOURDULICHes select u).Count();
                return count;
            }
        }

        public static bool Insert(TourDuLichModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    db.TOURDULICHes.InsertOnSubmit(new TOURDULICH()
                    {
                        MaTour = obj.MaTour,
                   //     TenGoi = obj.TenLoaiHinh,
                        DacDiem = obj.DacDiem,
                        MaLoaiHinh = obj.MaLoaiHinh
                    
                     }
                    );

                db.SubmitChanges();
            }

                return true;
        } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false; 
            }
}


    }

}
