using QuanLyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyTour.Models
{
    public class DiaDiemModel
    {
        public DiaDiemModel()
        {
        }
        public DiaDiemModel(string tenDiaDiem)
        {

            this.TenDiaDiem = tenDiaDiem;

        }
        public DiaDiemModel(string maDiaDiem, string tenDiaDiem)
        {
            this.MaDiaDiem = maDiaDiem;
            this.TenDiaDiem = tenDiaDiem;
        }

        public static int getCount()
        {
            return DAL.DiaDiemDAL.getCount();
        }


        public string MaDiaDiem { get; set; }

        public string TenDiaDiem { get; set; }

        public static List<DiaDiemModel> GetAll()
        {
            return QuanLyTour.DAL.DiaDiemDAL.getAll();
        }

        public List<DiaDiemModel> getAll()
        {
            return DAL.DiaDiemDAL.getAll();
        }
    }
}
