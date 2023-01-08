using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnForProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "9388df66-8942-4bca-b3f4-c38aef4d380e");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "dade94d2-9a5a-4cd4-9b0a-9935fb860a13");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aad62da3-19ca-4c82-885e-e532e46133bf", 0, "7ff7af1b-2a90-417d-b20a-6ff1cab789b8", "", new DateTime(2023, 1, 8, 11, 16, 31, 105, DateTimeKind.Utc).AddTicks(4762), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEFIUeHry+oH3VceELH7MxMPhkOi7tU7DkP4U3qphquJsYzhpuOlqUeThiIAkH/FP4g==", null, false, null, (short)0, "a05e7519-b668-4087-a4e5-e4b46865cbd2", null, false, "user" },
                    { "af9bdff2-db79-4070-bb9d-c4649f17968e", 0, "c1acc183-7159-4563-a700-e287879d26ec", "", new DateTime(2023, 1, 8, 11, 16, 31, 19, DateTimeKind.Utc).AddTicks(8544), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEOkEePcecPLnNOEE14vTAMb6wDiL3UwaLmp4QTbmsNJemufJx7IPGyOidck2ydbIIg==", null, false, null, (short)0, "2c819da7-9298-4228-9141-ab270d4331e5", null, false, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "aad62da3-19ca-4c82-885e-e532e46133bf");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "af9bdff2-db79-4070-bb9d-c4649f17968e");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Product");

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9388df66-8942-4bca-b3f4-c38aef4d380e", 0, "d24edd48-f856-4bb6-ab82-d8c1ba96945c", "", new DateTime(2023, 1, 6, 4, 14, 18, 307, DateTimeKind.Utc).AddTicks(7891), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEDWiLbi2sEnvS/zjOpL8gOJS6ClQ7LVl33N8J7d9A3O3/beYPYkLfsf3rIgtkhkliw==", null, false, null, (short)0, "da0474bf-6d9c-497c-8789-c480f9c7afa2", null, false, "user" },
                    { "dade94d2-9a5a-4cd4-9b0a-9935fb860a13", 0, "42ab1cae-d2cf-4c0d-b83b-d31317e8a0db", "", new DateTime(2023, 1, 6, 4, 14, 18, 198, DateTimeKind.Utc).AddTicks(7303), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEJH/edjLINRVRb/88nv2PNNNwEWZZBPHm5sIWynfc8lzKAJaQ8zuRjnwi0qyL4enrA==", null, false, null, (short)0, "1564bf27-47ac-47ee-bf0a-17026f63a7b0", null, false, "admin" }
                });
        }
    }
}
