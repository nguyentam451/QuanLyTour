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
    public class DiaDiemDAL
    {
        public static int getCount()
        {
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                int count = (from u in db.DIADIEMs select u).Count();
                return count;
            }
        }

        public static List<DiaDiemModel> getAll()
        {
            List<DiaDiemModel> dsTour = new List<DiaDiemModel>();

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
                    dsTour.Add(tour);
                }
            }

            return dsTour;
        }

    }
}