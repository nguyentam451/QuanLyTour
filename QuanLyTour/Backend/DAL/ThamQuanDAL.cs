using QuanLyTour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;

namespace QuanLyTour.DAL
{
    public class ThamQuanDAL
    {
        private static ThamQuanDAL instance;
        public static ThamQuanDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThamQuanDAL();
                return instance;
            }
        }

        private ThamQuanDAL() { }

        public static List<ThamQuanModel> getAll()
        {
            List<ThamQuanModel> dsTour = new List<ThamQuanModel>();


            // sử dụng linq
            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {

                var result = from u in db.THAMQUANs
                             from t in db.DIADIEMs
                             where u.MaDiaDiem == t.MaDiaDiem
                             select new
                             {

                                 MaTour = u.MaTour,
                                 MaDiaDiem = u.MaDiaDiem,
                                 ThuTu = u.ThuTu,
                                 TenDiaDiem = t.TenDiaDiem,


                             };



                foreach (var i in result)
                {

                    ThamQuanModel thamquan = new ThamQuanModel();



                    thamquan.MaTour = i.MaTour;
                    thamquan.MaDiaDiem = i.MaDiaDiem;
                   
                    thamquan.DiaDiem = new DiaDiemModel(i.TenDiaDiem);
                    thamquan.ThuTu = i.ThuTu;

                    dsTour.Add(thamquan);
                }


            }

            return dsTour;
        }
    }
}
