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
        public string id_doan { get; set; }
        public static List<NhanVienModel> GetAll()
        {
            return NhanVienDAL.getAll();
        }
        public bool InserToDB()
        {
            return NhanVienDAL.Insert(this);
        }
        public static int getCount()
        {
            return NhanVienDAL.getCount();
        }

        public bool DeleteToDB()
        {
            return NhanVienDAL.Delete(this);
        }
        public bool UpdateDB()
        {
            return NhanVienDAL.Update(this);
        }
    }
}
