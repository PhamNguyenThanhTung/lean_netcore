using Microsoft.AspNetCore.Mvc;

namespace d1.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult hi()
        {
            string[] products = { "Laptop", "Mouse", "Keyboard", "Monitor" };
            ViewData["Products"] = products;
            return View();
        }
        public IActionResult Goodbye()
        {
            ViewData["ProductName"] = "Laptop Gaming XYZ";
            ViewData["Price"] = 30000000;
            return View();
        }
    }
}
