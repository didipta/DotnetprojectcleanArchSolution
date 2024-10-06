using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Appliction.Services.Implementation;

namespace Dotnetprojectclean.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]

    public class productController : ControllerBase
    {
        private readonly ProductServices _productService;

        public productController(ProductServices productService)
        {
            _productService = productService;
        }
        // GET: api/product
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAllAsync();
            
            return Ok(
                new
                {
                    data = products.Data,
                    message = products.Message,
                    success = products.Success
                }
                );
        }

        // GET: api/product/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok("Get product by id");
        }

        // POST: api/product
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok("Create a product");
        }

        // PUT: api/product/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok("Update a product");
        }

        // DELETE: api/product/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Delete a product");
        }
    }
}
