using QuanLyTour.Models;
using QuanLyTourWeb;
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



        public static bool Insert(DoanDuLichModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    db.DOANDULICHes.InsertOnSubmit(new DOANDULICH()
                    {
                        MaDoan = obj.MaDoan,
                        MaTour = obj.MaTour,
                        NgayKhoiHanh = obj.NgayKhoiHanh,
                        NgayKetThuc = obj.NgayKetThuc,
                       

                    }
                    );

                    db.NOIDUNGTOURs.InsertOnSubmit(new NOIDUNGTOUR()
                    {
                        MaDoan = obj.MaDoan,
                        HanhTrinh = obj.HanhTrinh,
                        KhachSan = obj.KhachSan,
                        DiaDiemThamQuan = obj.DiaDiemThamQuan,

                    });

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
        public static bool Delete(String maDoan)
        {
            try
            {
                String id = maDoan;
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {

                    var doan = db.DOANDULICHes.Where(p => p.MaDoan.Equals(id)).SingleOrDefault();
                    var ndTour = db.NOIDUNGTOURs.Where(p => p.MaDoan.Equals(id)).SingleOrDefault();
                    db.DOANDULICHes.DeleteOnSubmit(doan);
                    db.NOIDUNGTOURs.DeleteOnSubmit(ndTour);

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

        public static bool Update(DoanDuLichModel obj)
        {
              try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {

                    var doan = db.DOANDULICHes.Where(p => p.MaDoan.Equals(obj.MaDoan)).SingleOrDefault();
                    doan.MaDoan = obj.MaDoan;
                    doan.MaTour = obj.MaTour;
                    doan.NgayKhoiHanh = obj.NgayKhoiHanh;
                    doan.NgayKetThuc = obj.NgayKetThuc;

                    var ndTour = db.NOIDUNGTOURs.Where(p => p.MaDoan.Equals(obj.MaDoan)).SingleOrDefault();
                    ndTour.MaDoan = obj.MaDoan;
                    ndTour.HanhTrinh = obj.HanhTrinh;
                    ndTour.KhachSan = obj.KhachSan;
                    ndTour.DiaDiemThamQuan = obj.DiaDiemThamQuan;
                    
                  
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
