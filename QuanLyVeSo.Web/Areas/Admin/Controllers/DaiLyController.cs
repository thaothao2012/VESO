using QuanLyVeSo.Data.Dao;
using QuanLyVeSo.Data.EntityFramework;
using System.Web.Mvc;

namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class DaiLyController : Controller
    {
        // GET: Admin/DaiLy
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
            var model = DaiLyDao.Instance.ListPaged(pageNumber, query);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DaiLy entity)
        {
            if (ModelState.IsValid)
            {
                if (DaiLyDao.Instance.Create(entity))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới đại lý không thành công");
                }
            }
            return View();
        }


        public ActionResult Detail(string id)
        {
            var model = DaiLyDao.Instance.GetSingle(id);
            return View(model);
        }


        public JsonResult ChangeStatus(string id)
        {
            var result = DaiLyDao.Instance.ChangeStatus(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(string id)
        {
            var result = DaiLyDao.Instance.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(string id)
        {
            var model = DaiLyDao.Instance.GetSingle(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(DaiLy model)
        {
            if (ModelState.IsValid)
            {
                if (DaiLyDao.Instance.Update(model))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật đại lý không thành công");
                }
            }
            return View(model);
        }

    }
}