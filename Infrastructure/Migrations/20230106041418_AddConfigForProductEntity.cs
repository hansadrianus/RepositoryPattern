using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddConfigForProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "5bb4b514-1b30-4862-841d-c25c06567d51");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "b051e6f9-3ea7-430b-95d9-f80bbb967860");

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9388df66-8942-4bca-b3f4-c38aef4d380e", 0, "d24edd48-f856-4bb6-ab82-d8c1ba96945c", "", new DateTime(2023, 1, 6, 4, 14, 18, 307, DateTimeKind.Utc).AddTicks(7891), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEDWiLbi2sEnvS/zjOpL8gOJS6ClQ7LVl33N8J7d9A3O3/beYPYkLfsf3rIgtkhkliw==", null, false, null, (short)0, "da0474bf-6d9c-497c-8789-c480f9c7afa2", null, false, "user" },
                    { "dade94d2-9a5a-4cd4-9b0a-9935fb860a13", 0, "42ab1cae-d2cf-4c0d-b83b-d31317e8a0db", "", new DateTime(2023, 1, 6, 4, 14, 18, 198, DateTimeKind.Utc).AddTicks(7303), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEJH/edjLINRVRb/88nv2PNNNwEWZZBPHm5sIWynfc8lzKAJaQ8zuRjnwi0qyL4enrA==", null, false, null, (short)0, "1564bf27-47ac-47ee-bf0a-17026f63a7b0", null, false, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "9388df66-8942-4bca-b3f4-c38aef4d380e");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "dade94d2-9a5a-4cd4-9b0a-9935fb860a13");

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5bb4b514-1b30-4862-841d-c25c06567d51", 0, "1130da8d-955d-48fe-ae6c-2ab4b23fd2fd", "", new DateTime(2023, 1, 6, 4, 5, 3, 685, DateTimeKind.Utc).AddTicks(7364), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAECNCbf0G97AtGr/b0wxHcYu/4D+VU6pOjGHt7YpUFaY3cOb0S9JTziNyHBnT+CJ9Ew==", null, false, null, (short)0, "4e53d750-98e2-4a1b-9a85-85eb2607532a", null, false, "user" },
                    { "b051e6f9-3ea7-430b-95d9-f80bbb967860", 0, "4b73136a-438f-48d5-bc07-16efe70810f5", "", new DateTime(2023, 1, 6, 4, 5, 3, 462, DateTimeKind.Utc).AddTicks(6613), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEK1c6rennFg0CG+HXBnPgxn6syghyQHN5vuxROfTM2lXq+sR5pm0Og1gSWYCrKbRwQ==", null, false, null, (short)0, "c9daa821-ab26-4e8e-8726-450f36547bd9", null, false, "admin" }
                });
        }
    }
}
