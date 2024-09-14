using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceServer.Application.Repository;
using ECommerceServer.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController( IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task GetProducts()
        {
           // await _productWriteRepository.AddRangeAsync(new()
           //  {
           //      new() { Id = Guid.NewGuid(), Name = "Product1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 10 },
           //      new() { Id = Guid.NewGuid(), Name = "Product2", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 22 },
           //      new() { Id = Guid.NewGuid(), Name = "Product3", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 30 },
           //  });
           // await _productWriteRepository.SaveAsync();
           
           // Product product=await _productReadRepository.GetByIdAsync("d1b6e05b-833f-49f5-b6c3-f3114f518ec3",false );
           // product.Name = "Soysal2";
           Product product=await _productReadRepository.GetByIdAsync("d1b6e05b-833f-49f5-b6c3-f3114f518ec3");
           product.Name = "Soysal";
           await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductId(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
        
    }
}
