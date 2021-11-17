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
                             from t in db.NOIDUNGTOURs
                             where u.MaDoan == t.MaDoan
                             select new
                             {
                                 MaDoan = u.MaDoan,
                                 MaTour = u.MaTour,
                                 HanhTrinh = t.HanhTrinh,
                                 KhachSan = t.KhachSan,
                                 DiaDiem = t.DiaDiemThamQuan,
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
                    doan.NoiDungTour = new Model.ndTourModel(i.HanhTrinh, i.KhachSan, i.DiaDiem);




                    dsTour.Add(doan);
                }


            }

            return dsTour;
        }


    }
}
