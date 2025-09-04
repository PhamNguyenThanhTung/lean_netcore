using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcDemo.Models;

namespace MvcDemoApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            ViewBag.Message = "Danh sách sản phẩm - ProductController";
            return View();
        }

        public IActionResult Detail()
        {
            ViewBag.Message = "Chi tiết sản phẩm - ProductController";
            return View();
        }
    }
}