using Microsoft.Extensions.DependencyInjection;
using PresentationLibrary.Configurations;

namespace PresentationLibrary.Extensions
{
    public static class AdminLTEStaticsExtensions
    {
        public static IServiceCollection AddAdminLTEStatics(this IServiceCollection services)
        {
            services.ConfigureOptions<AdminLTEStaticsConfigureOptions>();

            return services;
        }
    }
}