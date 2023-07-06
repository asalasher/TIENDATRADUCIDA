using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TIENDA2.domain.Entities;
using TIENDA2.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TIENDA2.distributedServices.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("ENG", "product");
            dic.Add("FRA", "produit");

            string? a = "hola";
            var result = JsonSerializer.Deserialize<List<Producto>>(a);
            return Ok(result);
        }

        // GET api/<ProductsController>/ESP
        [HttpGet("{language}")]
        public async Task<IActionResult> Get(string language)
        {
            try
            {
                var products = await _productServices.GetAvailableProductsByLanguage(language.ToUpper());
                return Ok(products);
            }
            catch (Exception ex)
            {
                // TODO - _logger.LogError(ex.Message)
                return BadRequest("Problem when processing your request");
            }
        }

    }
}
