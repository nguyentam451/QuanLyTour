using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Backend;

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

        public static List<TourDuLichModel> getAll_2()
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
                             join c in db.DOANDULICHes on u.MaTour equals c.MaTour
                             select new
                             {
                                 
                                 MaTour = u.MaTour,
                                 TenTour = u.TenGoi,
                                 DacDiem = u.DacDiem,
                                 MaLoaiHinh = u.LOAIHINHDULICH.MaLoaiHinh,
                                 TenLoaiHinh = u.LOAIHINHDULICH.TenLoaiHinh,
                                 NgayKBatDau = c.NgayKhoiHanh,

                             };



                foreach (var i in result)
                {

                    TourDuLichModel tour = new TourDuLichModel();
                  


                    tour.MaTour = i.MaTour;
                    tour.TenTour = i.TenTour;
                    tour.DacDiem = i.DacDiem;
                    tour.MaLoaiHinh = i.MaLoaiHinh;


                    tour.LoaiHinhDuLich = new LoaiHinhDuLichModel(i.TenLoaiHinh);
                   // tour.LoaiHinhDuLich.TenLoaiHinh = i.TenLoaiHinh;



                    dsTour.Add(tour);
                }
    

            }

            return dsTour;
        }

        public static List<TourDuLichModel> getAll()
        {
            List<TourDuLichModel> dsTour = new List<TourDuLichModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                var result = from u in db.TOURDULICHes
                             from t in db.LOAIHINHDULICHes
                             from v in db.DIADIEMs
                             from x in db.GIATOURs
                             where u.MaLoaiHinh == t.MaLoaiHinh &
                             u.DacDiem == v.MaDiaDiem &
                             u.MaTour == x.MaTour
                             select new
                             {
                                 MaTour = u.MaTour,
                                 TenTour = u.TenGoi,
                                 DacDiem = u.DacDiem,
                                 MaLoaiHinh = u.LOAIHINHDULICH.MaLoaiHinh,
                                 TenLoaiHinh = u.LOAIHINHDULICH.TenLoaiHinh,
                                 TenDiaDiem = v.TenDiaDiem,
                                 ThanhTien = x.ThanhTien,
                                 ThoiGianBatDau = x.ThoiGianBatDau,
                                 ThoiGianKetThuc = x.ThoiGianKetThuc
                             };
              

                foreach (var i in result)
                {
                    TourDuLichModel tour = new TourDuLichModel();

                    tour.MaTour = i.MaTour;
                    tour.TenTour = i.TenTour;
                    tour.DacDiem = i.DacDiem;
                    tour.MaLoaiHinh = i.MaLoaiHinh;

                    tour.LoaiHinhDuLich = new LoaiHinhDuLichModel(i.TenLoaiHinh);
                    tour.TenDiaDiem = i.TenDiaDiem;

                    tour.ThanhTien = (int)i.ThanhTien;
                    tour.ThoiGianBatDau = (DateTime)i.ThoiGianBatDau;
                    tour.ThoiGianKetThuc = (DateTime)i.ThoiGianKetThuc;


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

                    db.GIATOURs.InsertOnSubmit(new GIATOUR()
                    {
                        MaTour = obj.MaTour,
                        MaGia = obj.MaTour,
                        ThanhTien = obj.ThanhTien,
                        ThoiGianBatDau = obj.ThoiGianBatDau,
                        ThoiGianKetThuc = obj.ThoiGianKetThuc
                    });

                    db.SubmitChanges();

                }

                return true;
        } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false; 
            }
}

        // delete
        public static bool Delete(TourDuLichModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var gia = db.GIATOURs.Where(p => p.MaTour.Equals(obj.MaTour)).SingleOrDefault();
                    db.GIATOURs.DeleteOnSubmit(gia);
                    db.SubmitChanges();

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

                    var gia = db.GIATOURs.Where(p => p.MaTour.Equals(obj.MaTour)).SingleOrDefault();
                    gia.MaTour = obj.MaTour;
                    gia.MaGia = obj.MaTour;
                    gia.ThanhTien = obj.ThanhTien;
                    gia.ThoiGianBatDau = obj.ThoiGianBatDau;
                    gia.ThoiGianKetThuc = obj.ThoiGianKetThuc;

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
