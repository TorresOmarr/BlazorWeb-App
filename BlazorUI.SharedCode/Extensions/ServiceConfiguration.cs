

using BlazorUI.SharedCode.Data;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorUI.SharedCode.Extensions
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection  AddServices(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();

            return services;
        }

    }
}
