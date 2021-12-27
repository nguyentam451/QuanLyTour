using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyTour.Model;

namespace QuanLyTour.DAL
{
    class LoaiHinhDuLichDAL
    {
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

    }
}