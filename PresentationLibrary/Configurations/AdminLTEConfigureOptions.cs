using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace PresentationLibrary.Configurations
{
    public sealed class AdminLTEConfigureOptions : IConfigureOptions<AdminLTEOptions>
    {
        private readonly IHostingEnvironment _environment;

        public IConfiguration Configuration { get; }

        public AdminLTEConfigureOptions(IHostingEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            Configuration = configuration;
        }

        public void Configure(AdminLTEOptions options)
        {
            Configuration.GetSection("WebPx:Templates:AdminLTE")?.Bind(options);
        }
    }
}