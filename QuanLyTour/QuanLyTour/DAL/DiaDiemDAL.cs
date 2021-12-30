using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyTour.Models;

namespace QuanLyTour.DAL
{
    class DiaDiemDAL
    {
        public static List<DiaDiemModel> getAll()
        {
            List<DiaDiemModel> list = new List<DiaDiemModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                var result = from u in db.DIADIEMs
                             select new
                             {
                                 a = u.MaDiaDiem,
                                 b = u.TenDiaDiem
                             };

                foreach (var i in result)
                {
                    DiaDiemModel tour = new DiaDiemModel();

                    tour.MaDiaDiem = i.a;
                    tour.TenDiaDiem = i.b;

                    list.Add(tour);
                }


            }
            return list;
        }

        public static int getCount()
        {
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                int count = (from u in db.DIADIEMs select u).Count();
                return count;
            }
        }

        public static bool Insert(DiaDiemModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    db.DIADIEMs.InsertOnSubmit(new DIADIEM()
                    {
                        MaDiaDiem = obj.MaDiaDiem,
                        TenDiaDiem = obj.TenDiaDiem,
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

        public static bool Delete(DiaDiemModel obj)
        {
            try
            {

                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var kh = db.DIADIEMs.Where(p => p.MaDiaDiem.Equals(obj.MaDiaDiem)).SingleOrDefault();
                    db.DIADIEMs.DeleteOnSubmit(kh);
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
        public static bool Update(DiaDiemModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {

                    var kh = db.DIADIEMs.Where(p => p.MaDiaDiem.Equals(obj.MaDiaDiem)).SingleOrDefault();
                    kh.MaDiaDiem = obj.MaDiaDiem;
                    kh.TenDiaDiem = obj.TenDiaDiem;

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