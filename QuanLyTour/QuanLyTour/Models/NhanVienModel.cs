using QuanLyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class NhanVienModel
    {
        public NhanVienModel() { }
        public NhanVienModel(string tenNhanVien)
        {
            this.TenNhanVien = tenNhanVien;
        }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string NhiemVu { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public static List<NhanVienModel> GetAll()
        {
            return NhanVienDAL.getAll();
        }
    }
}
