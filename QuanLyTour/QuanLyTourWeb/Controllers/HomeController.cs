using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyTourWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = QuanLyTour.Models.DoanDuLichModel.GetAll();
            return View(list);
        }
        public ActionResult Client()
        {
            var list = QuanLyTour.Models.DoanDuLichModel.GetAll();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}