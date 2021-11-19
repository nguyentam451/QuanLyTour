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
                             from v in db.DIADIEMs
                             where u.MaLoaiHinh == t.MaLoaiHinh &
                             u.DacDiem == v.MaDiaDiem
                             select new
                             {
                                 MaTour = u.MaTour,
                                 TenTour = u.TenGoi,
                                 DacDiem = u.DacDiem,
                                 MaLoaiHinh = u.LOAIHINHDULICH.MaLoaiHinh,
                                 TenLoaiHinh = u.LOAIHINHDULICH.TenLoaiHinh,
                                 TenDiaDiem = v.TenDiaDiem
                             };

                foreach (var i in result)
                {
                    TourDuLichModel tour = new TourDuLichModel();
                  
                    tour.MaTour = i.MaTour;
                    tour.TenTour = i.TenTour;
                    tour.DacDiem = i.DacDiem;
                    tour.MaLoaiHinh = i.MaLoaiHinh;

                    tour.LoaiHinhDuLich = new LoaiHinhDuLichModel(i.TenLoaiHinh);
                    tour.TenDacDiem = i.TenDiaDiem;
                   // tour.LoaiHinhDuLich.TenLoaiHinh = i.TenLoaiHinh;

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
                        TenGoi = obj.TenTour,
                        DacDiem = obj.DacDiem,
                        MaLoaiHinh = obj.MaLoaiHinh
                    });

                    db.SubmitChanges();
                }

                return true;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false; 
            }
        }

        public static bool Delete(TourDuLichModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var tour = db.TOURDULICHes.Where(p => p.MaTour.Equals(obj.MaTour)).SingleOrDefault();
                    
                    db.TOURDULICHes.DeleteOnSubmit(tour);

                    db.SubmitChanges();
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool Update(TourDuLichModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var tour = db.TOURDULICHes.Where(p => p.MaTour.Equals(obj.MaTour)).SingleOrDefault();
                    tour.MaTour = obj.MaTour;
                    tour.TenGoi = obj.TenTour;
                    tour.DacDiem = obj.DacDiem;
                    tour.MaLoaiHinh = obj.MaLoaiHinh;


                    db.SubmitChanges();
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }

}
