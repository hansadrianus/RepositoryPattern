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
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Configuration;
using System.Runtime.InteropServices;
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

            services.AddTransient<IEmailService, EmailService>();
            services.AddSingleton<IDateTimeService, DateTimeService>();
            services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>));
            services.AddScoped<IEntityMapperService, EntityMapperService>();
            services.AddScoped<IQueryBuilderService, QueryBuilderService>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IAutoGenerateNumberService, AutoGenerateNumberService>();

            return services;
        }

        public static IConfigurationBuilder AddSharedConfiguration(this IConfigurationBuilder configBuilder, IHostEnvironment hostEnvironment)
        {
            var environment = hostEnvironment.EnvironmentName;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                configBuilder.AddJsonFile(Path.Combine(hostEnvironment.ContentRootPath, "..", "Shared", "appsettings.json"), false, true)
                    .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "..", "Shared", $"appsettings.{environment}.json"), true, true);
            }
            else
            {
                configBuilder.AddJsonFile(Path.Combine(hostEnvironment.ContentRootPath, "..", "src", "Shared", "appsettings.json"), false, true)
                    .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "..", "src", "Shared", $"appsettings.{environment}.json"), true, true);
            }

            return configBuilder;
        }

        public static IServiceCollection AddSwaggerGenForJWT(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Repository.Api",
                    Version = "v1",
                    Description = "Repository Main API",
                    Contact = new OpenApiContact
                    {
                        Name = "Hans Adrianus H"
                    }
                });
                c.ResolveConflictingActions(apiDescription => apiDescription.First());
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });

            return services;
        }

        public static IServiceCollection ConfigureCookies(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetSection("AuthConfig");
            double expireTime = (string.IsNullOrEmpty(config["tokenExpiresInMinutes"])) ? 5 : double.Parse(config["tokenExpiresInMinutes"]);
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(opt =>
                {
                    opt.ExpireTimeSpan = TimeSpan.FromMinutes(expireTime);
                    opt.Cookie.MaxAge = opt.ExpireTimeSpan;
                    opt.SlidingExpiration = true;
                    opt.EventsType = typeof(CookiesAuthenticationConfiguration);
                });
            services.AddTransient<CookiesAuthenticationConfiguration>();

            return services;
        }

        public static IServiceCollection ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<ApplicationUser, ApplicationRole>(opt =>
            {
                opt.Password.RequireDigit = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;
                opt.Password.RequireNonAlphanumeric = true;
                opt.Password.RequiredLength = 8;
                opt.Password.RequiredUniqueChars = 1;
                opt.User.RequireUniqueEmail = true;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(3650);
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.AllowedForNewUsers = false;
                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                opt.User.RequireUniqueEmail = true;
            })
            .AddRoles<ApplicationRole>()
            .AddEntityFrameworkStores<ApplicationContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();

            return services;
        }

        public static IServiceCollection ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new TokenValidationConfiguration(configuration).DefaultTokenConfiguration();
            });

            return services;
        }

        public static IServiceCollection ConfigureSession(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetSection("AuthConfig");
            double expireTime = (string.IsNullOrEmpty(config["tokenExpiresInMinutes"])) ? 5 : double.Parse(config["tokenExpiresInMinutes"]);
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(expireTime);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            return services;
        }
    }
}
