using System;
using Contracts;
using Dominio.Contracts;
using Dominio.Impl;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Servicios.Contracts;
using Servicios.Implem;

namespace api.Extensions
{
    public static class ServiceExtensions
    { 

       public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }


        public static void ConfigureServices(this IServiceCollection services)
        {

            services.AddScoped(typeof(IServicio<>), typeof(Servicio<>));
            services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ITipoEventoServicio, TipoEventoServicio>();
            services.AddScoped<IDetalleEstadisticaServicio, DetalleEstadisticaServicio>();
            services.AddScoped<IDetalleEstadisticaPorEnlaceServicio, DetalleEstadisticaPorEnlaceServicio>();

        }

    }
}
