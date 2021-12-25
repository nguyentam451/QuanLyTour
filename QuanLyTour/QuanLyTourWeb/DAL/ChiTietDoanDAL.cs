using QuanLyTour.Models;
using System;
using QuanLyTourWeb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    dsTour.Add(chitietdoan);
                }


            }

            return dsTour;
        }
    }
}
