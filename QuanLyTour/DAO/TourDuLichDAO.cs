using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class TourDuLichDAO
    {
        private static TourDuLichDAO instance;
        public static TourDuLichDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TourDuLichDAO();
                return instance;
            }
        }

        private TourDuLichDAO() { }

       public List<TOURDULICH> getAll()
        {
            List<TOURDULICH> dsTour = new List<TOURDULICH>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                // cách 1
                //  db.DeferredLoadingEnabled = false;
                //   dsTour = db.TOURDULICHes.Select(p => p).ToList();

                // cách 2
                var result = from u in db.TOURDULICHes
                             select new
                             {
                                 MaTour = u.MaTour,
                                 TenTour = u.TenGoi,
                                 DacDiem = u.DacDiem,
                                 MaLoaiHinh = u.MaLoaiHinh,

                             };
                foreach (var i in result)
                {

                    TOURDULICH tour = new TOURDULICH();


                    tour.MaTour = i.MaTour;
                    tour.TenGoi = i.TenTour;
                    tour.DacDiem = i.DacDiem;
                    tour.MaLoaiHinh = i.MaLoaiHinh;

                    dsTour.Add(tour);
                }


            }

            return dsTour;
        }




    }
}
