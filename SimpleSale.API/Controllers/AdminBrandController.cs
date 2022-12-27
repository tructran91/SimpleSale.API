using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.API.Extensions;
using SimpleSale.API.ViewModels;
using SimpleSale.Application.DTOs;
using SimpleSale.Application.Interfaces;
using SimpleSale.Application.Services;
using SimpleSale.Core.Entities.Catalog;
using System.Drawing.Drawing2D;
using System.Net;

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
                var brands = await _brandService.GetBrands();
                var brandsConverted = _mapper.Map<List<BrandViewModel>>(brands);

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
                var brand = await _brandService.GetBrand(new BrandCriteriaDto
                {
                    Id= id
                });

                var brandConverted = _mapper.Map<BrandViewModel>(brand);

                return Ok(brandConverted);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Get action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BrandViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var brand = _mapper.Map<Brand>(model);
                brand.Slug = brand.Name.Slugify();

                var brandCreated = await _brandService.Create(brand);

                return Ok(brandCreated.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Post action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] BrandViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var brand = _mapper.Map<Brand>(model);
                brand.Slug = brand.Name.Slugify();

                await _brandService.Update(brand);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Put action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
