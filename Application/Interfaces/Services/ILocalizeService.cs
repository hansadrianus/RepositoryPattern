using Microsoft.Extensions.Localization;

namespace Application.Interfaces.Services
{
    public interface ILocalizeService
    {
        LocalizedString GetLocalizedHtmlString(string key);
    }
}