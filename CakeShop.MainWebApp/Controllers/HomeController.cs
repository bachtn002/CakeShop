using CakeShop.MainWebApp.IntergrateAPI;
using CakeShop.MainWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CakeShop.MainWebApp.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProduct _product;

        public HomeController(ILogger<HomeController> logger, IProduct product)
        {
            _logger = logger;
            _product = product;
        }

        public async Task<IActionResult> Index()
        {
            var product = await _product.GetAllProduct();
            return View(product);
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Shopdetails()
        {
            return View();
        }
        public IActionResult Shoppingcart()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
