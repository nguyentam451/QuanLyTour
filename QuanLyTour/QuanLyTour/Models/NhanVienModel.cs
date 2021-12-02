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
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }

        public static List<NhanVienModel> GetAll()
        {
            return NhanVienDAL.getAll();
        }
    }
}
