using ETicaretApi.Domain.Entities;
using ETicaretApi.Presistence.Contexts;
using ETicateApi.Application.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Presistence.Repositories.Products
{
    public class ProductReadRepository : ReadRepository<Product>, IReadProductRepository
    {
        public ProductReadRepository(ETicaretApiDbContext eTicaretApiDbContext) : base(eTicaretApiDbContext)
        {
        }
    }
}
