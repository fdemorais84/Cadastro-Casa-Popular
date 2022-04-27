using CadastroCasaPopular.Data.Context;
using CadastroCasaPopular.Domain.Interfaces;
using CadastroCasaPopular.Domain.Services;
using CasaPopular.Data.Repository;
using CasaPopular.Domain.Interfaces;
using CasaPopular.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CasaPopular.Api
{
    public static class DependencyInjectionSetup
    {

        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<CasaPopularDbContext>();
            services.AddScoped<ICasaPopularRepository, CasaPopularRepository>();
            services.AddScoped<ICasaPopularService, CasaPopularService>();
            services.AddScoped<ICalculaRendaService, CalculaRendaService>();
            services.AddScoped<ICalculaDependenteService, CalculaDependenteService>();


            return services;
        }

    }
}
