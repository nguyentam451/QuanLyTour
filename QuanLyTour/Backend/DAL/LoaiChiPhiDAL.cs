using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Backend;
using QuanLyTour.Models;

namespace QuanLyTour.DAL
{
    public class LoaiChiPhiDAL
    {
        public static List<LoaiChiPhiModel> getAll()
        {
            List<LoaiChiPhiModel> list = new List<LoaiChiPhiModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                var result = from u in db.LOAICHIPHIs
                             select new
                             {
                                 a = u.MaLoaiChiPhi,
                                 b = u.TenLoaiChiPhi,
                             };

                foreach (var i in result)
                {
                    LoaiChiPhiModel tour = new LoaiChiPhiModel();

                    tour.MaLoaiChiPhi = i.a;
                    tour.TenLoaiChiPhi = i.b;

                    list.Add(tour);
                }


            }
            return list;
        }
        public static int getCount()
        {
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                int count = (from u in db.LOAICHIPHIs select u).Count();
                return count;
            }
        }

        public static bool Insert(LoaiChiPhiModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    db.LOAICHIPHIs.InsertOnSubmit(new LOAICHIPHI()
                    {
                        MaLoaiChiPhi = obj.MaLoaiChiPhi,
                        TenLoaiChiPhi = obj.TenLoaiChiPhi,
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

        public static bool Delete(LoaiChiPhiModel obj)
        {
            try
            {

                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var cp = db.CHIPHIs.Where(p => p.MaLoaiChiPhi.Equals(obj.MaLoaiChiPhi)).SingleOrDefault();
                    if(cp != null)
                    {
                        return false;
                    }
                    else
                    {
                        var kh = db.LOAICHIPHIs.Where(p => p.MaLoaiChiPhi.Equals(obj.MaLoaiChiPhi)).SingleOrDefault();
                        db.LOAICHIPHIs.DeleteOnSubmit(kh);
                        db.SubmitChanges();
                    }
                   

                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public static bool Update(LoaiChiPhiModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {

                    var kh = db.LOAICHIPHIs.Where(p => p.MaLoaiChiPhi.Equals(obj.MaLoaiChiPhi)).SingleOrDefault();
                    kh.MaLoaiChiPhi = obj.MaLoaiChiPhi;
                    kh.TenLoaiChiPhi = obj.TenLoaiChiPhi;

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