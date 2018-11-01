using QuanLyVeSo.Data.Dao;
using QuanLyVeSo.Data.EntityFramework;
using System.Web.Mvc;

namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class GiaVeSoController : Controller
    {
        // GET: Admin/GiaVeSo
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
            var model = GiaVeSoDao.Instance.ListPaged(pageNumber, query);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GiaVeSo entity)
        {
            if (ModelState.IsValid)
            {
                if (GiaVeSoDao.Instance.Create(entity))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới giá vé không thành công");
                }
            }
            return View();
        }


        public ActionResult Detail(int id)
        {
            var model = GiaVeSoDao.Instance.GetSingle(id);
            return View(model);
        }


        public JsonResult ChangeStatus(int id)
        {
            var result = GiaVeSoDao.Instance.ChangeStatus(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int id)
        {
            var result = GiaVeSoDao.Instance.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            var model = GiaVeSoDao.Instance.GetSingle(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(GiaVeSo model)
        {
            if (ModelState.IsValid)
            {
                if (GiaVeSoDao.Instance.Update(model))
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