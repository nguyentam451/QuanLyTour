using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTour.Model
{
    public class TourDuLichModel
    {

        public TourDuLichModel() { }
        public TourDuLichModel(string tentour, string dacdiem)
        {

            this.TenTour = tentour;
            this.DacDiem = dacdiem;

        }

        public TourDuLichModel(string maTour, string tenTour, string dacDiem, string maLoaiHinh, LoaiHinhDuLichModel loaiHinhDuLich)
        {
            this.MaTour = maTour;
            this.TenTour = tenTour;
            this.DacDiem = dacDiem;
            this.MaLoaiHinh = maLoaiHinh;
            this.LoaiHinhDuLich = loaiHinhDuLich;
        }

        public string MaTour { get; set; }

        public string TenTour { get; set; }
        public string DacDiem { get; set; }

        public string MaLoaiHinh { get; set; }

        public LoaiHinhDuLichModel LoaiHinhDuLich { get; set; }

        public string TenLoaiTour
        {
            get { return LoaiHinhDuLich.TenLoaiHinh; }

        }

        public string TenDacDiem { get; set; }

        public int ThanhTien { get; set; }

        public DateTime ThoiGianBatDau { get; set; }

        public DateTime ThoiGianKetThuc { get; set; }



        public static List<TourDuLichModel> GetAll()
        {
            return TourDuLichDAL.getAll();
        }

        public List<TourDuLichModel> getAll()
        {
            return TourDuLichDAL.getAll();
        }

        public bool InserToDB()
        {
            return TourDuLichDAL.Insert(this);
        }

        public bool DeleteToDB()
        {
            return TourDuLichDAL.Delete(this);
        }
        public bool UpdateDB()
        {
            return TourDuLichDAL.Update(this);
        }

        public static int getCount()
        {
            return TourDuLichDAL.getCount();
        }

        public static TourDuLichModel findTourDuLich_Ma(List<TourDuLichModel> list, string maTour)
        {
            TourDuLichModel res = new TourDuLichModel();

            list.ForEach(x => {
                if (x.MaTour.Contains(maTour))
                {
                    res.MaTour = x.MaTour;
                    res.TenTour = x.TenTour;
                    res.DacDiem = x.DacDiem;
                    res.MaLoaiHinh = x.MaLoaiHinh;

                    res.TenDacDiem = x.TenDacDiem;
                    res.LoaiHinhDuLich =x.LoaiHinhDuLich;

                    res.ThanhTien = x.ThanhTien;
                    res.ThoiGianBatDau = x.ThoiGianBatDau;
                    res.ThoiGianKetThuc = x.ThoiGianKetThuc;

                }
            });

            return res;

            /*
              foreach (TourDuLichModel item in list)
            {
                if (item.MaTour.Equals(maTour))
                    return item;
            }

            return null; 
            */

        }



    }
}
