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
            setViewBagDiaDiem();
            setViewBagMaLoaiHinh();
            return View();
        }

        public void setViewBagMaLoaiHinh(long? selected = null)
        {
            var dao = new QuanLyTour.Model.LoaiHinhDuLichModel();
            ViewBag.MaLoaiHinh = new SelectList(dao.getAll(), "MaLoaiHinh", "TenLoaiHinh", selected);
        }

        public void setViewBagDiaDiem(long? selected = null)
        {
            var dao = new QuanLyTour.Model.DiaDiemModel();
            ViewBag.DacDiem = new SelectList(dao.getAll(), "MaDiaDiem", "TenDiaDiem", selected);
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