using QuanLyVeSo.Data.Dao;
using QuanLyVeSo.Data.EntityFramework;
using System.Web.Mvc;


namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class CongNoController : Controller
    {
        // GET: Admin/CongNo

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
            var model = CongNoDao.Instance.ListPaged(pageNumber, query);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CongNo entity)
        {
            if (ModelState.IsValid)
            {
                if (CongNoDao.Instance.Create(entity))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới công nợ không thành công");
                }
            }
            return View();
        }

        public ActionResult Detail(int id)
        {
            var model = CongNoDao.Instance.GetSingle(id);
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var model = CongNoDao.Instance.GetSingle(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CongNo model)
        {
            if (ModelState.IsValid)
            {
                if (CongNoDao.Instance.Update(model))
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
        public JsonResult Delete(int id)
        {
            var result = CongNoDao.Instance.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}