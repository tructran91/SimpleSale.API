using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.API.Extensions;
using SimpleSale.API.Models.Categories;
using SimpleSale.Application.DTOs.Brands;
using SimpleSale.Application.DTOs.Categories;
using SimpleSale.Application.Exceptions;
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

                return Ok(categories);
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

                return Ok(category);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Get action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryRequestModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var category = _mapper.Map<CategoryDto>(model);

                var categoryCreated = await _categoryService.CreateCategoryAsync(category);

                return Ok(categoryCreated);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Post action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CategoryRequestModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var category = _mapper.Map<CategoryDto>(model);

                await _categoryService.UpdateCategoryAsync(category);

                return Ok();
            }
            catch (NotFoundException ex)
            {
                _logger.LogError($"{ex}");
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Put action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
