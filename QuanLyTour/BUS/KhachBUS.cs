using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class KhachBUS
    {
        private static KhachBUS instance;

        public static KhachBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachBUS();
                return instance;
            }
        }
        private KhachBUS() { }

        public void getAll(DataGridView data)
        {
            data.DataSource = KhachDAO.Instance.getAll();
        }
    }
}
