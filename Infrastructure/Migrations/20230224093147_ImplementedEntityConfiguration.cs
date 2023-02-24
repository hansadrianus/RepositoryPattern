using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ImplementedEntityConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppMenuRole_AppMenu_AppMenuId",
                table: "AppMenuRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppMenu",
                table: "AppMenu");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "48f73005-6e34-45cc-93e9-ef3d8b455b78");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "743edad5-2fb4-4cea-93a0-56ae231d9fb8");

            migrationBuilder.RenameTable(
                name: "AppMenu",
                newName: "Menu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menu",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "80237728-3b30-4fb3-aa28-ef7ab18e1a2e", 0, "d7cdd039-8551-477d-9de8-cbb6ba8e30d3", "", new DateTime(2023, 2, 24, 9, 31, 47, 19, DateTimeKind.Utc).AddTicks(9769), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEOa7uxuz+djSt5MUg5wtZon7atRv8JBKfSWxeVXkVAVbH19ZqqFx9/MHuiKANVZ4Hg==", null, false, null, null, (short)0, "afa37089-fdaf-4be2-a329-39cd48235ec2", null, false, "admin" },
                    { "cb3a6e59-c6e7-43fb-a34a-821c8215f0eb", 0, "427f0183-5298-4a41-b270-313923e004c0", "", new DateTime(2023, 2, 24, 9, 31, 47, 100, DateTimeKind.Utc).AddTicks(4730), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEOPKNPOSedWLxAwyathq+hxsj4PysTgrmyVUHPl8fvzVxNXy5so+tF+5cCDceK05mw==", null, false, null, null, (short)0, "2249790d-45ad-4688-9d72-67536acac643", null, false, "user" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageCulture_LCID",
                table: "LanguageCulture",
                column: "LCID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppMenuRole_Menu_AppMenuId",
                table: "AppMenuRole",
                column: "AppMenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppMenuRole_Menu_AppMenuId",
                table: "AppMenuRole");

            migrationBuilder.DropIndex(
                name: "IX_LanguageCulture_LCID",
                table: "LanguageCulture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "80237728-3b30-4fb3-aa28-ef7ab18e1a2e");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "cb3a6e59-c6e7-43fb-a34a-821c8215f0eb");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "AppMenu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppMenu",
                table: "AppMenu",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48f73005-6e34-45cc-93e9-ef3d8b455b78", 0, "cf912aab-ee2c-4510-bf1c-37c295922ca6", "", new DateTime(2023, 2, 24, 9, 27, 7, 64, DateTimeKind.Utc).AddTicks(8492), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEMqjBt7QJLhY0ZgaMMmjv8YkJgMh1n45IjIdE/IBqZ/F+K4++7lrRoPJVpLbH1kt/A==", null, false, null, null, (short)0, "8c56d90b-46d2-42f9-b58a-9fd0e33f3891", null, false, "user" },
                    { "743edad5-2fb4-4cea-93a0-56ae231d9fb8", 0, "6bbf1a20-34ce-46fe-b18b-44722b740089", "", new DateTime(2023, 2, 24, 9, 27, 6, 985, DateTimeKind.Utc).AddTicks(1244), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEDZzl8NFm5ssZaJtEw41AaycAAW6RFe/vK46VWB+hNUfrktwXItkxhOV8wRmZdybWQ==", null, false, null, null, (short)0, "fe1a7017-68f2-4b7f-b035-a1bf3b4304a9", null, false, "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AppMenuRole_AppMenu_AppMenuId",
                table: "AppMenuRole",
                column: "AppMenuId",
                principalTable: "AppMenu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
