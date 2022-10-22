using ETicaretApi.Domain.Entities;
using ETicaretApi.Presistence.Contexts;
using ETicateApi.Application.Repositories.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Presistence.Repositories.Customers
{
    public class CustomerWriteRepository : WriteRepository<Customer>, IWriteCustomersRepository
    {
        public CustomerWriteRepository(ETicaretApiDbContext context) : base(context)
        {
        }
    }
}
