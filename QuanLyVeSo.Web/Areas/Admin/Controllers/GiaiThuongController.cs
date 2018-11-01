using QuanLyVeSo.Data.Dao;
using QuanLyVeSo.Data.EntityFramework;
using System.Web.Mvc;

namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class GiaiThuongController : Controller
    {

        // GET: Admin/GiaiThuong
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
            var model = GiaiThuongDao.Instance.ListPaged(pageNumber, query);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GiaiThuong entity)
        {
            if (ModelState.IsValid)
            {
                if (GiaiThuongDao.Instance.Create(entity))
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
            var model = GiaiThuongDao.Instance.GetSingle(id);
            return View(model);
        }

        public JsonResult Delete(string id)
        {
            var result = GiaiThuongDao.Instance.Delete(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(string id)
        {
            var model = GiaiThuongDao.Instance.GetSingle(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(GiaiThuong model)
        {
            if (ModelState.IsValid)
            {
                if (GiaiThuongDao.Instance.Update(model))
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