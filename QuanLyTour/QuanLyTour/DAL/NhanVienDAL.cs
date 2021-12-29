using QuanLyTour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;
        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAL();
                return instance;
            }
        }

        private NhanVienDAL() { }

        public static List<NhanVienModel> getAll()
        {
            List<NhanVienModel> dsNhanVien = new List<NhanVienModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                var result = from d in db.DOANDULICHes
                             from nv in db.NHANVIENs
                             from pb in db.PHANBONHANVIEN_DOANs
                           
                             where d.MaDoan == pb.MaDoan & 
                                    pb.MaNhanVien == nv.MaNhanVien
                             select new
                             {
                                 MaNhanVien = nv.MaNhanVien,
                                 MaDoan = d.MaDoan,
                                 NgayBatDau = d.NgayKhoiHanh,
                                 NgayKetThuc = d.NgayKetThuc,
                                 TenNhanVien = nv.TenNhanVien,
                                 NhiemVu = pb.NhiemVu,
                                
                             };


                foreach (var i in result)
                {

                    NhanVienModel nhanvien = new NhanVienModel();

                    nhanvien.MaNhanVien = i.MaNhanVien;
                    nhanvien.TenNhanVien = i.TenNhanVien;
                    nhanvien.NhiemVu = i.NhiemVu;
                    nhanvien.NgayBatDau = (DateTime)i.NgayBatDau;
                    nhanvien.NgayKetThuc = (DateTime)i.NgayKetThuc;

                    dsNhanVien.Add(nhanvien);
                }

            }

            return dsNhanVien;
        }
    }
}
