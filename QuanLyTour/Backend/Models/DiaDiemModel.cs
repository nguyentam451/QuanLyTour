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
        public DiaDiemModel()
        {
        }
        public DiaDiemModel(string tenDiaDiem)
        {

            this.TenDiaDiem = tenDiaDiem;

        }
        public DiaDiemModel(string maDiaDiem, string tenDiaDiem)
        {
            this.MaDiaDiem = maDiaDiem;
            this.TenDiaDiem = tenDiaDiem;
        }

        public static int getCount()
        {
            return DAL.DiaDiemDAL.getCount();
        }


        public string MaDiaDiem { get; set; }

        public string TenDiaDiem { get; set; }

        public static List<DiaDiemModel> GetAll()
        {
            return QuanLyTour.DAL.DiaDiemDAL.getAll();
        }

        public List<DiaDiemModel> getAll()
        {
            return DAL.DiaDiemDAL.getAll();
        }

        public bool InserToDB()
        {
            return DiaDiemDAL.Insert(this);
        }

        public bool DeleteToDB()
        {
            return DiaDiemDAL.Delete(this);
        }
        public bool UpdateDB()
        {
            return DiaDiemDAL.Update(this);
        }

        public static DiaDiemModel findDDByID(List<DiaDiemModel> list, string maDD)
        {
            DiaDiemModel res = new DiaDiemModel();

            list.ForEach(x =>
            {
                if (x.MaDiaDiem.Contains(maDD))
                {
                    res.MaDiaDiem = x.MaDiaDiem;
                    res.TenDiaDiem = x.TenDiaDiem;
                }
            });

            return res;
        }
    }
}
