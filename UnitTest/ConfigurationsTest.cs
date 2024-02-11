using System.Runtime.InteropServices;
using System;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using Microsoft.Extensions.Configuration;

namespace UnitTest
{
    public class ConfigurationsTest
    {
        public static IConfiguration InitConfiguration()
            => new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "..", "Shared", "appsettings.json"), false, true)
                .Build();

        [Fact]
        public void ShouldContainClientId()
        {
            var myConfiguration = ConfigurationsTest.InitConfiguration();
            var clientId = myConfiguration.GetSection("AzureAd")["ClientId"];

            Assert.True(Guid.TryParse(clientId, out var theGuid));
        }

        [Fact]
        public void ShouldContainTenantId()
        {
            var myConfiguration = ConfigurationsTest.InitConfiguration();
            var tenantId = myConfiguration.GetSection("AzureAd")["TenantId"];

            Assert.True(Guid.TryParse(tenantId, out var theGuid));
        }

        [Fact]
        public void ShouldContainDomain()
        {
            var myConfiguration = ConfigurationsTest.InitConfiguration();
            var domain = $"https://{myConfiguration.GetSection("AzureAd")["Domain"]}";

            Assert.True(Uri.TryCreate(domain, UriKind.Absolute, out var uri));
        }
    }
}