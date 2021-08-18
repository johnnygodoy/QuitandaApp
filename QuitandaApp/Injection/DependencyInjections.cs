using Microsoft.Extensions.DependencyInjection;
using Quitanda.Repository;
using Quitanda.Repository.Context;
using Quitanda.Repository.Interface;
using Quitanda.Services.Base;
using Quitanda.Services.Interface.Base;

namespace Quitanda.API.Injection
{
    public static class DependencyInjections
    {
        public static void AddDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<IFrutaService, FrutaService>();
            services.AddScoped<IFrutaRepository, FrutaRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddSingleton<DataContext>();
        }
    }
}