using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebMVC.Helpers
{
    public static class HtmlHelper
    {
        public static string isMenuOpen(this IHtmlHelper html, string controller = null)
        {
            const string MENU_OPEN_CLASS = "menu-open";
            string actualController = (string)html.ViewContext.RouteData.Values["controller"];

            if (string.IsNullOrEmpty(controller))
                controller = actualController;

            return controller.Contains(actualController) ? MENU_OPEN_CLASS : string.Empty;
        }

        public static string isActive(this IHtmlHelper html, string controller = null, string action = null)
        {
            const string ACTIVE_CLASS = "active";
            string actualAction = (string)html.ViewContext.RouteData.Values["action"];
            string actualController = (string)html.ViewContext.RouteData.Values["controller"];

            if (string.IsNullOrEmpty(controller))
                controller = actualController;

            if (string.IsNullOrEmpty(action))
                action = actualAction;

            return controller.Contains(actualController) && action.Contains(actualAction) ? ACTIVE_CLASS : string.Empty;
        }
    }
}
