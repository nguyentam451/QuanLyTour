using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Model
{
   public class ndTourModel
    {
        public ndTourModel(string hanhtrinh, string khachsan, string diadiem)
        {
            this.HanhTrinh = hanhtrinh;
            this.KhachSan = khachsan;
            this.DiaDiemThamQuan = diadiem;
        }
        public string MaDoan { get; set; }
        public string HanhTrinh { get; set; }
        public string KhachSan { get; set; }
        public string DiaDiemThamQuan { get; set; }


    }
}
