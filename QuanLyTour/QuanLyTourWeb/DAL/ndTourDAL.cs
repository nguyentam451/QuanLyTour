using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyTourWeb;
using System.Threading.Tasks;

namespace QuanLyTour.Model
{
    class ndTourDAO
    {
        private static ndTourDAO instance;
        public static ndTourDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ndTourDAO();
                return instance;
            }
        }

        private ndTourDAO() { }
       /* public List<ndTourModel> getAll()
        {
            List<ndTourModel> ndtours = new List<ndTourModel>();
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                 var res = (
                    from nd in db.TOURDULICHes.AsEnumerable()
     
                    join lh in db.LOAIHINHDULICHes on nd.MaLoaiHinh equals lh.MaLoaiHinh 
                    join tq in db.THAMQUANs on nd.MaTour equals tq.MaTour 
                    join gt in db.GIATOURs on nd.MaTour equals gt.MaTour

                    select new ndTourModel()
                    {
                        MaTour = nd.MaTour,
                        TenGoi = nd.TenGoi,
                        DacDiem = nd.DacDiem,
                        TenLoaiHinh = lh.TenLoaiHinh,
                        MaDiaDiem = tq.MaDiaDiem,
                        ThanhTien = gt.ThanhTien.Value,
                        TGBatDau = gt.ThoiGianBatDau.Value,
                        TGKetThuc = gt.ThoiGianKetThuc.Value
                    });
                foreach (var i in res)
                {
                    ndtours.Add(i);
                }
                
               
            }
            return ndtours;
        }*/

    }
}
