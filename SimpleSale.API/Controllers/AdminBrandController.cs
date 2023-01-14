﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.API.Extensions;
using SimpleSale.API.ViewModels.Brand;
using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.API.Controllers
{
    [Route("api/admin/brand")]
    [ApiController]
    public class AdminBrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly ILogger<AdminBrandController> _logger;
        private readonly IMapper _mapper;

        public AdminBrandController(IBrandService brandService, ILogger<AdminBrandController> logger, IMapper mapper)
        {
            _brandService = brandService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var brands = await _brandService.GetBrandsAsync();
                var brandsConverted = _mapper.Map<List<BrandResponseViewModel>>(brands);

                return Ok(brandsConverted);
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
                var brand = await _brandService.GetBrandAsync(id);
                if (brand == null)
                {
                    return NotFound();
                }

                var brandConverted = _mapper.Map<BrandResponseViewModel>(brand);

                return Ok(brandConverted);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Get action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BrandRequestViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var brand = _mapper.Map<Brand>(model);
                brand.Slug = brand.Name.Slugify();

                var brandCreated = await _brandService.CreateAsync(brand);

                return Ok(brandCreated.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Post action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] BrandRequestViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var brand = await _brandService.GetBrandAsync(Guid.Parse(model.Id));
                if (brand == null)
                {
                    return NotFound();
                }
                brand.Name= model.Name;
                brand.Slug = model.Name.Slugify();
                brand.IsPublished = model.IsPublished;
                brand.LatestUpdatedOn = DateTime.UtcNow;

                await _brandService.UpdateAsync(brand);

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
                await _brandService.DeleteAsync(id);

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
