using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyTour.Model
{
    public class DiaDiemModel
    {

        public DiaDiemModel()
        {
        }

        public DiaDiemModel(string maDiaDiem, string tenDiaDiem)
        {
            this.MaDiaDiem = maDiaDiem;
            this.TenDiaDiem = tenDiaDiem;
        }

        public static int getCount()
        {
            return DAL.LoaiHinhDuLichDAL.getCount();
        }


        public string MaDiaDiem { get; set; }

        public string TenDiaDiem { get; set; }

        public static List<DiaDiemModel> GetAll()
        {
            return DAL.DiaDiemDAL.getAll();
        }

        public List<DiaDiemModel> getAll()
        {
            return DAL.DiaDiemDAL.getAll();
        }
    }
}