using QuanLyVeSo.Data.Dao;
using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class PhieuPhatHanhController : Controller
    {
        // GET: Admin/PhieuPhatHanh
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
            var model = PhieuPhatHanhDao.Instance.ListPaged(pageNumber, query);
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PhieuPhatHanh entity)
        {
            if (ModelState.IsValid)
            {
                if (PhieuPhatHanhDao.Instance.Create(entity))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới phiếu phát hành không thành công");
                }
            }
            return View();
        }
        public ActionResult Detail(string id)
        {
            var model = DaiLyDao.Instance.GetSingle(id);
            return View(model);
        }
        public ActionResult Edit(string id)
        {
            var entity = PhieuPhatHanhDao.Instance.GetSingle(id);
            return View(entity);
        }
        [HttpPost]
        public ActionResult Edit(PhieuPhatHanh entity)
        {
            if (ModelState.IsValid)
            {
                if (PhieuPhatHanhDao.Instance.Update(entity))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật phiếu phát hành không thành công");
                }
            }
            return View(entity);
        }
    }
}