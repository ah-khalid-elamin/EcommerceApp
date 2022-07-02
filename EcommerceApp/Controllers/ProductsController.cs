using EcommerceApp.Models;
using EcommerceApp.Services.ProductsServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductServices _productService;
        public ProductsController(IProductServices productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_productService.GetProducts());
        }
        [HttpGet("{id}")]
        public IActionResult GetUser([FromRoute] Guid id)
        {
            var product = _productService.GetProduct(id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound($"Product with Id:{id} was not found");

        }
        [HttpPost]
        public IActionResult GetProducts(Product product)
        {
            _productService.AddProducts(product);
            return Ok("User Created");


        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            var user = _productService.GetProduct(id);
            if (user != null)
            {
                _productService.DeleteProduct(user);
                return Ok("the user deleted");
            }
            return NotFound($"User with Id:{id} was not found");

        }
        [HttpPatch("{id}")]
        public IActionResult UpdateProduct([FromRoute] Guid id, Product product)
        {
            var existingProduct = _productService.GetProduct(id);
            if (existingProduct != null)
            {
                _productService.UpdateProduct(product);
                return Ok(product);
            }
            return NotFound($"User with Id:{id} was not found");

        }
    }
}
