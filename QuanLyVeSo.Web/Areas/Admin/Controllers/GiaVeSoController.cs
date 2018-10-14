using QuanLyVeSo.Data.EntityFramework;
using System.Web.Mvc;

namespace QuanLyVeSo.Web.Areas.Admin.Controllers
{
    public class GiaVeSoController : Controller
    {
        // GET: Admin/GiaVeSo
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GiaVeSo model)
        {
            return View();
        }

    }
}