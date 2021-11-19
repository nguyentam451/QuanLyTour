using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    class DiaDiemModel
    {
        public DiaDiemModel() { }

        public string MaDiaDiem { get; set; }

        public string TenDiaDiem { get; set; }

        public static List<DiaDiemModel> GetAll()
        {
            return DAL.DiaDiemDAL.getAll();
        }
    }
}
