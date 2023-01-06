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

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { FirstName = "Admin", LastName = "Admin", UserName = "admin", NormalizedUserName = "ADMIN", Email = "admin@admin.com", NormalizedEmail = "ADMIN@ADMIN.COM", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!@#"), CreatedBy = "", CreatedTime = DateTime.UtcNow },
                new ApplicationUser { FirstName = "User", LastName = "User", UserName = "user", NormalizedUserName = "USER", Email = "user@user.com", NormalizedEmail = "USER@USER.COM", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!@#"), CreatedBy = "", CreatedTime = DateTime.UtcNow }
            );
        }
    }
}
