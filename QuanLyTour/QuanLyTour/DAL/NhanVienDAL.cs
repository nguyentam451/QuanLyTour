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
                var result = from u in db.NHANVIENs
                             select new
                             {

                               MaNhanVien = u.MaNhanVien,
                               TenNhanVien = u.TenNhanVien,

                             };


                foreach (var i in result)
                {

                    NhanVienModel nhanvien = new NhanVienModel();
                    nhanvien.MaNhanVien = i.MaNhanVien;
                    nhanvien.TenNhanVien = i.TenNhanVien;
                    


                    dsNhanVien.Add(nhanvien);
                }

            }

            return dsNhanVien;
        }
    }
}
