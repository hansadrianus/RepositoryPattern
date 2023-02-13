using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using PresentationLibrary.Configurations;
using PresentationLibrary.Interfaces;

namespace PresentationLibrary.Extensions
{
    public static class AdminLTEExtensions
    {
        public static IServiceCollection AddAdminLTE(this IServiceCollection services, Action<AdminLTEOptions> configure = null)
        {
            services.ConfigureOptions<AdminLTEConfigureOptions>();
            services.AddOptions<RazorViewEngineOptions>()
                .Configure<IOptions<AdminLTEOptions>>((options, settings) =>
                {
                    options.ViewLocationExpanders.Add(new AdminLTEViewLocationExpander(settings));
                });
            if (configure != null)
                services.Configure(configure);
            services.TryAddScoped<IAdminLTE, AdminLTE>();

            return services;
        }
    }
}
