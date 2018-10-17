using QuanLyVeSo.Data.Dao;
using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class PhieuThuController : Controller
    {
        // GET: Admin/PhieuThu
        public ActionResult Index(int? page, string query, string currentFilter)
        {
            if (query != null)
            {
                page = 1;
            }
            else
            {
                query = currentFilter;
            }
            ViewBag.CurrentFilter = query;
            var pageNumber = page ?? 1;
            var model = PhieuThuDao.Instance.ListPaged(pageNumber, query);
            return View(model);
        }
        public ActionResult Create()
        {
            //ViewBag.MaDaiLy = new SelectList(DaiLyDao.Instance.AllDaiLys(), "MaDaiLy","TemDaiLy");
            //SelectList(IEnumberable,value cua option, cái hiển thị lên dropdown)
            ViewBag.MaDaiLy = new SelectList(DaiLyDao.Instance.AllDaiLys(), "MaDaiLy", "MaDaiLy");
            return View();
        }
        [HttpPost]
        public ActionResult Create(PhieuThu entity,FormCollection collection)
        {
            
            if (ModelState.IsValid)
            {
                entity.MaDaiLy = collection["TenDaiLy"].ToString();
                if (PhieuThuDao.Instance.Create(entity))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới phiếu thu không thành công");
                }
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var model = PhieuThuDao.Instance.GetSingle(id);
            ViewBag.DanhSachMa = new SelectList(DaiLyDao.Instance.AllDaiLys(), "MaDaiLy", "MaDaiLy",model.MaDaiLy);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(PhieuThu entity,FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                entity.MaDaiLy = collection["TenList"].ToString();
                if (PhieuThuDao.Instance.Update(entity))
                {
                   return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật phiếu thu không thành công!");
                }
            }
            return View();
        }
        public ActionResult Detail(int id)
        {
            return View(PhieuThuDao.Instance.GetSingle(id));
        }
        public JsonResult Delete(int id)
        {
            var result = PhieuThuDao.Instance.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}