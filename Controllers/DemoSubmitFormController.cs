using Microsoft.AspNetCore.Mvc;

namespace DemoMvcApp.Controllers

{
    public class DemoSubmitFormController : Controller
    {
        // Hiển thị form
        public ActionResult Hello()
        {
            return View();
        }

        // Nhận dữ liệu khi submit form
        [HttpPost]
        public ActionResult Hello(string fullName)
        {
            ViewBag.Message = "Xin chào " + fullName;
            return View();
        }
    }
}