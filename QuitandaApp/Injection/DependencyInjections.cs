using Microsoft.Extensions.DependencyInjection;
using Quitanda.Repository;
using Quitanda.Repository.Context;
using Quitanda.Repository.Interface;
using Quitanda.Services.Base;
using Quitanda.Services.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quitanda.API.Injection
{
    public static class DependencyInjections
    {
        public static void AddDependencyInjections(this IServiceCollection services)
        {
           
            services.AddScoped<IFrutaService, FrutaService>();
            services.AddScoped<IFrutaRepository, FrutaRepository>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IUserRepository, UserRepository>();
            services.AddSingleton<DataContext>();
        }
    }
}
