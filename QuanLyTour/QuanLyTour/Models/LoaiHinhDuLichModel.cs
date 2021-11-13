using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Model
{
    public class LoaiHinhDuLichModel
    {
        public LoaiHinhDuLichModel() { }

        [Key]
        public int MaLoaiHinh { get; set; }

        public string TenLoaiHinh { get; set ; }
  


        public List<TourDuLichModel> Tours { get; set; }
    }
}
