using QuanLyTour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.DAL
{
   public class DoanDuLichDAL
    {
        private static DoanDuLichDAL instance;
        public static DoanDuLichDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DoanDuLichDAL();
                return instance;
            }
        }

     
        public static List<DoanDuLichModel> getAll()
        {
            List<DoanDuLichModel> dsTour = new List<DoanDuLichModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
               
                var result = from u in db.DOANDULICHes
                             from t in db.TOURDULICHes
                             where u.MaTour == t.MaTour
                             select new
                             {
                                 MaDoan = u.MaDoan,
                                 MaTour = u.MaTour,
                                 TenTour = t.TenGoi,
                                 DacDiem = t.DacDiem,
                                 NgayKhoiHanhh = u.NgayKhoiHanh,
                                 NgayKetThuc = u.NgayKetThuc,


                             };



                foreach (var i in result)
                {

                    DoanDuLichModel doan = new DoanDuLichModel();



                    doan.MaDoan = i.MaDoan;
                    doan.MaTour = i.MaTour;
                    doan.NgayKhoiHanh = (DateTime)i.NgayKhoiHanhh;
                    doan.NgayKetThuc = (DateTime)i.NgayKetThuc;
                    doan.TourDuLich = new Model.TourDuLichModel(i.TenTour, i.DacDiem);




                    dsTour.Add(doan);
                }


            }

            return dsTour;
        }


    }
}
