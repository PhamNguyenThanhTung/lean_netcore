using Microsoft.AspNetCore.Mvc;
using WebApp_Day8.Models;

namespace WebApp_Day8.Controllers
{
    public class ProductController : Controller
    {
        private readonly EShopV10 eShopV10;

        public ProductController(EShopV10 context)
        {
            eShopV10 = context;
        }
        public IActionResult Index()
        {
            var products = eShopV10.Products.ToList();
            return View(products);
        }
    }
}
