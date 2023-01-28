using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SetOptionalProductForSalesOrderDetailEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "46f236d7-3aa6-438c-864f-eda7192efd8c");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "ac06307d-75a4-4ed2-8fdc-579e162cbc04");

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "23020204-6369-4475-9bcb-dfc2c769920f", 0, "ae2ae0e7-a87e-43fd-8a12-811becfc13dc", "", new DateTime(2023, 1, 28, 1, 17, 18, 122, DateTimeKind.Utc).AddTicks(5971), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEML5/cImLpTJcmVyjWnmPjUiEZFKwQvJePBlEB4cQ6F/zeLReTS4EuS6SZIoIdWtQQ==", null, false, null, (short)0, "6a4583b1-dce4-4ad3-b963-926fc307f739", null, false, "admin" },
                    { "945fd4ef-088b-47ab-aac1-df9860ab4d4d", 0, "721246f1-21ea-4f4b-868c-1fe4fe4a542d", "", new DateTime(2023, 1, 28, 1, 17, 18, 293, DateTimeKind.Utc).AddTicks(8704), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEL+q5/qgEuikA7T3fnOviry4vrUYYwARgKam7qlv6Hhk1Tl2Tlr368XfZC6netKMPg==", null, false, null, (short)0, "fdb4761e-5091-44d5-aebd-59a9c933756b", null, false, "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "23020204-6369-4475-9bcb-dfc2c769920f");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "945fd4ef-088b-47ab-aac1-df9860ab4d4d");

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "46f236d7-3aa6-438c-864f-eda7192efd8c", 0, "a965186b-6bdd-4fed-b94c-e5d0cd6c9289", "", new DateTime(2023, 1, 27, 13, 56, 7, 815, DateTimeKind.Utc).AddTicks(5340), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEGvhfht0z7NBk/Vep8VfeDalyt2H8K/z2fAMOo6lcKB3JMTjlxEIYIEypETPnk70jQ==", null, false, null, (short)0, "5e0af822-2cab-4c23-b135-60cc51dac6fc", null, false, "user" },
                    { "ac06307d-75a4-4ed2-8fdc-579e162cbc04", 0, "42d26b2f-0f39-4b10-9418-6763009bf599", "", new DateTime(2023, 1, 27, 13, 56, 7, 535, DateTimeKind.Utc).AddTicks(9394), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEHgW9A2j+io+gjdyVaPN6+4SIwL3309t1Y/5mEMXej+lY9V4lVCWcghYnWSb0MKPrw==", null, false, null, (short)0, "33262c5d-6d8f-46cb-a457-2a1873e355c5", null, false, "admin" }
                });
        }
    }
}
