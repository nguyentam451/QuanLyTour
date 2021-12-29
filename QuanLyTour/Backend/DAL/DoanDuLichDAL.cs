using QuanLyTour.Model;
using QuanLyTour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Backend;

namespace QuanLyTour.DAL
{
   public class DoanDuLichDAL
    {
        public static int i = getCountChiPhi() + 1;
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

                var result = from d in db.DOANDULICHes
                             from nd in db.NOIDUNGTOURs
                                 //   from ct in db.CHITIETDOANs
                                 //  from k in db.KHACHes
                             from cp in db.CHIPHIs
                             from lcp in db.LOAICHIPHIs
                             from tour in db.TOURDULICHes
                             where /*d.MaDoan == ct.MaDoan & 
                             ct.MaKhachHang == k.MaKhachHang &*/
                             d.MaDoan == nd.MaDoan &
                             d.MaDoan == cp.MaDoan &
                             cp.MaLoaiChiPhi == lcp.MaLoaiChiPhi &
                             d.MaTour == tour.MaTour
                             select new
                             {
                                 MaDoan = d.MaDoan,
                                 MaTour = d.MaTour,
                                 TenTour = tour.TenGoi,
                                 HanhTrinh = nd.HanhTrinh,
                                 KhachSan = nd.KhachSan,
                                 DiaDiem = nd.DiaDiemThamQuan,
                                 NgayKhoiHanhh = d.NgayKhoiHanh,
                                 NgayKetThuc = d.NgayKetThuc,
                                 TenChiPhi = lcp.TenLoaiChiPhi,
                                 SoTien = cp.SoTien,
                               /*  TenKhachHang = k.HoTen,
                                 SDT = k.SDT,*/


                             };



                foreach (var i in result)
                {

                    DoanDuLichModel doan = new DoanDuLichModel();



                    doan.MaDoan = i.MaDoan;
                    doan.MaTour = i.MaTour;
                    doan.TourDuLich = new TourDuLichModel(i.TenTour);
                    //    doan.NoiDungTour = new ndTourModel(i.HanhTrinh, i.KhachSan, i.DiaDiem);
                    doan.HanhTrinh = i.HanhTrinh;
                    doan.KhachSan = i.KhachSan;
                    doan.DiaDiemThamQuan = i.DiaDiem;
                    doan.NgayKhoiHanh = (DateTime)i.NgayKhoiHanhh;
                    doan.NgayKetThuc = (DateTime)i.NgayKetThuc;
                    doan.TenChiPhi = i.TenChiPhi;
                    doan.SoTien = (int)i.SoTien;
                 /*   doan.TenKhachHang = i.TenKhachHang;
                    doan.SoDienThoai = i.SDT;*/

                 //   doan.NoiDungTour = new Model.ndTourModel(i.HanhTrinh, i.KhachSan, i.DiaDiem);




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
                    db.SubmitChanges();

                    db.NOIDUNGTOURs.InsertOnSubmit(new NOIDUNGTOUR()
                    {
                        MaDoan = obj.MaDoan,
                        HanhTrinh = obj.HanhTrinh,
                        KhachSan = obj.KhachSan,
                        DiaDiemThamQuan = obj.DiaDiemThamQuan,

                    });

                    db.SubmitChanges();

                    db.CHIPHIs.InsertOnSubmit(new CHIPHI()
                    {
                        
                        MaChiPhi = "MCP" + i,
                        MaDoan = obj.MaDoan,
                        SoTien = obj.SoTien,
                        MaLoaiChiPhi = obj.TenChiPhi,
           

                    });
                    db.SubmitChanges();
                    i=i+1;
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool DeleteNoiDungTour(String id)
        {
            try
            {
               
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {

                    var ndTour = db.NOIDUNGTOURs.Where(p => p.MaDoan.Equals(id)).SingleOrDefault();

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
        public static bool Delete(DoanDuLichModel obj)
        {
            try
            {
             
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var ndTour = db.NOIDUNGTOURs.Where(p => p.MaDoan.Equals(obj.MaDoan)).SingleOrDefault();
                    db.NOIDUNGTOURs.DeleteOnSubmit(ndTour);
                    db.SubmitChanges();

                    var chiphi = db.CHIPHIs.Where(p => p.MaDoan.Equals(obj.MaDoan)).SingleOrDefault();
                    db.CHIPHIs.DeleteOnSubmit(chiphi);
                    db.SubmitChanges();

                    var doan = db.DOANDULICHes.Where(p => p.MaDoan.Equals(obj.MaDoan)).SingleOrDefault();
                    db.DOANDULICHes.DeleteOnSubmit(doan);
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
                    db.SubmitChanges();

                    var ndTour = db.NOIDUNGTOURs.Where(p => p.MaDoan.Equals(obj.MaDoan)).SingleOrDefault();
                    ndTour.MaDoan = obj.MaDoan;
                    ndTour.HanhTrinh = obj.HanhTrinh;
                    ndTour.KhachSan = obj.KhachSan;
                    ndTour.DiaDiemThamQuan = obj.DiaDiemThamQuan;
                    db.SubmitChanges();

                    var chiphi = db.CHIPHIs.Where(p => p.MaDoan.Equals(obj.MaDoan)).SingleOrDefault();
                    chiphi.MaDoan = obj.MaDoan;
                    chiphi.SoTien = obj.SoTien;
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
        public static int getCount()
        {
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                int count = (from u in db.DOANDULICHes select u).Count();
                return count;
            }
        }

        public static int getCountChiPhi()
        {
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                int count = (from u in db.CHIPHIs select u).Count();
                return count;
            }
        }
    }
}
