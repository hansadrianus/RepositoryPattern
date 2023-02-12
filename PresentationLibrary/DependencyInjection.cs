using Microsoft.Extensions.DependencyInjection;
using PresentationLibrary.Extensions;

namespace PresentationLibrary
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAdminLTEDependency(this IServiceCollection services)
        {
            services.AddAdminLTE((o) => {
                o.Search = true;
                o.UserPanel = true;
                o.Footer = true;
                o.SideBarCollapsed = false;
            }).AddAdminLTEStatics().AddAdminLTESharedStatics();
            services.AddSiteFeatures((o) =>
            {
                o.Name = "AdminLTE - Repository Pattern";
                o.Copyright = "Copyright &copy; {1} <a href='{2}'>{0}<a/>. All rights reserved.";
            });

            return services;
        }
    }
}
