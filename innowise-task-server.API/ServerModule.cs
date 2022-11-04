using innowise_task_server.Application.Handlers.CommandHandlers.FridgeCommandHandlers;
using innowise_task_server.Core.Repositories;
using innowise_task_server.Core.Repositories.Base;
using innowise_task_server.Infrastructure.Data;
using innowise_task_server.Infrastructure.Repositories;
using innowise_task_server.Infrastructure.Repositories.Base;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace innowise_task_server.API
{
    public static class ServerModule
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            var builder = WebApplication.CreateBuilder();
            services.AddControllers().AddJsonOptions(
            o =>
            {
                o.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
            }); 

            services.AddEndpointsApiExplorer();
            services.AddDbContext<ServerContext>(m => m.UseSqlServer(builder.Configuration.GetConnectionString("Fridges.Data")));
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Employee.API",
                    Version = "v1"
                });
            });
            services.AddAutoMapper(typeof(Program));
            services.AddMediatR(typeof(CreateFridgeHandler).GetTypeInfo().Assembly);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IFridgeRepository, FridgeRepository>();
            services.AddTransient<IFridgeProductRepository, FridgeProductRepository>();
            services.AddTransient<IFridgeModelRepository, FridgeModelRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
