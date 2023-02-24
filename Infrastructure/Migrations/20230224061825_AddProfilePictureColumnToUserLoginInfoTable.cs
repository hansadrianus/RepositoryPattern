using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddProfilePictureColumnToUserLoginInfoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "78299e84-5514-40d5-b5b5-eeafa7449d28");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "fd8289b8-9d7a-4347-a976-a77f317326d1");

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "455e735f-ba20-49cd-b6af-3b0d10814a1d", 0, "95c1f6c6-d8ca-4b36-a139-9a16af51e16e", "", new DateTime(2023, 2, 24, 6, 18, 24, 686, DateTimeKind.Utc).AddTicks(6662), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEFQOPTdCW+9hED0kMc4M5J1QR2XJcX/vJcdOolfVk2KGFh1g3kUq/RPJyVhTUBileg==", null, false, null, (short)0, "33111237-1692-4db5-8d49-e8d95f217859", null, false, "admin" },
                    { "9575640d-8cd6-4016-a8de-49c48dfac619", 0, "1c9840a7-6604-4c76-824a-8f24d4f31324", "", new DateTime(2023, 2, 24, 6, 18, 24, 769, DateTimeKind.Utc).AddTicks(2931), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEFWnSO0cIDTd5mcEbULBe54NIE7z63qzQeP8B4m3JRu9x8YUExrmDfbWF+uS/DcZjA==", null, false, null, (short)0, "21ab5a0e-4482-4bb4-b58f-e1aa24a42aa7", null, false, "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "455e735f-ba20-49cd-b6af-3b0d10814a1d");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "9575640d-8cd6-4016-a8de-49c48dfac619");

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
                column: "CreatedTime",
                value: new DateTime(2023, 2, 23, 15, 55, 1, 975, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 23, 15, 55, 1, 975, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78299e84-5514-40d5-b5b5-eeafa7449d28", 0, "d1f7632a-7ca4-40cf-9b71-621e1bdb1e16", "", new DateTime(2023, 2, 23, 15, 55, 2, 167, DateTimeKind.Utc).AddTicks(445), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEB/3nYkIL0CUeJHWcO2yOtK2kOdFeadYkrb4dEyLq9Pfus/9Roqo1lnEt2GpbuYahA==", null, false, null, (short)0, "5bc6ed6c-2473-4097-9f91-cabe5d36fef4", null, false, "user" },
                    { "fd8289b8-9d7a-4347-a976-a77f317326d1", 0, "3ae909e3-f414-4a21-8029-46a4fbe068d3", "", new DateTime(2023, 2, 23, 15, 55, 2, 77, DateTimeKind.Utc).AddTicks(7339), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEA7on2LRh0pCCyhCKj+dGeTVRQnfabaeoTnqCtAx4sjxadikpf1mkbKi+/9pOvVPpQ==", null, false, null, (short)0, "60cb662a-d168-4fd8-91cc-33f070c6a3d7", null, false, "admin" }
                });
        }
    }
}
