using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuAndLanguageEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "3903c9c3-4c17-4aa5-b6df-bc1ea64c2dc6");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "baab8e17-1d62-4ce4-afd8-ef7816b5d092");

            migrationBuilder.CreateTable(
                name: "AppMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuController = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuAction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuParent = table.Column<int>(type: "int", nullable: false),
                    MenuLevel = table.Column<int>(type: "int", nullable: false),
                    MenuOrder = table.Column<int>(type: "int", nullable: false),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LanguageCulture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LCID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageCulture", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppMenu",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "CssClass", "MenuAction", "MenuController", "MenuLevel", "MenuName", "MenuOrder", "MenuParent", "ModifiedBy", "ModifiedTime", "RowStatus" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(657), "fas fa-dollar-sign", "", "Sales", 0, "Sales", 0, 0, null, null, (short)0 },
                    { 2, "", new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(662), "", "CreateSalesOrder", "Sales", 1, "Create Sales Order", 1, 1, null, null, (short)0 },
                    { 3, "", new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(664), "", "ChangeSalesOrder", "Sales", 1, "Change Sales Order", 2, 1, null, null, (short)0 },
                    { 4, "", new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(666), "", "DisplaySalesOrder", "Sales", 1, "Display Sales Order", 3, 1, null, null, (short)0 }
                });

            migrationBuilder.InsertData(
                table: "LanguageCulture",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Description", "LCID", "ModifiedBy", "ModifiedTime", "RowStatus" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(838), "English", 1033, null, null, (short)0 },
                    { 2, "", new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(840), "Indonesia", 1057, null, null, (short)0 }
                });

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "99972f64-e79a-4086-b738-050a7c2d73dd", 0, "ad471e5f-4c13-4eb6-8923-a2f161597943", "", new DateTime(2023, 2, 19, 20, 3, 58, 906, DateTimeKind.Utc).AddTicks(7507), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEJGQ1jZJpCoGiGzbG5JLN6O6hzQi7R3+JesKvpjTp7DiYjcFMn3H1hvx0BLFPZ6xQw==", null, false, null, (short)0, "9b17be9a-86b2-4431-8927-896a2a8971ca", null, false, "user" },
                    { "d2f22f7d-82fa-4032-a9f8-c729b9e2bb2d", 0, "7f127da4-2aa9-46f1-b96d-78486b1ac7dc", "", new DateTime(2023, 2, 19, 20, 3, 58, 817, DateTimeKind.Utc).AddTicks(9033), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEDEEKTfw7HL5pdAHFlMyLmEVj44ehfqZDk4GqQETw2PYqsMtbindUqQMAcCS/pi4ZQ==", null, false, null, (short)0, "29b40dc4-435c-4b73-8ad8-bc5cce982ea1", null, false, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppMenu");

            migrationBuilder.DropTable(
                name: "LanguageCulture");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "99972f64-e79a-4086-b738-050a7c2d73dd");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "d2f22f7d-82fa-4032-a9f8-c729b9e2bb2d");

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3903c9c3-4c17-4aa5-b6df-bc1ea64c2dc6", 0, "d2b1c255-932b-4233-b7d9-75ea15dca67b", "", new DateTime(2023, 1, 29, 8, 12, 6, 108, DateTimeKind.Utc).AddTicks(2513), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEPPR+GUreLqEU3+/iNPaBbCXbk+cpE3s3eRSkYwUi431BocPp/kcMbDR01fpvcSzDw==", null, false, null, (short)0, "0501b4e8-fd51-4c21-b95f-01d774f355fe", null, false, "admin" },
                    { "baab8e17-1d62-4ce4-afd8-ef7816b5d092", 0, "adde98b8-08d3-4e88-b423-7273a779bcda", "", new DateTime(2023, 1, 29, 8, 12, 6, 264, DateTimeKind.Utc).AddTicks(5706), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEAztv6+F0kl0yjrbKtrAn29mtBfoSd7NYKYl772YCilmJ0VOuwl0bZ2CSvSZwGfAzg==", null, false, null, (short)0, "a1abfe64-7905-4eec-a0bb-109099cbf92e", null, false, "user" }
                });
        }
    }
}
