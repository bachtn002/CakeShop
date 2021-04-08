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
        private readonly IProductService _context;
        public ProductController(IProductService context)
        {
            _context = context;
        }

        [HttpGet("get-product")]
        // Default URL of HttpGet: http
        public async Task<IActionResult> GetAll()
        {
            var product = await _context.GetAll();
            return Ok(product);
        }
        [HttpGet("get-product-by-category-id")]
        public async Task<IActionResult> GetAllProductByCategoryId(int categoryId, string languageId)
        {
            var product = await _context.GetProductByCategoryId(categoryId, languageId);

            return Ok(product);
        }
        [HttpGet("get-product-by-id")]
        public async Task<IActionResult> GetProductById(int productId, string languageId)
        {
            var product = await _context.GetById(productId, languageId);
            if (product == null) return BadRequest($"Cannot find product {productId}");
            return Ok(product);
        }

    }
}
