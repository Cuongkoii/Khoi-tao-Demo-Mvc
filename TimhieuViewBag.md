1️⃣ Tìm hiểu về ViewBag trong MVC
🔹 ViewBag là gì?

ViewBag dùng để truyền dữ liệu từ Controller sang View

Kiểu dynamic (không cần khai báo kiểu)

Chỉ tồn tại trong 1 request

🔹 Cú pháp

Controller

ViewBag.Message = "Xin chào MVC";


View (.cshtml)

<h2>@ViewBag.Message</h2>

2️⃣ Ví dụ sử dụng ViewBag gửi dữ liệu từ Controller về View
📁 Controllers → tạo DemoController.cs
using System.Web.Mvc;

namespace BaiThucHanh.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello + Nguyễn Văn A - MSV001";
            return View();
        }
    }
}

📁 Views/Demo/Index.cshtml
<h2>@ViewBag.Message</h2>


👉 Truy cập:

/Demo/Index