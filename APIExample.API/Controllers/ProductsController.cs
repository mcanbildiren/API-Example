using APIExample.Core;
using APIExample.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok("products");
        }

        [HttpPost]
        public IActionResult SaveProduct()
        {
            var response = new CustomResponse<ProductDto>() { Data = new ProductDto() { Id = 1, Name = "Kalem 1" } };
            return Created(string.Empty, response);
        }

        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteProduct()
        {
            return NoContent();
        }
    }
}
