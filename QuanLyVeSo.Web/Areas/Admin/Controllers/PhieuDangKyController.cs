using QuanLyVeSo.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class PhieuDangKyController : Controller
    {
        // GET: Admin/PhieuDangKy
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
            var model = PhieuDangKyDao.Instance.ListPaged(pageNumber, query);
            ViewBag.DanhSachTinh = new SelectList(DaiLyDao.Instance.AllDaiLys(), "MaDaiLy", "MaDaiLy");
            return View(model);
        }
    }
}