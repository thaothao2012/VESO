using System.Web.Mvc;

namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class CongNoController : Controller
    {
        // GET: Admin/CongNo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(CongNo entity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (CongNoDao.Instance.Create(entity))
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Thêm mới đại lý không thành công");
        //        }
        //    }
        //    return View();
        //}
    }
}