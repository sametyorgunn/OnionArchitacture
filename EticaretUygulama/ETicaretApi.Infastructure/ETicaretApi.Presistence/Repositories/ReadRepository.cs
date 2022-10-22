using ETicaretApi.Domain.Entities.Common;
using ETicaretApi.Presistence.Contexts;
using ETicateApi.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Presistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretApiDbContext _eTicaretApiDbContext;

        public ReadRepository(ETicaretApiDbContext eTicaretApiDbContext)
        {
            _eTicaretApiDbContext = eTicaretApiDbContext;
        }

        public DbSet<T> Table => _eTicaretApiDbContext.Set<T>();

        public IQueryable<T> GetAll(bool tracking=true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }


        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        /*await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));*/
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data=>data.Id==Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking=true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking=true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
