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
    public class ProductsWriteRepository : WriteRepository<Product>, IWriteProductRepository
    {
        public ProductsWriteRepository(ETicaretApiDbContext context) : base(context)
        {
        }
    }
}
