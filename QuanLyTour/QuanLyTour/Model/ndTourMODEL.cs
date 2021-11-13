using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Model
{
    class ndTourMODEL
    {
        public String MaTour { set; get; }
        public String TenGoi { set; get; }
        public String DacDiem { set; get; }
        public IEnumerable TenLoaiHinh { set; get; }
        public IEnumerable MaDiaDiem { set; get; }
        public int ThanhTien { set; get; }
        public DateTime TGBatDau { set; get; }
        public DateTime TGKetThuc { set; get; }
    }
}
