using Microsoft.Extensions.DependencyInjection;
using PresentationLibrary.Configurations;

namespace PresentationLibrary.Extensions
{
    public static class AdminLTESharedStaticsExtensions
    {
        public static IServiceCollection AddAdminLTESharedStatics(this IServiceCollection services, Action<AdminLTESettings> configure = null)
        {
            services.ConfigureOptions<AdminLTESharedStaticsConfigureOptions>();
            if (configure != null)
                services.Configure(configure);
            return services;
        }
    }
}