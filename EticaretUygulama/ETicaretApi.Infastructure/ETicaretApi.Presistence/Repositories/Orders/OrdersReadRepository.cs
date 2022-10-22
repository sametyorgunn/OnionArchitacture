using ETicaretApi.Domain.Entities;
using ETicaretApi.Presistence.Contexts;
using ETicateApi.Application.Repositories;
using ETicateApi.Application.Repositories.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Presistence.Repositories.Orders
{
    public class OrdersReadRepository : ReadRepository<Order>, IReadOrdersRepository
    {
        public OrdersReadRepository(ETicaretApiDbContext eTicaretApiDbContext) : base(eTicaretApiDbContext)
        {
        }
    }
}
