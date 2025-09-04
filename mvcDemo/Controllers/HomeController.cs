using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcDemo.Models;

namespace mvcDemo.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            ViewBag.Message = "?ây là trang Index";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "?ây là trang About";
            return View();
        }
    }
}
