using ETicaretApi.Domain.Entities;
using ETicateApi.Application.Abstract;
using ETicateApi.Application.Repositories.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly IProductService _productService;
        private readonly IReadProductRepository _readProductRepository;
        private readonly IWriteProductRepository _writeProductRepository;

        public ProductsController(IReadProductRepository readProductRepository, IWriteProductRepository writeProductRepository)
        {
            _readProductRepository = readProductRepository;
            _writeProductRepository = writeProductRepository;
        }


        //[HttpGet]
        //public IActionResult GetProducts()
        //{
        //   var products  = _productService.GetProducts();
        //    return Ok(products);
        //}
        [HttpGet]
        public async Task Get()
        {
            await _writeProductRepository.AddRangeAsync(new(){
                new() {Id=Guid.NewGuid(),Name="samedov",Price=100,Stock=10 },
                new() {Id=Guid.NewGuid(),Name="seko2",Stock=20,Price=30 },
                new() {Id=Guid.NewGuid(),Name="aslan 3",Price=300,Stock=30 }

            });
            await _writeProductRepository.SaveChanges();



        }
      
    }
}
