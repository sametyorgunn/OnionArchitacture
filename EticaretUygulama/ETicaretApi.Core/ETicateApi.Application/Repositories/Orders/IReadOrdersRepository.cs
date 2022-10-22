using ETicaretApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicateApi.Application.Repositories.Orders
{
    public interface IReadOrdersRepository:IReadRepository<Order>
    {
    }
}
