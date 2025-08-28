using Microsoft.AspNetCore.Mvc;


namespace MvcDemoApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            ViewBag.Message = "Đây là danh sách sản phẩm (List Action)";
            return View();
        }

        public IActionResult Detail()
        {
            ViewBag.Message = "Đây là chi tiết sản phẩm (Detail Action)";
            return View();
        }
    }
}
