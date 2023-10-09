using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    //[Authorize(Policy = "AdminPolicy")] // Requires the "admin" role
    [ApiController]
    [Route("[controller]")]

    public class ProductController : ControllerBase
    {
        UserManager<AppUser> _userManager;
        private readonly IProductRepository _ProductRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository ProductRepository, IMapper mapper, UserManager<AppUser> userManager)
        {
            _ProductRepository = ProductRepository;
            _mapper = mapper;
            _userManager = userManager;
        }



        [Authorize(Roles = "Manager")]
        [HttpPost]
        public async Task<IActionResult> CreateProductAsync([FromBody] ProductDto ProductDto)
        {
            if (ProductDto == null)
            {
                return BadRequest("Invalid Product data.");
            }

            var Product = _mapper.Map<ProductDto, Product>(ProductDto);
            await _ProductRepository.AddProductAsync(ProductDto.UserId, Product);
            return Ok(Product);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllProductsAsync(string? searchTerm)
        {
            IReadOnlyList<Product> Products;

            if (searchTerm is null)
            {
                Products = await _ProductRepository.GetAllProductsAsync();
            }
            else
            {
                Products = await _ProductRepository.FindProductAsync(x => x.Name.Contains(searchTerm));
            }

            if (Products == null)
            {
                return NotFound();
            }

            var ProductsDto = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductDto>>(Products);
            return Ok(ProductsDto);
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductAsyncById(int Id)
        {

            var product = await _ProductRepository.GetByIdAsync(Id);
            if (product == null)
            {
                return NotFound();
            }

            //var ProductDto = _mapper.Map<Product, ProductDto>(Product);
            return Ok(product);
        }

        [Authorize(Roles = "Manager")]
        [HttpPut("{ProductId}")]
        public async Task<ActionResult> UpdateProductAsync(int ProductId, [FromBody] ProductDto ProductDto)
        {
            var existingProduct = await _ProductRepository.GetByIdAsync(ProductId);
            _mapper.Map(ProductDto, existingProduct);
            await _ProductRepository.UpdateProduct(existingProduct);

            return Ok(existingProduct);
        }




        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            //var existingProduct = await _ProductRepository.GetByIdAsync(id);

            //if (existingProduct == null)
            //{
            //    return NotFound();
            //}

            await _ProductRepository.DeleteProduct(id);

            return Ok();
        }

    }
}

