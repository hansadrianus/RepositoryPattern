using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForeignKeyForSalesOrderDetailEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderDetail_Product_ProductId",
                table: "SalesOrderDetail");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "3504c8e3-a138-4b7d-bb65-6405aeb22d11");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "eb5a05ab-e82f-429f-9421-3f2a0f18e4a9");

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "46f236d7-3aa6-438c-864f-eda7192efd8c", 0, "a965186b-6bdd-4fed-b94c-e5d0cd6c9289", "", new DateTime(2023, 1, 27, 13, 56, 7, 815, DateTimeKind.Utc).AddTicks(5340), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEGvhfht0z7NBk/Vep8VfeDalyt2H8K/z2fAMOo6lcKB3JMTjlxEIYIEypETPnk70jQ==", null, false, null, (short)0, "5e0af822-2cab-4c23-b135-60cc51dac6fc", null, false, "user" },
                    { "ac06307d-75a4-4ed2-8fdc-579e162cbc04", 0, "42d26b2f-0f39-4b10-9418-6763009bf599", "", new DateTime(2023, 1, 27, 13, 56, 7, 535, DateTimeKind.Utc).AddTicks(9394), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEHgW9A2j+io+gjdyVaPN6+4SIwL3309t1Y/5mEMXej+lY9V4lVCWcghYnWSb0MKPrw==", null, false, null, (short)0, "33262c5d-6d8f-46cb-a457-2a1873e355c5", null, false, "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderDetail_Product_ProductId",
                table: "SalesOrderDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderDetail_Product_ProductId",
                table: "SalesOrderDetail");

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
                    { "3504c8e3-a138-4b7d-bb65-6405aeb22d11", 0, "7229a7b4-1c66-496c-ab7a-16a7ba85b00b", "", new DateTime(2023, 1, 27, 11, 27, 45, 703, DateTimeKind.Utc).AddTicks(7838), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEGWFVrPs9sMl9ITIAoH23oAl6eHZjTyUW00M+3ntOOmpajrZSLAknNJELyAqdzTnVQ==", null, false, null, (short)0, "b11d36c0-c725-4e96-b898-abe651a1909f", null, false, "user" },
                    { "eb5a05ab-e82f-429f-9421-3f2a0f18e4a9", 0, "60ea8a94-adbd-456b-9c6a-7782279e86f0", "", new DateTime(2023, 1, 27, 11, 27, 45, 571, DateTimeKind.Utc).AddTicks(6319), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEGeWzTbw1Jqw5nWYWqTttK4d47WR5IPmhWkz3T/T874EZzVRxa77ecwNCclEw+A0JQ==", null, false, null, (short)0, "742f5a39-1db9-4828-b334-2224060a6fe4", null, false, "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderDetail_Product_ProductId",
                table: "SalesOrderDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
