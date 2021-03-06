﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimuladoMurex.Application.Services;
using SimuladoMurex.Domain.Interfaces.Repositories;
using SimuladoMurex.Domain.Interfaces.Services;
using SimuladoMurex.Infra.Data.Context;
using SimuladoMurex.Infra.Data.Repositories;

namespace SimuladoMurex.Infra.IoC
{
    public static class DependencyInjectConfig
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SimuladoMurexContext>(option => option
                                                               .UseMySql("server=127.0.0.1;user id=root;pwd=raca1981;database=simuladomurex",
                                                                                m => m.MigrationsAssembly("SimuladoMurex.Infra.Data")));

            services.AddDbContext<CustomersContext>(option => option
                                                               .UseMySql("server=127.0.0.1;user id=root;pwd=raca1981;database=customers",
                                                                                m => m.MigrationsAssembly("SimuladoMurex.Infra.Data")));

            services.AddScoped<IMoRepository, MoRepository>();

            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddTransient<IOperationsService, OperationsService>();

            services.BuildServiceProvider();

        }
    }
}
