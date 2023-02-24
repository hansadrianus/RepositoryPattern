using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsDefaultColumnToLanguageCultureTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "99972f64-e79a-4086-b738-050a7c2d73dd");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "d2f22f7d-82fa-4032-a9f8-c729b9e2bb2d");

            migrationBuilder.AddColumn<bool>(
                name: "IsDefaultLanguage",
                table: "LanguageCulture",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 23, 15, 55, 1, 975, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 23, 15, 55, 1, 975, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 23, 15, 55, 1, 975, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 23, 15, 55, 1, 975, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "IsDefaultLanguage" },
                values: new object[] { new DateTime(2023, 2, 23, 15, 55, 1, 975, DateTimeKind.Utc).AddTicks(6226), true });

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "IsDefaultLanguage" },
                values: new object[] { new DateTime(2023, 2, 23, 15, 55, 1, 975, DateTimeKind.Utc).AddTicks(6228), false });

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78299e84-5514-40d5-b5b5-eeafa7449d28", 0, "d1f7632a-7ca4-40cf-9b71-621e1bdb1e16", "", new DateTime(2023, 2, 23, 15, 55, 2, 167, DateTimeKind.Utc).AddTicks(445), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEB/3nYkIL0CUeJHWcO2yOtK2kOdFeadYkrb4dEyLq9Pfus/9Roqo1lnEt2GpbuYahA==", null, false, null, (short)0, "5bc6ed6c-2473-4097-9f91-cabe5d36fef4", null, false, "user" },
                    { "fd8289b8-9d7a-4347-a976-a77f317326d1", 0, "3ae909e3-f414-4a21-8029-46a4fbe068d3", "", new DateTime(2023, 2, 23, 15, 55, 2, 77, DateTimeKind.Utc).AddTicks(7339), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEA7on2LRh0pCCyhCKj+dGeTVRQnfabaeoTnqCtAx4sjxadikpf1mkbKi+/9pOvVPpQ==", null, false, null, (short)0, "60cb662a-d168-4fd8-91cc-33f070c6a3d7", null, false, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "78299e84-5514-40d5-b5b5-eeafa7449d28");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "fd8289b8-9d7a-4347-a976-a77f317326d1");

            migrationBuilder.DropColumn(
                name: "IsDefaultLanguage",
                table: "LanguageCulture");

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 19, 20, 3, 58, 717, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "99972f64-e79a-4086-b738-050a7c2d73dd", 0, "ad471e5f-4c13-4eb6-8923-a2f161597943", "", new DateTime(2023, 2, 19, 20, 3, 58, 906, DateTimeKind.Utc).AddTicks(7507), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEJGQ1jZJpCoGiGzbG5JLN6O6hzQi7R3+JesKvpjTp7DiYjcFMn3H1hvx0BLFPZ6xQw==", null, false, null, (short)0, "9b17be9a-86b2-4431-8927-896a2a8971ca", null, false, "user" },
                    { "d2f22f7d-82fa-4032-a9f8-c729b9e2bb2d", 0, "7f127da4-2aa9-46f1-b96d-78486b1ac7dc", "", new DateTime(2023, 2, 19, 20, 3, 58, 817, DateTimeKind.Utc).AddTicks(9033), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEDEEKTfw7HL5pdAHFlMyLmEVj44ehfqZDk4GqQETw2PYqsMtbindUqQMAcCS/pi4ZQ==", null, false, null, (short)0, "29b40dc4-435c-4b73-8ad8-bc5cce982ea1", null, false, "admin" }
                });
        }
    }
}
