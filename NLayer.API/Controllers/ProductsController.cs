using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{

    public class ProductsController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _productService;

        public ProductsController(IService<Product> productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
            
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {

            var products = await _productService.GetAllAsync();
            var productDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productDtos));
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {

            var products = await _productService.GetByIdAsync(id);
            var productDtos = _mapper.Map<ProductDto>(products);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDtos));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {

            var products = await _productService.AddAsync(_mapper.Map<Product>(productDto));
            var productDtos = _mapper.Map<ProductDto>(products);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productDtos)); //Status 201:Created
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {

            await _productService.UpdateAsync(_mapper.Map<Product>(productDto));
            
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204)); //Status 204:No Content
        }

        //Delete api/products/5
        [HttpDelete("id")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _productService.GetByIdAsync(id);

            //if (product == null)
            //{
            //    return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "No Product with this Id"));

            //}
            await _productService.RemoveAsync(product);
            
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
