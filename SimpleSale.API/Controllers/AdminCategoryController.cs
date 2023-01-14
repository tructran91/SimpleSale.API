using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.API.Extensions;
using SimpleSale.API.ViewModels.Category;
using SimpleSale.Application.Interfaces;
using SimpleSale.Application.Services;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.API.Controllers
{
    [Route("api/admin/category")]
    [ApiController]
    public class AdminCategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<AdminCategoryController> _logger;
        private readonly IMapper _mapper;

        public AdminCategoryController(ICategoryService categoryService, ILogger<AdminCategoryController> logger, IMapper mapper)
        {
            _categoryService = categoryService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var categories = await _categoryService.GetCategoriesAsync();
                var categoriesConverted = _mapper.Map<List<CategoryResponseViewModel>>(categories);

                return Ok(categoriesConverted);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Get action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var category = await _categoryService.GetCategoryAsync(id);
                if (category == null)
                {
                    return NotFound();
                }

                var categoryConverted = _mapper.Map<CategoryResponseViewModel>(category);

                return Ok(categoryConverted);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Get action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryRequestViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var category = _mapper.Map<Category>(model);
                category.Slug = category.Name.Slugify();

                var categoryCreated = await _categoryService.CreateAsync(category);

                return Ok(categoryCreated.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Post action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CategoryRequestViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var category = await _categoryService.GetCategoryAsync(Guid.Parse(model.Id));
                if (category == null)
                {
                    return NotFound();
                }

                var mapperCategory = _mapper.Map(model, category);
                mapperCategory.Slug = mapperCategory.Name.Slugify();

                await _categoryService.UpdateAsync(mapperCategory);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Put action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _categoryService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Delete action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
