using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace QuanLyTourWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = QuanLyTour.Models.DoanDuLichModel.GetAll();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        //POST: home/create
        [HttpPost]
        public ActionResult Create(QuanLyTour.Models.DoanDuLichModel model)
        {
            try
            {

                if (model.InsertToDB())
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai:\n");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult QLTour()
        {
            var list = QuanLyTour.Model.TourDuLichModel.GetAll();
            return View(list);
        }


        public ActionResult CreateTour()
        {
            var con = new QuanLyTour.Model.LoaiHinhDuLichModel();
            con.getAll();

            var LoaiHinhSelect = new SelectList("Vung Tau", "MaLoaiHinh", "TenLoaiHinh");
            ViewBag.MaLoaiHinh = LoaiHinhSelect;

            /*
            List<QuanLyTour.Model.LoaiHinhDuLichModel> listDiaDiem;
            listDiaDiem = QuanLyTour.Model.LoaiHinhDuLichModel.GetAll();

            Dictionary<string, string>  loaihinh = new Dictionary<string, string>();

            for (int i = 0; i < QuanLyTour.Model.LoaiHinhDuLichModel.getCount() ; i++)
            {
                QuanLyTour.Model.LoaiHinhDuLichModel a = listDiaDiem[i];

                loaihinh.Add(a.MaLoaiHinh, a.TenLoaiHinh);

            }

            var LoaiHinhSelect = new SelectList(loaihinh, "MaLoaiHinh", "TenLoaiHinh");
            ViewBag.MaLoaiHinh = LoaiHinhSelect;

            */

            //ViewBag.MaLoaiHinh = new BindingSource(loaihinh, null);
            //ViewBag.MaLoaiHinh = "Value";
            //ViewBag.MaLoaiHinh = "Key";

            return View();
        }

        //POST: home/create
        [HttpPost]
        public ActionResult CreateTour(QuanLyTour.Model.TourDuLichModel model)
        {
            try
            {
                model.MaTour = "MT" + (QuanLyTour.Model.TourDuLichModel.getCount() + 1);

                if (model.InserToDB())
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai:\n"
                        + model.MaTour + "\n"
                        + model.TenTour + "\n"
                        + model.DacDiem + "\n"
                        + model.MaLoaiHinh);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult EditTour(String id)
        {
            //var con = new QuanLyTour.Model.TourDuLichModel();
            //var edit = con.MaTour.Fi
            return View();
        }

    }
}