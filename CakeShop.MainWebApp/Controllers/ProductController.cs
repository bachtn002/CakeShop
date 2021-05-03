using CakeShop.MainWebApp.IntergrateAPI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.MainWebApp.Controllers
{

    public class ProductController : Controller
    {
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var product = await _product.GetAllProduct();
            return View(product);
        }
    }
}
