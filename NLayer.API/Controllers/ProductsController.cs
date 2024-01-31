using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _productService;

        public ProductsController(IService<Product> productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
            
        }

        public async Task<IActionResult> All()
        {

            var products = await _productService.GetAllAsync();
            var productDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return Ok(CustomResponseDto<List<ProductDto>>.Success(200, productDtos));
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
