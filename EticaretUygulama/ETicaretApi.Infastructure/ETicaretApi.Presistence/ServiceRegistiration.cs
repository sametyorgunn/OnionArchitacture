using ETicaretApi.Presistence.Concrete;
using ETicaretApi.Presistence.Contexts;
using ETicateApi.Application.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ETicateApi.Application.Repositories.Products;
using ETicaretApi.Presistence.Repositories.Products;
using ETicaretApi.Presistence.Repositories.Customers;
using ETicateApi.Application.Repositories.Customers;
using ETicateApi.Application.Repositories.Orders;
using ETicaretApi.Presistence.Repositories.Orders;

namespace ETicaretApi.Presistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //ConfigurationManager configurationManager = new();
            //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretApi.Api"));
            //configurationManager.AddJsonFile("appsettings.json");
            //string connectionstring = configurationManager.GetConnectionString("PostgreSQL");


            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<ETicaretApiDbContext>(Options => Options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=ETicaretApiDb;"),ServiceLifetime.Scoped);


            services.AddScoped<IReadProductRepository, ProductReadRepository>();
            services.AddScoped<IWriteProductRepository,ProductsWriteRepository>();

            services.AddScoped<IReadCustomersRepository, CustomerReadRepository>();
            services.AddScoped<IWriteCustomersRepository, CustomerWriteRepository>();

            services.AddScoped<IReadOrdersRepository, OrdersReadRepository>();
            services.AddScoped<IWriteOrdersRepository, OrdersWriteRepository>();

           


        }
    }
}
