using Application.Interfaces.Persistence;
using Application.Interfaces.Services;
using Domain.Entities;
using Infrastructure.Persistence.Localizations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using System.Globalization;
using System.Reflection;

namespace Infrastructure.Services
{
    public class LocalizeService : ILocalizeService
    {
        private readonly IStringLocalizer _localizer;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationContext _context;

        public LocalizeService(IStringLocalizerFactory factory, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager, IApplicationContext context)
        {
            Type type = typeof(GlobalResource);
            AssemblyName assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("GlobalResource", assemblyName.Name);
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _context = context;
        }

        public LocalizedString GetLocalizedHtmlString(string key)
        {
            int lcid = _httpContextAccessor.HttpContext.Session.GetInt32("CultureInfoSession") != null ? (int)_httpContextAccessor.HttpContext.Session.GetInt32("CultureInfoSession") : 1033;
            CultureInfo.CurrentCulture = new CultureInfo(lcid);
            CultureInfo.CurrentUICulture = new CultureInfo(lcid);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lcid);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lcid);
            LocalizedString value = _localizer[key];
            return value;
        }
    }
}
