using QuanLyTour.Models;
using System;
using QuanLyTourWeb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.DAL
{
    public class GiaTourDAL
    {
        public static List<GiaTourModel> getAll()
        {
            List<GiaTourModel> dsTour = new List<GiaTourModel>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {

                var result = from u in db.GIATOURs
                             select new
                             {
                                 MaGia = u.MaGia,
                                 MaTour = u.MaTour,
                                 GiaTien = u.ThanhTien,
                                 ThoiGianBatDau = u.ThoiGianBatDau,
                                 ThoiGianKetThuc = u.ThoiGianKetThuc,


                             };

                foreach (var i in result)
                {

                    GiaTourModel gia = new GiaTourModel();
                    gia.MaGia = i.MaGia;
                    gia.MaTour = i.MaTour;
                    gia.GiaTien = (int)i.GiaTien;
                    gia.ThoiGianBatDau = (DateTime)i.ThoiGianBatDau;
                    gia.ThoiGianKetThuc = (DateTime)i.ThoiGianKetThuc;


                    dsTour.Add(gia);
                }


            }

            return dsTour;
        }
    }
}
