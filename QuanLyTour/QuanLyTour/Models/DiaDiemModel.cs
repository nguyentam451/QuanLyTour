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
        public DiaDiemModel() { }
        public DiaDiemModel(string tenDiaDiem)
        {

            this.TenDiaDiem = tenDiaDiem;

        }
        public string MaDiaDiem { get; set; }
        public string TenDiaDiem { get; set; }

        public static List<DiaDiemModel> GetAll()
        {
            return DiaDiemDAL.getAll();
        }
    }
}
