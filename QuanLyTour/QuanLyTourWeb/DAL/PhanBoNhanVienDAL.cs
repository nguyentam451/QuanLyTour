using QuanLyTour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTourWeb;
using System.Threading.Tasks;

namespace QuanLyTour.DAL
{
    public class PhanBoNhanVienDAL
    {
        private static PhanBoNhanVienDAL instance;
        public static PhanBoNhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhanBoNhanVienDAL();
                return instance;
            }
        }

        public static List<PhanBoNhanVienModel> getAll()
        {
            List<PhanBoNhanVienModel> dsPhanBo = new List<PhanBoNhanVienModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                var result = from u in db.PHANBONHANVIEN_DOANs
                             select new
                             {

                                 MaNhanVien = u.MaNhanVien,
                                 TenNhanVien = u.NHANVIEN.TenNhanVien,
                                 MaDoan = u.MaDoan,
                                 NhiemVu = u.NhiemVu,
                                 MaTour = u.DOANDULICH.MaTour,
                                 NgayKhoiHanh = u.DOANDULICH.NgayKhoiHanh,
                                 NgayKetThuc = u.DOANDULICH.NgayKetThuc,


                             };


                foreach (var i in result)
                {

                    PhanBoNhanVienModel pbnv = new PhanBoNhanVienModel();
                    pbnv.MaNhanVien = i.MaNhanVien;
                    pbnv.NhanVien = new NhanVienModel(i.TenNhanVien);
                    pbnv.MaDoan = i.MaDoan;
                    pbnv.NhiemVu = i.NhiemVu;
                    pbnv.DoanDuLich = new DoanDuLichModel(i.MaTour, (DateTime)i.NgayKhoiHanh , (DateTime)i.NgayKetThuc);


                    dsPhanBo.Add(pbnv);
                }

            }

            return dsPhanBo;
        }
    }
    
}
