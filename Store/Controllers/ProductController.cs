using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Features.Products;
using Store.Application.ViewModels;
using System.Threading.Tasks;

namespace Store.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getproducts")]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpPost("addproduct")]
        public async Task<IActionResult> AddProduct([FromBody]ProductViewModel product)
        {
            var res = await _productService.AddProductAsync(product);
            return Ok();
        }

        [HttpGet("getproductbycategory")]
        public async Task<IActionResult> GetProductsByCategory(int categoryId)
        {
            var products = await _productService.GetProductByCategoryAsync(categoryId);
            return Ok(products);
        }

        [HttpGet("getproductbyid")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return Ok(product);
        }

        [HttpPost("updateproduct")]
        public async Task<IActionResult> UpdateProduct(ProductViewModel product)
        {
            var res = await _productService.UpdateProductAsync(product);
            return Ok();
        }
    }
}
