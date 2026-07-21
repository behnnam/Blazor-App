using Application.Interfaces.service;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection Addapplication(this IServiceCollection services)
        {
            services.AddScoped<INewsServices, NewsServices>();
            services.AddScoped<IUsersServices, UsersServices>();
            
            return services;
        }
    }
}
