using AutoMapper;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.API.Extensions;
using SimpleSale.API.Models.Products;
using SimpleSale.API.Validators;
using SimpleSale.Application.DTOs.Products;
using SimpleSale.Application.Exceptions;
using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        [HttpPost("query")]
        public async Task<IActionResult> Query([FromBody] ProductCriteriaViewModel criteria)
        {
            try
            {
                var validateResult = ModelValidator.Validate(criteria);
                if (!validateResult.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, validateResult.Errors.ConvertFailureToString());
                }

                var productCriteria = _mapper.Map<ProductCriteriaDto>(criteria);

                var products = await _productService.QueryProductsAsync(productCriteria);
                return Ok(products);
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

                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Get action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductRequestModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var product = _mapper.Map<ProductDto>(model);

                var productCreated = await _productService.CreateProductAsync(product);

                return Ok(productCreated);
            }
            catch (DuplicateException ex)
            {
                _logger.LogError($"{ex}");
                return StatusCode(StatusCodes.Status409Conflict, ex.Message);
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
