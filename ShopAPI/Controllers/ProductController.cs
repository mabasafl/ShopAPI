using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Interfaces;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProducts _productService;

        public ProductController(IProducts productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("products")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var result = await _productService.GetAllProductsAsync();

                if (result == null)
                    return NotFound(new {Message="No products available."});
                return Ok(result);
            }
            catch(Exception ex)
            {
                return Content(ex.Message);
            }
        }

        [HttpGet]
        [Route("product")]
        public async Task<IActionResult> GetProductAsync(int productId)
        {
            try
            {
                var result = await _productService.GetProductAsync(productId);

                //did this on the service instead
                /*if (result == null)
                {
                    return NotFound(new { Message = "No product available with Id " + productId + "."});
                }*/

                return Ok(new { Messaage = "Your queried Product:" + Environment.NewLine + result.ItemName });
            }
            catch(Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
