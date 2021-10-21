using TestProject.BLL.Services;
using TestProject.Common.Interfaces.Repositories;
using TestProject.Common.Interfaces.Services;
using TestProject.DAL.Models;
using TestProject.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TestProject.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("TestProject", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }
        public static void RegisterDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataDbContext>(options =>
            {
                options
                .UseSqlServer(configuration.GetConnectionString("TestProjectDb"), options => options.EnableRetryOnFailure());
            });
        }
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IItemRepository, ItemRepository>();
        }
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IItemService, ItemService>();
        }
    }
}
