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
            if (query == null)
            {
                page = 1;
            }
            else
            {
                query = currentFilter;
            }
            ViewBag.currentFilter = query;
            var pageNumber = page ?? 1;
            var model = PhieuThuDao.Instance.ListPaged(pageNumber, query);
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.MaDaiLy = new SelectList(DaiLyDao.Instance.AllDaiLys(), "MaDaiLy","TenDaiLy");
            //SelectList(IEnumberable,value cua option, cái hiển thị lên dropdown)
            return View();
        }
        [HttpPost]
        public ActionResult Create(PhieuThu entity)
        {
            if (ModelState.IsValid)
            {
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
            return View();
        }
        [HttpPost]
        public ActionResult Edit(PhieuThu entity)
        {
            return View();
        }

    }
}