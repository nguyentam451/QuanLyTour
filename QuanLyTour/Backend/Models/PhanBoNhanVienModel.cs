using QuanLyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class PhanBoNhanVienModel
    {
        public PhanBoNhanVienModel() { }
        public string MaNhanVien { get; set; }
        public NhanVienModel NhanVien { get; set; }
        public string TenNhanVien
        {
            get { return NhanVien.TenNhanVien; }

        }

        public string MaDoan { get; set; }
        public string NhiemVu { get; set; }

        public DoanDuLichModel DoanDuLich { get; set; }
        public string MaTour
        {
            get { return DoanDuLich.MaDoan; }
        }
        public DateTime NgayKhoiHanh
        {
            get { return DoanDuLich.NgayKhoiHanh; }
        }
        public DateTime NgayKetThuc
        {
            get { return DoanDuLich.NgayKetThuc; }
        }

        public static List<PhanBoNhanVienModel> GetAll()
        {
            return PhanBoNhanVienDAL.getAll();
        }

    }
}
