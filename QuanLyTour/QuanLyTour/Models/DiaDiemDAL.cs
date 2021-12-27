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
    }
}