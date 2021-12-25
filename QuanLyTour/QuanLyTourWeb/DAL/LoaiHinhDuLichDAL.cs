using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyTourWeb;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyTour;
using QuanLyTour.Model;

namespace QuanLyTour.DAL
{
    public class LoaiHinhDuLichDAL
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
            List<LoaiHinhDuLichModel> dsTour = new List<LoaiHinhDuLichModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                var result = from u in db.LOAIHINHDULICHes
                             select new
                             {
                                 MaLoaiHinh = u.MaLoaiHinh,
                                 TenLoaiHinh = u.TenLoaiHinh,
                             };

                foreach (var i in result)
                {
                    LoaiHinhDuLichModel tour = new LoaiHinhDuLichModel();

                    tour.MaLoaiHinh = i.MaLoaiHinh;
                    tour.TenLoaiHinh = i.TenLoaiHinh;
                    dsTour.Add(tour);
                }
            }

            return dsTour;
        }

    }
}