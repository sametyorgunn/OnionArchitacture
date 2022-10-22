using ETicaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicateApi.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T :BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> data);
        bool RemoveRange(List<T> model);
        Task<bool> RemoveAsync(string id);
        bool remove(T model);
        bool Update(T model);
        Task<int> SaveChanges();

    }
}
