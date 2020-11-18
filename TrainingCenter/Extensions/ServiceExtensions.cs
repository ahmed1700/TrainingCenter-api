﻿using Contracts;
using LoggerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Entitites;
using Entitites.DBContext;
using Microsoft.EntityFrameworkCore;

namespace TrainingCenter.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
                ///--------------
            });

        public static void ConfiureLoggerServices(this IServiceCollection services) =>
           services.AddScoped<ILoggerManager, LoggerManager>();
        public static void ConfigureSqlContext(this IServiceCollection services , IConfiguration configuration)
          => services.AddDbContext<RepositoryContext>(
              opt => opt.UseSqlServer(configuration.GetConnectionString("sqlConnection") ,
                  b=> b.MigrationsAssembly("TrainingCenter") ));
      

    }
}