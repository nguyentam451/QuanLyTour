using QuanLyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class LoaiChiPhiModel
    {
        public string MaLoaiChiPhi { get; set; }
        public string TenLoaiChiPhi { get; set; }
        public static List<LoaiChiPhiModel> GetAll()
        {
            return LoaiChiPhiDAL.getAll();
        }

        public List<LoaiChiPhiModel> getAll()
        {
            return LoaiChiPhiDAL.getAll();
        }
    }
}
