using Microsoft.AspNetCore.Mvc;
using ProductsManagement.Domain.Contracts.Repositories;
using ProductsManagement.Domain.Contracts.Services;

namespace ProductsManagement.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Find()
        {
            var categories = await _service.FindAllAsync();

            return Ok(categories);
        }
    }
}
