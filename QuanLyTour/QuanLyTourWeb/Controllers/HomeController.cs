using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using Backend;

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
            setViewBagMaTour();
            setViewBagTenChiPhi();

            return View();
        }

        //POST: home/create
        [HttpPost]
        public ActionResult Create(QuanLyTour.Models.DoanDuLichModel model)
        {
            try
            {
                model.MaDoan = "MD" + (QuanLyTour.Models.DoanDuLichModel.getCount() + 1);

                model.InsertToDB();
      
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DetailsDoan(string id)
        {
            var con = new QuanLyTour.Models.DoanDuLichModel();
            var edit = QuanLyTour.DAL.ChiTietDoanDAL.getAllbyID(id);

            return View(edit);
        }

        public ActionResult EditsDoan(string id)
        {
            var con = new QuanLyTour.Models.DoanDuLichModel();
            var edit = QuanLyTour.Models.DoanDuLichModel.findDoanDuLichByMaDoan(con.getAll(), id);

            setViewBagMaTour();
            setViewBagTenChiPhi();

            return View(edit);
        }

        [HttpPost]
        public ActionResult EditsDoan(QuanLyTour.Models.DoanDuLichModel model)
        {
            try
            {
                model.UpdateToDB();

                var txt = model.MaDoan + model.MaTour + model.HanhTrinh + model.NgayKhoiHanh + model.NgayKetThuc + model.KhachSan + model.DiaDiemThamQuan + model.TenChiPhi + model.SoTien;

                MessageBox.Show(txt);

                return RedirectToAction("Index");
            }
            catch
            { 
                return View();
            }
        }

        public ActionResult DeleteDoan(string id)
        {
            var con = new QuanLyTour.Models.DoanDuLichModel();
            var delete = QuanLyTour.Models.DoanDuLichModel.findDoanDuLichByMaDoan(con.getAll(), id);
           
          

            return View(delete);
        }

        [HttpPost]
        public ActionResult DeleteDoan(string id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                var con = new QuanLyTour.Models.DoanDuLichModel();
                var delete = QuanLyTour.Models.DoanDuLichModel.findDoanDuLichByMaDoan(con.getAll(), id);

                delete.DeleteToDB();

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
            setViewBagMaLoaiHinh();
            setViewBagDiaDiem();
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
            var dao = new QuanLyTour.Models.DiaDiemModel();
            ViewBag.DacDiem = new SelectList(dao.getAll(), "MaDiaDiem", "TenDiaDiem", selected);
        }

         public void setViewBagTenChiPhi(long? selected = null)
        {
            var dao = new QuanLyTour.Models.LoaiChiPhiModel();
            ViewBag.TenChiPhi = new SelectList(dao.getAll(), "MaLoaiChiPhi", "TenLoaiChiPhi", selected);
        }

        public void setViewBagMaTour(long? selected = null)
        {
            var dao = new QuanLyTour.Model.TourDuLichModel();
            ViewBag.MaTour = new SelectList(dao.getAllTourDL(), "MaTour", "TenTour", selected);
        }
    
    }
       
}