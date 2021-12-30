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
        public static int getCount()
        {
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                int count = (from u in db.NHANVIENs select u).Count();
                return count;
            }
        }

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

        public static bool Insert(NhanVienModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    db.NHANVIENs.InsertOnSubmit(new NHANVIEN()
                    {
                        MaNhanVien = obj.MaNhanVien,
                        TenNhanVien = obj.TenNhanVien,
                    }
                    );

                    db.SubmitChanges();

                    db.PHANBONHANVIEN_DOANs.InsertOnSubmit(new PHANBONHANVIEN_DOAN()
                    {
                        MaNhanVien = obj.MaNhanVien,
                        NhiemVu = obj.NhiemVu,
                        MaDoan = obj.id_doan,
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

        public static bool Delete(NhanVienModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var phanbo = db.PHANBONHANVIEN_DOANs.Where(p => p.MaNhanVien.Equals(obj.MaNhanVien)).SingleOrDefault();
                    db.PHANBONHANVIEN_DOANs.DeleteOnSubmit(phanbo);
                    db.SubmitChanges();

                    var nv = db.NHANVIENs.Where(p => p.MaNhanVien.Equals(obj.MaNhanVien)).SingleOrDefault();
                    db.NHANVIENs.DeleteOnSubmit(nv);
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

        public static bool Update(NhanVienModel obj)
        {
            try
            {
                using (QuanLyTourDataContext db = new QuanLyTourDataContext())
                {
                    var nhanvien = db.NHANVIENs.Where(p => p.MaNhanVien.Equals(obj.MaNhanVien)).SingleOrDefault();
                    nhanvien.MaNhanVien = obj.MaNhanVien;
                    nhanvien.TenNhanVien = obj.TenNhanVien;

                    db.SubmitChanges();

                    var phanbo = db.PHANBONHANVIEN_DOANs.Where(p => p.MaNhanVien.Equals(obj.MaNhanVien)).SingleOrDefault();
                    phanbo.NhiemVu = obj.NhiemVu;
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
