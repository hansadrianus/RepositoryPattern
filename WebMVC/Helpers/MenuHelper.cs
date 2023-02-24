﻿using Application.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebMVC.Helpers
{
    public static class MenuHelper
    {
        public static string renderMenu(this IHtmlHelper html, IApplicationContext context)
        {
            string htmlTag = "";
            List<AppMenu<int>> menuList = context.AppMenu.Where(menu => menu.MenuLevel == 0).OrderBy(menu => menu.MenuOrder).ToList();
            foreach (AppMenu<int> menu in menuList)
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
                                        </li>", menu.MenuName, setAnchorRef(menu), html.setChildMenu(context, menu), menu.CssClass, HtmlHelper.isMenuOpen(html, menu.MenuController));
            }

            return htmlTag;
        }

        private static string setAnchorRef(AppMenu<int> menu)
        {
            string anchorRefString = "href='#'";
            if (menu.MenuLevel != 0 && !string.IsNullOrEmpty(menu.MenuAction))
            {
                anchorRefString = string.Format("href='{0}/{1}'", menu.MenuController, menu.MenuAction);
            }

            return anchorRefString;
        }

        private static string setChildMenu(this IHtmlHelper html, IApplicationContext context, AppMenu<int> menu)
        {
            string childMenuString = "<ul class='nav nav-treeview'>";
            List<AppMenu<int>> childMenuList = context.AppMenu.Where(child => child.MenuParent == menu.Id).OrderBy(child => child.MenuOrder).ToList();
            if (childMenuList != null || childMenuList.Count > 0)
            {
                foreach (AppMenu<int> childMenu in childMenuList)
                {
                    childMenuString += string.Format(@"<li class='nav-item'>
                                                            <a {1} class='nav-link'>
                                                                <i class='far fa-circle nav-icon'></i>
                                                                <p>{0}</p>
                                                            </a>
                                                        </li>", childMenu.MenuName, setAnchorRef(childMenu), HtmlHelper.isActive(html, childMenu.MenuController, childMenu.MenuAction));
                }
            }
            childMenuString += "</ul>";

            return childMenuString;
        }
    }
}
