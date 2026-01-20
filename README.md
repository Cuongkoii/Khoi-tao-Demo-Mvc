**1. Tìm hiểu cấu trúc thư mục của dự án .Net MVC:**
   Dự án ASP.NET Core MVC có cấu trúc thư mục cơ bản như sau:
DemoMvcApp

-Controllers
    + HomeController.cs

-Models
    + ErrorViewModel.cs

-Views
        + Home
            Index.cshtml
        + Shared
            Layout.cshtml
            Error.cshtml
            ViewImports.cshtml
            ViewStart.cshtml
           
─ wwwroot
     + css
     + js
     + lib

─ appsettings.json
─ appsettings.Development.json
─ Program.cs
─ DemoMvcApp.csproj
🔹 Controllers
-Chứa các Controller xử lý request từ người dùng.
-Mỗi controller là một lớp C#.
-Ví dụ: HomeController.cs
-Controller sẽ nhận request, xử lý logic và trả về View.
🔹 Models
-Chứa các lớp mô tả dữ liệu và nghiệp vụ.
-Dùng để truyền dữ liệu giữa Controller và View.
-Ví dụ: ErrorViewModel.cs
🔹 Views
-Chứa các file giao diện .cshtml.
-Mỗi Controller có một thư mục View tương ứng.
-Ví dụ:
-HomeController → Views/Home/Index.cshtml
-Thư mục Shared:
-Chứa các View dùng chung cho toàn bộ ứng dụng.
_Layout.cshtml là layout chính (header, footer, menu).
🔹 wwwroot
-Chứa các tài nguyên tĩnh:
-CSS
-JavaScript
-Hình ảnh
-Đây là thư mục duy nhất cho phép truy cập trực tiếp từ trình duyệt.
🔹 Program.cs
-File cấu hình và khởi động ứng dụng.
-Khai báo routing, middleware, dịch vụ.
-Là điểm bắt đầu chạy của ứng dụng MVC.
🔹 appsettings.json
-Chứa cấu hình ứng dụng:
-Chuỗi kết nối CSDL
-Cấu hình logging
-appsettings.Development.json dùng cho môi trường phát triển.
🔹 File .csproj
-File cấu hình project:
-Phiên bản .NET
-Các package sử dụng
-Thiết lập build


**2.Định tuyến (Routing) trong ASP.NET Core MVC **

2.1 Khái niệm định tuyến (Routing)
Routing trong ASP.NET Core MVC là cơ chế ánh xạ URL từ trình duyệt tới:
Controller
Action tương ứng trong ứng dụng
Nhờ có Routing, ứng dụng xác định được:
Request URL → Controller → Action

2.2 Định tuyến mặc định (Convention-based Routing)
Định tuyến mặc định được cấu hình trong file Program.cs:
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
📌 Ý nghĩa:
controller=Home: Controller mặc định là HomeController
action=Index: Action mặc định là Index()
id?: Tham số tùy chọn

2.3 Cách hoạt động của Routing
Ví dụ URL:
https://localhost:5001/Demo/Index/5
➡️ ASP.NET MVC sẽ:
Gọi DemoController
Thực thi phương thức Index(int id)
id = 5

2.4 Attribute Routing (Định tuyến bằng thuộc tính)
Ngoài định tuyến mặc định, ASP.NET MVC còn hỗ trợ Attribute Routing bằng cách gán route trực tiếp trên Controller hoặc Action.
Ví dụ:

[Route("demo")]
public class DemoController : Controller
{
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }
}

➡️ Truy cập bằng URL:
/demo/index

2.5 So sánh hai loại Routing
Loại Routing,	Đặc điểm
Convention-based Routing	Định tuyến theo quy ước, dễ sử dụng
Attribute Routing	Linh hoạt, kiểm soát URL tốt hơn

2.6 Vai trò của Routing trong MVC
Kết nối URL với Controller và Action
Giúp URL rõ ràng, thân thiện với người dùng
Dễ bảo trì và mở rộng ứng dụng
✅ Kết luận
Routing là thành phần quan trọng trong ASP.NET Core MVC, giúp điều hướng request từ người dùng đến đúng Controller và Action. 
Việc sử dụng Routing hợp lý giúp ứng dụng hoạt động hiệu quả và dễ phát triển.

3. Controller và View trong ASP.NET Core MVC 
3.1 Controller
Là lớp C# nhận và xử lý request từ người dùng
Chứa các Action (phương thức public)
Điều hướng và trả về View

Ví dụ:

public class DemoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

3.2 View
Là giao diện hiển thị cho người dùng
Viết bằng Razor (.cshtml)
Nhận dữ liệu từ Controller
Vị trí View:
Views/Demo/Index.cshtml
Ví dụ:

<h2>Hello ASP.NET MVC</h2>

Quan hệ giữa Controller và View
URL → Controller → Action → View
Mỗi Action thường có một View tương ứng
Kết luận
Controller xử lý logic và điều hướng, View chịu trách nhiệm hiển thị giao diện. Hai thành phần phối hợp giúp ứng dụng web MVC hoạt động rõ ràng và dễ bảo trì.
