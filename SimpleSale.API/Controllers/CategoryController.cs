using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.API.ViewModels;
using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleSale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<CategoryController> _logger;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, ILogger<CategoryController> logger, IMapper mapper)
        {
            _categoryService = categoryService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var categories = await _categoryService.GetCategoryList();
            var categoryDto = _mapper.Map<IEnumerable<CategoryViewModel>>(categories);

            return Ok(categoryDto);
        }

    }
}
