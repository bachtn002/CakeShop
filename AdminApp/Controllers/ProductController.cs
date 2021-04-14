using CakeShop.Admin.IntegrateBackendAPI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IManageProductApi _manageProductApi;
        public ProductController(IManageProductApi  manageProductApi)
        {
            _manageProductApi = manageProductApi;
        }
        public IActionResult Index()
        {
            var product = _manageProductApi.GetAllProduct();
            return View(product);
        }
    }
}
