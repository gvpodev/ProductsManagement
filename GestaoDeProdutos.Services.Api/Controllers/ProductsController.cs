using Microsoft.AspNetCore.Mvc;
using ProductsManagement.Application.Services.Contracts;

namespace ProductsManagement.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductAppService? _productAppService;

        public ProductsController(IProductAppService? productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public IActionResult FindAll() => StatusCode(200, _productAppService?.FindAll());
    }
}
