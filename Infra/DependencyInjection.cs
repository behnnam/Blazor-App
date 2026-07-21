using Application.Interfaces.repository;
using Application.Interfaces.service;
using Application.Services;
using Infra.persistent;
using Infra.Repositores;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
