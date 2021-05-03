using CakeShop.Admin.IntegrateBackendAPI;
using CakeShop.Admin.Models;
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
        
        private readonly IManageProductApi _manageProductApi;
        public ProductController(IManageProductApi  manageProductApi)
        {
            _manageProductApi = manageProductApi;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var product = await _manageProductApi.GetAllProduct();
            
            return View(product);
        }
    }
}
