using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    public class CookiesAuthenticationConfiguration : CookieAuthenticationEvents
    {
        private const string TicketIssuedTicks = nameof(TicketIssuedTicks);
        private readonly IConfiguration _configuration;

        public CookiesAuthenticationConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public override async Task SigningIn(CookieSigningInContext context)
        {
            context.Properties.SetString(TicketIssuedTicks, DateTimeOffset.UtcNow.Ticks.ToString());

            await base.SigningIn(context);
        }

        public override async Task ValidatePrincipal(CookieValidatePrincipalContext context)
        {
            var ticketIssuedTicksValue = context.Properties.GetString(TicketIssuedTicks);
            if (ticketIssuedTicksValue is null || !long.TryParse(ticketIssuedTicksValue, out long ticketIssuedTicks))
            {
                await RejectPrincipalAsync(context);

                return;
            }

            var config = _configuration.GetSection("AuthConfig");
            double expireTime = (string.IsNullOrEmpty(config["refreshTokenExpiresInMinutes"])) ? 30 : double.Parse(config["refreshTokenExpiresInMinutes"]);
            DateTimeOffset ticketIssuedUtc = new DateTimeOffset(ticketIssuedTicks, TimeSpan.FromMinutes(0));
            if (DateTimeOffset.UtcNow - ticketIssuedUtc > TimeSpan.FromMinutes(expireTime))
            {
                await RejectPrincipalAsync(context);

                return;
            }

            await base.ValidatePrincipal(context);
        }

        private static async Task RejectPrincipalAsync(CookieValidatePrincipalContext context)
        {
            context.RejectPrincipal();
            await context.HttpContext.SignOutAsync();
        }
    }
}
