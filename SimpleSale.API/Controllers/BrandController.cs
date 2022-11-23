using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleSale.Application.Interfaces;

namespace SimpleSale.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly ILogger<BrandController> _logger;
        private readonly IMapper _mapper;

        public BrandController(IBrandService brandService, ILogger<BrandController> logger, IMapper mapper)
        {
            _brandService = brandService;
            _logger = logger;
            _mapper = mapper;
        }
    }
}
