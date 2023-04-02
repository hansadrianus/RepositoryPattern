using Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
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
                new AppMenu { Id = 2, MenuController = "Sales", MenuAction = "CreateSalesOrder", MenuOrder = 1, MenuLevel = 1, MenuName = "Create Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new AppMenu { Id = 3, MenuController = "Sales", MenuAction = "ChangeSalesOrder", MenuOrder = 2, MenuLevel = 1, MenuName = "Change Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new AppMenu { Id = 4, MenuController = "Sales", MenuAction = "DisplaySalesOrder", MenuOrder = 3, MenuLevel = 1, MenuName = "Display Sales Order", CssClass = "", MenuParent = 1, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            );

            builder.Entity<LanguageCulture>().HasData(
                new LanguageCulture { Id = 1, LCID = 1033, Description = "English", IsDefaultLanguage = true, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new LanguageCulture { Id = 2, LCID = 1057, Description = "Indonesia", IsDefaultLanguage = false, CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            );

            builder.Entity<OrderType>().HasData(
                new OrderType { Id = 1, Name = "Cash", CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new OrderType { Id = 2, Name = "Credit", CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 },
                new OrderType { Id = 3, Name = "Split Payment", CreatedBy = "", CreatedTime = DateTime.UtcNow, RowStatus = 0 }
            );
        }

        public static async Task SeedDevelopmentData(this WebApplication? app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
                await SeedUsersAsync(userManager);
                await SeedRolesAsync(roleManager);
                await AssignUserRolesAsync(userManager, roleManager);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            scope.Dispose();
        }

        private static async Task SeedUsersAsync(UserManager<ApplicationUser> userManager)
        {
            var adminUser = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@admin.com",
                FirstName = "Admin",
                LastName = "Admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (!await userManager.Users.AnyAsync(u => u.UserName == adminUser.UserName))
                await userManager.CreateAsync(adminUser, "Password123!@#");

            var normalUser = new ApplicationUser
            {
                UserName = "user",
                Email = "user@user.com",
                FirstName = "User",
                LastName = "User",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (!await userManager.Users.AnyAsync(u => u.UserName == normalUser.UserName))
                await userManager.CreateAsync(normalUser, "Password123!@#");
        }

        private static async Task SeedRolesAsync(RoleManager<ApplicationRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Administrator"))
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Administrator" });
            if (!await roleManager.RoleExistsAsync("Sales Order Create"))
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Sales Order Create" });
            if (!await roleManager.RoleExistsAsync("Sales Order View"))
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Sales Order View" });
            if (!await roleManager.RoleExistsAsync("Sales Order Change"))
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Sales Order Change" });
        }

        private static async Task AssignUserRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            var admin = await userManager.FindByNameAsync("admin");
            await userManager.AddToRoleAsync(admin, "Administrator");
            var user = await userManager.FindByNameAsync("user");
            await userManager.AddToRoleAsync(user, "Sales Order Create");
            await userManager.AddToRoleAsync(user, "Sales Order View");
            await userManager.AddToRoleAsync(user, "Sales Order Change");
        }
    }
}
