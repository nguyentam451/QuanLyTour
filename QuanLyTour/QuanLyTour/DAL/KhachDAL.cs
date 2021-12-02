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
                    khach.SDT = i.DiaChi;
                    khach.QuocTich = i.QuocTich;


                    dsKhach.Add(khach);
                }

            }

            return dsKhach;
        }
    }

}
