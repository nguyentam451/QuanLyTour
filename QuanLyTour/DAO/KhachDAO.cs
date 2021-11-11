using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachDAO
    {
        private static KhachDAO instance;
        public static KhachDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachDAO();
                return instance;
            }
        }

        private KhachDAO() { }

        public List<KHACH> getAll()
        {
            List<KHACH> tour = new List<KHACH>();

            using (QuanLyTourDataContext db = new QuanLyTourDataContext())
            {
                tour = db.KHACHes.Select(p => p).ToList();

            }

            return tour;
        }
    }

}
