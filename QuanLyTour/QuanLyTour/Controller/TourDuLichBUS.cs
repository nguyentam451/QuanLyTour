using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyTour;
using Model;

namespace Controller
{
    public class TourDuLichBUS
    {
        private static TourDuLichBUS instance;

        public static TourDuLichBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TourDuLichBUS();
                return instance;
            }
        }
        private TourDuLichBUS() { }

        public void getAll(DataGridView data)
        {
            data.DataSource = TourDuLichDAO.Instance.getAll();
        }
    }
}
