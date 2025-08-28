using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcdemo.Models;

namespace MvcDemoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Đây là trang Index của HomeController";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Đây là trang About của HomeController";
            return View();
        }
    }
    
}
