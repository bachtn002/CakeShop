using CakeShop.Admin.IntegrateBackendAPI;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Admin.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductApi _productApi;
        public ProductController(IProductApi productApi)
        {
            _productApi = productApi;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data = _productApi.GetAllProduct();
            return View(data);
        }
        
    }
}
