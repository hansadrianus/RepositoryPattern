using API.Services;
using Application;
using Application.Interfaces.Persistence;
using Application.Interfaces.Services;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;

namespace API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // TODO: Remove this line if you want to return the Server header
            builder.WebHost.ConfigureKestrel(options => options.AddServerHeader = false);
            builder.Configuration.AddSharedConfiguration(builder.Environment);

            builder.Services.AddSingleton(builder.Configuration);
            // Adds in Application dependencies
            builder.Services.AddApplication(builder.Configuration);
            // Adds in Infrastructure dependencies
            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddAuthentication();
            builder.Services.ConfigureIdentity();
            builder.Services.ConfigureJWT(builder.Configuration);

            builder.Services.AddHttpContextAccessor();
            builder.Services.AddHealthChecks();

            builder.Services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = ApiVersion.Default;
            });

            builder.Services.AddScoped<IPrincipalService, PrincipalService>();

            builder.Services.AddControllers();
            builder.Services.AddSwaggerGenForJWT();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Repository.Api v1"));
                app.SeedDevelopmentData();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.Use(async (httpContext, next) =>
            {
                var apiMode = httpContext.Request.Path.StartsWithSegments("/api");
                if (apiMode)
                {
                    httpContext.Request.Headers[HeaderNames.XRequestedWith] = "XMLHttpRequest";
                }
                await next();
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/health");
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}