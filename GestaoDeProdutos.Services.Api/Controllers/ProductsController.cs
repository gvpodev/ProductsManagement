using Microsoft.AspNetCore.Mvc;

namespace ProductsManagement.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Find()
        {
            return Ok();
        }
    }
}
