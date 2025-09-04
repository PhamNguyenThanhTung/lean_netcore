using Microsoft.AspNetCore.Mvc;

namespace BT03_adminPage.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Dashboard";
            // Truyền dữ liệu động tương tự như JSP EL:
            ViewData["countUsers"] = 123;
            ViewData["countProducts"] = 456;
            ViewData["countOrders"] = 789;
            ViewData["LoggedInUser"] = "Tung"; // Tên người dùng đăng nhập
            return View();
        }
    }
}
