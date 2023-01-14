using Application.Interfaces.Attributes;
using Application.Interfaces.Persistence;
using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Domain.Entities;
using Infrastructure.Attributes;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Configurations;
using Infrastructure.Services;
using Infrastructure.Wrappers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        private static readonly Regex InterfacePattern = new Regex("I(?:.+)DataService", RegexOptions.Compiled);

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<ApplicationContext>()
                .AddScoped<IApplicationContext, ApplicationContext>();

            (from c in typeof(Application.DependencyInjection).Assembly.GetTypes()
             where c.IsInterface && InterfacePattern.IsMatch(c.Name)
             from i in typeof(DependencyInjection).Assembly.GetTypes()
             where c.IsAssignableFrom(i)
             select new
             {
                 Contract = c,
                 Implementation = i
             }).ToList()
            .ForEach(x => services.AddScoped(x.Contract, x.Implementation));

            services.AddSingleton<IDateTimeService, DateTimeService>();
            services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>));
            services.AddScoped<IEntityMapperService, EntityMapperService>();
            services.AddScoped<IQueryBuilderService, QueryBuilderService>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            return services;
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<ApplicationUser, IdentityRole>(q =>
            {
                q.Password.RequireDigit = true;
                q.Password.RequireLowercase = true;
                q.Password.RequireUppercase = true;
                q.Password.RequireNonAlphanumeric = true;
                q.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ApplicationContext>()
            .AddDefaultTokenProviders();
        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationConfiguration(configuration).DefaultTokenConfiguration();
            });
        }
    }
}
