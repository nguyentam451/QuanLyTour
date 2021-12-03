using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyTour;
using QuanLyTour.Models;

namespace QuanLyTour.DAL
{
    public class KhachDAL
    {
        private static KhachDAL instance;
        public static KhachDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachDAL();
                return instance;
            }
        }

        private KhachDAL() { }

        public static List<KhachHangModel> getAll()
        {
            List<KhachHangModel> dsKhach = new List<KhachHangModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                var result = from u in db.KHACHes
                             select new
                             {

                                 MaKhach = u.MaKhachHang,
                                 HoTen = u.HoTen,
                                 SoCmnd = u.SoCMND,
                                 DiaChi = u.DiaChi,
                                 GioiTinh = u.GioiTinh,
                                 SDT = u.SDT,
                                 QuocTich = u.QuocTich,

                             };



                foreach (var i in result)
                {

                    KhachHangModel khach = new KhachHangModel();

                    khach.MaKhachHang = i.MaKhach;
                    khach.HoTen = i.HoTen;
                    khach.SoCMND = i.SoCmnd;
                    khach.DiaChi = i.DiaChi;
                    khach.GioiTinh = i.GioiTinh;
                    khach.SDT = i.SDT;
                    khach.QuocTich = i.QuocTich;


                    dsKhach.Add(khach);
                }

            }

            return dsKhach;
        }

        public static bool Insert(KhachHangModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    db.KHACHes.InsertOnSubmit(new KHACH()
                    {
                        MaKhachHang = obj.MaKhachHang,
                        HoTen = obj.HoTen,
                        SoCMND = obj.SoCMND,
                        DiaChi = obj.DiaChi,
                        GioiTinh = obj.GioiTinh,
                        SDT = obj.SDT,
                        QuocTich = obj.QuocTich,
                     

                    }
                    );

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

        public static bool Delete(String maKH)
        {
            try
            {
                String id = maKH;
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var kh = db.KHACHes.Where(p => p.MaKhachHang.Equals(id)).SingleOrDefault();
                    db.KHACHes.DeleteOnSubmit(kh);
  

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
        public static bool Update(KhachHangModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {

                    var kh = db.KHACHes.Where(p => p.MaKhachHang.Equals(obj.MaKhachHang)).SingleOrDefault();
                    kh.MaKhachHang = obj.MaKhachHang;
                    kh.HoTen = obj.HoTen;
                    kh.SoCMND = obj.SoCMND;
                    kh.DiaChi = obj.DiaChi;
                    kh.GioiTinh = obj.GioiTinh;
                    kh.SDT = obj.SDT;
                    kh.QuocTich = obj.QuocTich;

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
