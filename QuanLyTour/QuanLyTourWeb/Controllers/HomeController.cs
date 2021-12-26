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

        //POST: home/create
        [HttpPost]
        public ActionResult CreateTour(QuanLyTour.Model.TourDuLichModel model)
        {
            try
            {
                model.MaTour = "MT" + (QuanLyTour.Model.TourDuLichModel.getCount() + 1);

                model.InserToDB();

                return RedirectToAction("QLTour");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult EditTour(string id)
        {
            var con = new QuanLyTour.Model.TourDuLichModel();
            QuanLyTour.Model.TourDuLichModel edit = 
                QuanLyTour.Model.TourDuLichModel.findTourDuLich_Ma(con.getAll(), id);

            setViewBagDiaDiem();
            setViewBagMaLoaiHinh();
            return View(edit);
        }


        [HttpPost]
        public ActionResult EditTour(QuanLyTour.Model.TourDuLichModel model)
        {
            try
            {
                model.UpdateDB();

                return RedirectToAction("QLTour");
            }
            catch
            {
                return View();
            }
        }



        public ActionResult DeleteTour(string id)
        {
            var con = new QuanLyTour.Model.TourDuLichModel();
            QuanLyTour.Model.TourDuLichModel delete =
                QuanLyTour.Model.TourDuLichModel.findTourDuLich_Ma(con.getAll(), id);

            setViewBagDiaDiem();
            setViewBagMaLoaiHinh();

            return View(delete);
        }

        [HttpPost]
        public ActionResult DeleteTour(string id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                var con = new QuanLyTour.Model.TourDuLichModel();
                QuanLyTour.Model.TourDuLichModel delete =
                    QuanLyTour.Model.TourDuLichModel.findTourDuLich_Ma(con.getAll(), id);

                delete.DeleteToDB();

                return RedirectToAction("QLTour");
            }
            catch
            {
                return View();
            }
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

    }
}