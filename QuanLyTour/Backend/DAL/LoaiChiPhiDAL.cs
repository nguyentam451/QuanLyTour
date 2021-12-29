using System.Collections.Generic;
using System.Linq;
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

    }
}