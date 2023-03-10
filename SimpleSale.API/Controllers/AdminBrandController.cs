using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.API.Extensions;
using SimpleSale.API.Models.Brands;
using SimpleSale.Application.DTOs.Brands;
using SimpleSale.Application.Exceptions;
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

                return Ok(brands);
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

                return Ok(brand);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Get action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BrandRequestModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var brand = _mapper.Map<BrandDto>(model);

                var brandCreated = await _brandService.CreateAsync(brand);

                return Ok(brandCreated);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside the Post action: {ex}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] BrandRequestModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("Model is null");
                }

                var brand = _mapper.Map<BrandDto>(model);

                await _brandService.UpdateAsync(brand);

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
