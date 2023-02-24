using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public static class SeedDataExtension
    {
        public static void SeedData(this ModelBuilder builder)
        {
            // TODO: Use this file to seed the database with any initial data that
            // should exist the first time the application is run.
            builder.Entity<AppMenu<int>>().HasData(
                new AppMenu<int> { Id = 1, MenuController = "Sales", MenuAction = "", MenuOrder = 0, MenuLevel = 0, MenuName = "Sales", CssClass = "fas fa-dollar-sign", CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new AppMenu<int> {Id = 2, MenuController = "Sales", MenuAction = "CreateSalesOrder", MenuOrder = 1, MenuLevel = 1, MenuName = "Create Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new AppMenu<int> { Id = 3, MenuController = "Sales", MenuAction = "ChangeSalesOrder", MenuOrder = 2, MenuLevel = 1, MenuName = "Change Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new AppMenu<int> { Id = 4, MenuController = "Sales", MenuAction = "DisplaySalesOrder", MenuOrder = 3, MenuLevel = 1, MenuName = "Display Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            );

            builder.Entity<LanguageCulture<int>>().HasData(
                new LanguageCulture<int> { Id = 1, LCID = 1033, Description = "English", IsDefaultLanguage = true, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new LanguageCulture<int> { Id = 2, LCID = 1057, Description = "Indonesia", IsDefaultLanguage = false, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            );

            builder.Entity<ApplicationUser<string>>().HasData(
                new ApplicationUser<string> { FirstName = "Admin", LastName = "Admin", UserName = "admin", NormalizedUserName = "ADMIN", Email = "admin@admin.com", NormalizedEmail = "ADMIN@ADMIN.COM", PasswordHash = new PasswordHasher<ApplicationUser<string>>().HashPassword(null, "Password123!@#"), CreatedBy = "", CreatedTime = DateTime.UtcNow },
                new ApplicationUser<string> { FirstName = "User", LastName = "User", UserName = "user", NormalizedUserName = "USER", Email = "user@user.com", NormalizedEmail = "USER@USER.COM", PasswordHash = new PasswordHasher<ApplicationUser<string>>().HashPassword(null, "Password123!@#"), CreatedBy = "", CreatedTime = DateTime.UtcNow }
            );
        }
    }
}
