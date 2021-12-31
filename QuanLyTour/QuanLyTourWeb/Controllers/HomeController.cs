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

        //------------------------------------------------------------------------------
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

        //------------------------------------------------------------------------------
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

        //------------------------------------------------------------------------------
        public ActionResult LoaiHinh()
        {
            var con = new QuanLyTour.Model.LoaiHinhDuLichModel().getAll();
            
            return View(con);
        }

        public ActionResult createLHDL()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createLHDL(QuanLyTour.Model.LoaiHinhDuLichModel model)
        {
            try
            {
                model.MaLoaiHinh = "MLH" + (QuanLyTour.Model.LoaiHinhDuLichModel.getCount() + 1);

                model.InserToDB();

                return RedirectToAction("LoaiHinh");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditLoaiHinh(string id)
        {
            var list = new QuanLyTour.Model.LoaiHinhDuLichModel();
            var listById = QuanLyTour.Model.LoaiHinhDuLichModel.findLHDLByID(list.getAll(), id);


            return View(listById);
        }

        [HttpPost]
        public ActionResult EditLoaiHinh(QuanLyTour.Model.LoaiHinhDuLichModel model)
        {
            try
            {
                model.UpdateDB();

                return RedirectToAction("LoaiHinh");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteLoaiHinh(string id)
        {
            var list = new QuanLyTour.Model.LoaiHinhDuLichModel();
            var listById = QuanLyTour.Model.LoaiHinhDuLichModel.findLHDLByID(list.getAll(), id);


            return View(listById);
        }

        [HttpPost]
        public ActionResult DeleteLoaiHinh(string id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                var list = new QuanLyTour.Model.LoaiHinhDuLichModel();
                var listById = QuanLyTour.Model.LoaiHinhDuLichModel.findLHDLByID(list.getAll(), id);

                if( listById.DeleteToDB() == false)
                {
                    MessageBox.Show("Xóa thất bại do đang được sử dụng!!!", "Xóa Thất Bại");
                }
               

                return RedirectToAction("LoaiHinh");
            }
            catch
            {
                return View();
            }
        }

        //------------------------------------------------------------------------------
        public ActionResult LoaiChiPhi()
        {
            var loaiCP = new QuanLyTour.Models.LoaiChiPhiModel().getAll();

            return View(loaiCP);
        }


        public ActionResult createLCP()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createLCP(QuanLyTour.Models.LoaiChiPhiModel model)
        {
            try
            {
                model.MaLoaiChiPhi = "MCP" + (QuanLyTour.Models.LoaiChiPhiModel.getCount() + 1);

                model.InserToDB();

                return RedirectToAction("LoaiChiPhi");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult EditLoaiChiPhi(string id)
        {
            var list = new QuanLyTour.Models.LoaiChiPhiModel();
            var listById = QuanLyTour.Models.LoaiChiPhiModel.findLCPByID(list.getAll(), id);


            return View(listById);
        }

        [HttpPost]
        public ActionResult EditLoaiChiPhi(QuanLyTour.Models.LoaiChiPhiModel model)
        {
            try
            {
                model.UpdateDB();

                return RedirectToAction("LoaiChiPhi");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteLoaiChiPhi(string id)
        {
            var list = new QuanLyTour.Models.LoaiChiPhiModel();
            var listById = QuanLyTour.Models.LoaiChiPhiModel.findLCPByID(list.getAll(), id);


            return View(listById);
        }

        [HttpPost]
        public ActionResult DeleteLoaiChiPhi(string id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                var list = new QuanLyTour.Models.LoaiChiPhiModel();
                var listById = QuanLyTour.Models.LoaiChiPhiModel.findLCPByID(list.getAll(), id);

                if (listById.DeleteToDB() == false)
                {
                    MessageBox.Show("Xóa thất bại do đang được sử dụng!!!", "Xóa Thất Bại");
                }


                return RedirectToAction("LoaiChiPhi");
            }
            catch
            {
                return View();
            }
        }
        //-----------------------------------------------------------------

        public ActionResult DiaDiem()
        {
            var diadiem = new QuanLyTour.Models.DiaDiemModel().getAll();

            return View(diadiem);
        }

        public ActionResult createDD()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createDD(QuanLyTour.Models.DiaDiemModel model)
        {
            try
            {
                model.MaDiaDiem = "DD" + (QuanLyTour.Models.DiaDiemModel.getCount() + 1);

                model.InserToDB();

                return RedirectToAction("DiaDiem");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditDiaDiem(string id)
        {
            var list = new QuanLyTour.Models.DiaDiemModel();
            var listById = QuanLyTour.Models.DiaDiemModel.findDDByID(list.getAll(), id);


            return View(listById);
        }

        [HttpPost]
        public ActionResult EditDiaDiem(QuanLyTour.Models.DiaDiemModel model)
        {
            try
            {
                model.UpdateDB();

                return RedirectToAction("DiaDiem");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteDiaDiem(string id)
        {
            var list = new QuanLyTour.Models.DiaDiemModel();
            var listById = QuanLyTour.Models.DiaDiemModel.findDDByID(list.getAll(), id);


            return View(listById);
        }

        [HttpPost]
        public ActionResult DeleteDiaDiem(string id, System.Web.Mvc.FormCollection collection)
        {
            try
            {
                var list = new QuanLyTour.Models.DiaDiemModel();
                var listById = QuanLyTour.Models.DiaDiemModel.findDDByID(list.getAll(), id);

                if (listById.DeleteToDB() == false)
                {
                    MessageBox.Show("Xóa thất bại do đang được sử dụng!!!", "Xóa Thất Bại");
                }


                return RedirectToAction("DiaDiem");
            }
            catch
            {
                return View();
            }
        }
        //-----------------------------------------------------------------

        public ActionResult ThongKe()
        {
            var data = QuanLyTour.DAL.GiaTourDAL.ThongKeTongDoanhThu();
            ViewData["Message"] = data;
            return View();
        }

        //-----------------------------------------------------------------
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