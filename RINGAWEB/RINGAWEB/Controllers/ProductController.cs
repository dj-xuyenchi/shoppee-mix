using Microsoft.AspNetCore.Mvc;
using RINGAWEB.Services.ProductServices;

namespace RINGAWEB.Controllers
{
    [Route("api/productv1.0/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductServices productServices = new ProductServices();
        [HttpPost("data")]
        public ActionResult getProduct([FromBody] int[] productProperties)
        {

            return Ok(productProperties);
        }
        [HttpPost("buy")]
        public ActionResult buyProduct([FromBody] int[] productProperties,[FromQuery] int productId)
        {
            return Ok(productServices.buyProduct(productProperties, productId));
        }
    }
}
