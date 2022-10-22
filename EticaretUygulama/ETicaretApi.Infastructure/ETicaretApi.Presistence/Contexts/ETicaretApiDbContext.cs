using ETicaretApi.Domain.Entities;
using ETicaretApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Presistence.Contexts
{
    public class ETicaretApiDbContext : DbContext
    {
        public ETicaretApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Customer>customers { get; set; }
        public DbSet<Order> orders { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach(var i in datas)
            {
                _ = i.State switch
                {
                    EntityState.Added => i.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => i.Entity.UpdatedDate = DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
