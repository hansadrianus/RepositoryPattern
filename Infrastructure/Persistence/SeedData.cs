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
            builder.Entity<AppMenu>().HasData(
                new AppMenu { Id = 1, MenuController = "Sales", MenuAction = "", MenuOrder = 0, MenuLevel = 0, MenuName = "Sales", CssClass = "fas fa-dollar-sign", CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new AppMenu {Id = 2, MenuController = "Sales", MenuAction = "CreateSalesOrder", MenuOrder = 1, MenuLevel = 1, MenuName = "Create Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new AppMenu { Id = 3, MenuController = "Sales", MenuAction = "ChangeSalesOrder", MenuOrder = 2, MenuLevel = 1, MenuName = "Change Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new AppMenu { Id = 4, MenuController = "Sales", MenuAction = "DisplaySalesOrder", MenuOrder = 3, MenuLevel = 1, MenuName = "Display Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            );

            builder.Entity<LanguageCulture>().HasData(
                new LanguageCulture { Id = 1, LCID = 1033, Description = "English", IsDefaultLanguage = true, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new LanguageCulture { Id = 2, LCID = 1057, Description = "Indonesia", IsDefaultLanguage = false, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            );

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Id = 1, FirstName = "Admin", LastName = "Admin", UserName = "admin", NormalizedUserName = "ADMIN", Email = "admin@admin.com", NormalizedEmail = "ADMIN@ADMIN.COM", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!@#"), SecurityStamp = Guid.NewGuid().ToString(), CreatedBy = "", CreatedTime = DateTime.UtcNow },
                new ApplicationUser { Id = 2, FirstName = "User", LastName = "User", UserName = "user", NormalizedUserName = "USER", Email = "user@user.com", NormalizedEmail = "USER@USER.COM", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!@#"), SecurityStamp = Guid.NewGuid().ToString(), CreatedBy = "", CreatedTime = DateTime.UtcNow }
            );

            builder.Entity<ApplicationRole>().HasData(
                new ApplicationRole { Id = 1, Name = "Administrator", NormalizedName = "ADMINISTRATOR", ConcurrencyStamp = Guid.NewGuid().ToString(), CreatedBy = "", CreatedTime = DateTime.UtcNow },
                new ApplicationRole { Id = 2, Name = "Sales Create", NormalizedName = "SALES CREATE", ConcurrencyStamp = Guid.NewGuid().ToString(), CreatedBy = "", CreatedTime = DateTime.UtcNow }
            );
        }
    }
}
