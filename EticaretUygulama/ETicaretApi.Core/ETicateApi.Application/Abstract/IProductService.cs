using ETicaretApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicateApi.Application.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
