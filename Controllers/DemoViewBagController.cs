using Microsoft.AspNetCore.Mvc;

namespace DemoMvcApp.Controllers
{
    public class DemoViewBagController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello + Cao Quý Cường - MSV 2121051489";
            return View();
        }
    }
}