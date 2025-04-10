using Tmb.Application.Services;
using Tmb.Domain.Interfaces;
using Tmb.Infrastructure.Services;

namespace Tmb.Api.Configure
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ITmbCalculadora, TmbCalculadora>();
            services.AddScoped<TmbCalculadoraService>();

            services.AddScoped<ICalculadoraImc, CalculadoraImc>();
            services.AddScoped<CalculadoraImcService>();

        }
    }
}
