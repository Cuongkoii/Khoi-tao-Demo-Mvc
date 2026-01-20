using Microsoft.AspNetCore.Mvc;

namespace DemoMvcApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello Cao Quy Cuong - 2121051489";
            return View();
        }
    }
}