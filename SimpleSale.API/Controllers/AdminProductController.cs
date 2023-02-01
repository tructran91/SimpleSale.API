using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.API.Extensions;
using SimpleSale.API.ViewModels.Category;
using SimpleSale.API.ViewModels.Product;
using SimpleSale.Application.Interfaces;
using SimpleSale.Application.Services;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.API.Controllers
{
    [Route("api/admin/product")]
    [ApiController]
    public class AdminProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<AdminProductController> _logger;
        private readonly IMapper _mapper;

        public AdminProductController(IProductService productService, ILogger<AdminProductController> logger, IMapper mapper)
        {
            _productService = productService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var products = await _productService.GetProductsAsync();
                var productsConverted = _mapper.Map<List<ProductResponseViewModel>>(products);

                return Ok(productsConverted);
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
                var product = await _productService.GetProductAsync(id);
                if (product == null)
                {
                    return NotFound();
                }

                var productConverted = _mapper.Map<ProductResponseViewModel>(product);

                return Ok(productConverted);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Get action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductRequestViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var product = _mapper.Map<Product>(model);
                product.Slug = product.Name.Slugify();

                var productCreated = await _productService.CreateAsync(product);

                return Ok(productCreated.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Post action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(Guid id, [FromBody] CategoryRequestViewModel model)
        //{
        //    try
        //    {
        //        if (model == null)
        //        {
        //            return BadRequest("Model is null");
        //        }

        //        var category = await _categoryService.GetCategoryAsync(Guid.Parse(model.Id));
        //        if (category == null)
        //        {
        //            return NotFound();
        //        }

        //        var mapperCategory = _mapper.Map(model, category);
        //        mapperCategory.Slug = mapperCategory.Name.Slugify();

        //        await _categoryService.UpdateAsync(mapperCategory);

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Something went wrong inside the Put action: {ex}");
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
        //    }
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(Guid id)
        //{
        //    try
        //    {
        //        await _categoryService.DeleteAsync(id);

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Something went wrong inside the Delete action: {ex}");
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
        //    }
        //}
    }
}
