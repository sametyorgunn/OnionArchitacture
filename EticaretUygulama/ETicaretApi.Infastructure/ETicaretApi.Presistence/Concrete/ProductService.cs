using ETicaretApi.Domain.Entities;
using ETicateApi.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Presistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
        {

             new() {Id=Guid.NewGuid(),Name="Product",Price=100,Stock=10},
             new() {Id=Guid.NewGuid(),Name="Product",Price=100,Stock=10},
             new() {Id=Guid.NewGuid(),Name="Product",Price=100,Stock=10},
             new() {Id=Guid.NewGuid(),Name="Product",Price=100,Stock=10},
             new() {Id=Guid.NewGuid(),Name="Product",Price=100,Stock=10},
             new() {Id=Guid.NewGuid(),Name="Product",Price=100,Stock=10}




        };
    }
}

