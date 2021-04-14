using CakeShop.Service.Products.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CakeShop.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("get-all-product")]
        public async Task<IActionResult> GetAllProduct()
        {
            var product = await _productService.GetAllProductService();
            return Ok(product);
        }
        [HttpGet("get-product-by-category-id")]
        public async Task<IActionResult> GetAllProductByCategoryId(int categoryId, string languageId)
        {
            var product = await _productService.GetProductByCategoryId(categoryId, languageId);

            return Ok(product);
        }
        [HttpGet("get-product-by-id")]
        public async Task<IActionResult> GetProductById(int productId, string languageId)
        {
            var product = await _productService.GetById(productId, languageId);
            if (product == null) return BadRequest($"Cannot find product {productId}");
            return Ok(product);
        }

    }
}
