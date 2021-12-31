using System;
using System.Collections.Generic;
using System.Linq;
using Backend;

using QuanLyTour.Model;

namespace QuanLyTour.DAL
{
    class LoaiHinhDuLichDAL
    {
        public static int getCount()
        {
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                int count = (from u in db.LOAIHINHDULICHes select u).Count();
                return count;
            }
        }

        public static List<LoaiHinhDuLichModel> getAll()
        {
            List<LoaiHinhDuLichModel> list = new List<LoaiHinhDuLichModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                var result = from u in db.LOAIHINHDULICHes
                             select new
                             {
                                 a = u.MaLoaiHinh,
                                 b = u.TenLoaiHinh
                             };

                foreach (var i in result)
                {
                    LoaiHinhDuLichModel tour = new LoaiHinhDuLichModel();

                    tour.MaLoaiHinh = i.a;
                    tour.TenLoaiHinh = i.b;

                    list.Add(tour);
                }


            }
            return list;
        }

        public static bool Insert(LoaiHinhDuLichModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    db.LOAIHINHDULICHes.InsertOnSubmit(new LOAIHINHDULICH()
                    {
                        MaLoaiHinh = obj.MaLoaiHinh,
                        TenLoaiHinh = obj.TenLoaiHinh,
                    }
                    );

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

        public static bool Delete(LoaiHinhDuLichModel obj)
        {
            try
            {

                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var kh = db.LOAIHINHDULICHes.Where(p => p.MaLoaiHinh.Equals(obj.MaLoaiHinh)).SingleOrDefault();
                    db.LOAIHINHDULICHes.DeleteOnSubmit(kh);
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
        public static bool Update(LoaiHinhDuLichModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {

                    var kh = db.LOAIHINHDULICHes.Where(p => p.MaLoaiHinh.Equals(obj.MaLoaiHinh)).SingleOrDefault();
                    kh.MaLoaiHinh = obj.MaLoaiHinh;
                    kh.TenLoaiHinh = obj.TenLoaiHinh;

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