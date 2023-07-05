using Microsoft.AspNetCore.Mvc;
using ProductsManagement.Application.Dtos.Responses;
using ProductsManagement.Application.Services;

namespace ProductsManagement.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryAppService _service;

        public CategoriesController(ICategoryAppService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Find()
        {
            return StatusCode(200, _service.FindAll());
        }
    }
}
