using Application.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace WebMVC.Helpers
{
    public static class MenuHelper
    {
        public static string RenderMenu(this IHtmlHelper html, IApplicationContext context, IList<string> userRoles)
        {
            string htmlTag = "";
            try
            {
                if (userRoles.Contains("Administrator"))
                    htmlTag += RenderMenuAdministrator(html, context);
                else if (context.MenuRoles.Include("Role").Any())
                    htmlTag += RenderMenuCommon(html, context, userRoles);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return htmlTag;
        }

        private static string SetAnchorRef(AppMenu menu)
        {
            string anchorRefString = "href='#'";
            if (menu.MenuLevel != 0 && !string.IsNullOrEmpty(menu.MenuAction))
            {
                anchorRefString = string.Format("href='{0}/{1}'", menu.MenuController, menu.MenuAction);
            }

            return anchorRefString;
        }

        private static string RenderMenuAdministrator(this IHtmlHelper html, IApplicationContext context)
        {
            string htmlTag = "";
            List<AppMenu> menuList = context.AppMenu.Where(menu => menu.MenuLevel == 0).OrderBy(menu => menu.MenuOrder).ToList();
            foreach (AppMenu menu in menuList)
            {
                htmlTag += string.Format(@"<li class='nav-item {4}'>
                                                <a {1} class='nav-link'>
                                                <i class='nav-icon {3}'></i>
                                                <p>
                                                    {0}
                                                    <i class='right fas fa-angle-left'></i>
                                                </p>
                                            </a>
                                            {2}
                                        </li>", menu.MenuName, SetAnchorRef(menu), html.SetChildMenuAdministrator(context, menu), menu.CssClass, HtmlHelper.IsMenuOpen(html, menu.MenuController));
            }

            return htmlTag;
        }

        private static string RenderMenuCommon(this IHtmlHelper html, IApplicationContext context, IList<string> userRoles)
        {
            string htmlTag = "";
            List<AppMenu> menuList = context.AppMenu.Where(q => q.MenuLevel == 0).OrderBy(menu => menu.MenuOrder).ToList();
            foreach (AppMenu menu in menuList)
            {
                string childHtmlTag = html.SetChildMenuCommon(context, menu, userRoles);
                if (!string.IsNullOrEmpty(childHtmlTag))
                    htmlTag += string.Format(@"<li class='nav-item {4}'>
                                                    <a {1} class='nav-link'>
                                                    <i class='nav-icon {3}'></i>
                                                    <p>
                                                        {0}
                                                        <i class='right fas fa-angle-left'></i>
                                                    </p>
                                                </a>
                                                {2}
                                            </li>", menu.MenuName, SetAnchorRef(menu), childHtmlTag, menu.CssClass, HtmlHelper.IsMenuOpen(html, menu.MenuController));
            }

            return htmlTag;
        }

        private static string SetChildMenuAdministrator(this IHtmlHelper html, IApplicationContext context, AppMenu menu)
        {
            string childMenuString = "<ul class='nav nav-treeview'>";
            List<AppMenu> childMenuList = context.AppMenu.Where(child => child.MenuParent == menu.Id).OrderBy(child => child.MenuOrder).ToList();
            if (childMenuList != null || childMenuList.Count > 0)
            {
                foreach (AppMenu childMenu in childMenuList)
                {
                    childMenuString += string.Format(@"<li class='nav-item'>
                                                            <a {1} class='nav-link'>
                                                                <i class='far fa-circle nav-icon'></i>
                                                                <p>{0}</p>
                                                            </a>
                                                        </li>", childMenu.MenuName, SetAnchorRef(childMenu), HtmlHelper.IsActive(html, childMenu.MenuController, childMenu.MenuAction));
                }
            }
            childMenuString += "</ul>";

            return childMenuString;
        }

        private static string SetChildMenuCommon(this IHtmlHelper html, IApplicationContext context, AppMenu menu, IList<string> userRoles)
        {
            string finalChildMenuString = "";
            string beginChildMenuString = "<ul class='nav nav-treeview'>";
            string endChildMenuString = "</ul>";
            if (context.MenuRoles.Include(q => q.Role).Any())
            {
                string childMenuString = "";
                List<AppMenuRole> menuRoles = context.MenuRoles.Include(q => q.Role).Where(q => userRoles.Contains(q.Role.Name)).ToList();
                List<AppMenu> childMenuList = context.AppMenu.Where(q => menuRoles.Select(x => x.AppMenuId).Contains(q.Id) && q.MenuParent == menu.Id).OrderBy(child => child.MenuOrder).ToList();
                if (childMenuList != null || childMenuList.Count > 0)
                    foreach (AppMenu childMenu in childMenuList)
                        childMenuString += string.Format(@"<li class='nav-item'>
                                                            <a {1} class='nav-link'>
                                                                <i class='far fa-circle nav-icon'></i>
                                                                <p>{0}</p>
                                                            </a>
                                                        </li>", childMenu.MenuName, SetAnchorRef(childMenu), HtmlHelper.IsActive(html, childMenu.MenuController, childMenu.MenuAction));
                if (!string.IsNullOrEmpty(childMenuString))
                    finalChildMenuString = string.Format("{0}{1}{2}", beginChildMenuString, childMenuString, endChildMenuString);
            }

            return finalChildMenuString;
        }
    }
}
