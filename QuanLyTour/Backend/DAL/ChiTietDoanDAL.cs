using QuanLyTour.Models;
using System.Collections.Generic;
using System.Linq;

using Backend;


namespace QuanLyTour.DAL
{
    public class ChiTietDoanDAL
    {
        public static List<ChiTietDoanModel> getAll()
        {
            List<ChiTietDoanModel> dsTour = new List<ChiTietDoanModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {

                var result = from u in db.CHITIETDOANs
                             from t in db.KHACHes
                             where u.MaKhachHang == t.MaKhachHang
                             select new
                             {
                                 MaDoan = u.MaDoan,
                                 MaKhachHang = t.MaKhachHang,
                                 HoTen = t.HoTen,
                                 CMND = t.SoCMND,
                                 DiaChi = t.DiaChi,
                                 GioiTinh = t.GioiTinh,
                                 SDT = t.SDT,
                                 QuocTich = t.QuocTich
                             };

                foreach (var i in result)
                {
                    ChiTietDoanModel chitietdoan = new ChiTietDoanModel();

                    chitietdoan.MaDoan        = i.MaDoan;
                    chitietdoan.MaKhachHang   = i.MaKhachHang;
                    chitietdoan.KhachHang = new KhachHangModel(i.HoTen, i.CMND, i.DiaChi, i.GioiTinh, i.SDT, i.QuocTich);
                    chitietdoan.KhachHang.HoTen = i.HoTen;
                    chitietdoan.KhachHang.SoCMND = i.CMND;
                    chitietdoan.KhachHang.DiaChi = i.DiaChi;
                    chitietdoan.KhachHang.GioiTinh = i.GioiTinh;
                    chitietdoan.KhachHang.SDT = i.SDT;
                    chitietdoan.KhachHang.QuocTich = i.QuocTich;



                    dsTour.Add(chitietdoan);
                }


            }

            return dsTour;
        }

        public static List<ChiTietDoanModel> getAllbyID(string id)
        {
            List<ChiTietDoanModel> dsTour = new List<ChiTietDoanModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {

                var result = from u in db.CHITIETDOANs
                             from t in db.KHACHes
                             where u.MaKhachHang == t.MaKhachHang & u.MaDoan == id
                             select new
                             {
                                 MaDoan = u.MaDoan,
                                 MaKhachHang = t.MaKhachHang,
                                 HoTen = t.HoTen,
                                 CMND = t.SoCMND,
                                 DiaChi = t.DiaChi,
                                 GioiTinh = t.GioiTinh,
                                 SDT = t.SDT,
                                 QuocTich = t.QuocTich
                             };

                foreach (var i in result)
                {
                    ChiTietDoanModel chitietdoan = new ChiTietDoanModel();

                    chitietdoan.MaDoan = i.MaDoan;
                    chitietdoan.MaKhachHang = i.MaKhachHang;
                    chitietdoan.KhachHang = new KhachHangModel(i.HoTen, i.CMND, i.DiaChi, i.GioiTinh, i.SDT, i.QuocTich);
                    chitietdoan.KhachHang.HoTen = i.HoTen;
                    chitietdoan.KhachHang.SoCMND = i.CMND;
                    chitietdoan.KhachHang.DiaChi = i.DiaChi;
                    chitietdoan.KhachHang.GioiTinh = i.GioiTinh;
                    chitietdoan.KhachHang.SDT = i.SDT;
                    chitietdoan.KhachHang.QuocTich = i.QuocTich;



                    dsTour.Add(chitietdoan);
                }


            }

            return dsTour;
        }
    }
}
