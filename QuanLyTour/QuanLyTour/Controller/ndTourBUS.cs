using QuanLyTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTour.Controller
{
    class ndTourBUS
    {
        private static ndTourBUS instance;

        public static ndTourBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ndTourBUS();
                return instance;
            }
        }
        private ndTourBUS() { }

        public void getAll(DataGridView data)
        {
            data.DataSource = ndTourDAO.Instance.getAll();
        }

    }
}
