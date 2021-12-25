using QuanLyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class ThamQuanModel
    {
       
        public string MaTour { get; set; }
        public string MaDiaDiem { get; set; }
        public int ThuTu { get; set; }

        public DiaDiemModel DiaDiem { get; set; }

        public string TenDiaDiem
        {
            get { return DiaDiem.TenDiaDiem; }

        }
        public static List<ThamQuanModel> GetAll()
        {
            return ThamQuanDAL.getAll();
        }
    }
}
