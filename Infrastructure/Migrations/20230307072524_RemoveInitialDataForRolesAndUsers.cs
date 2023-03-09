using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveInitialDataForRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(4933));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Name", "NormalizedName", "RowStatus" },
                values: new object[,]
                {
                    { 1, "ed63444a-cd9c-42f2-8be2-74cea1083a10", "", new DateTime(2023, 3, 2, 8, 6, 43, 103, DateTimeKind.Utc).AddTicks(2414), null, null, "Administrator", "ADMINISTRATOR", (short)0 },
                    { 2, "f5c22eeb-65f9-45f2-905d-909739f28731", "", new DateTime(2023, 3, 2, 8, 6, 43, 103, DateTimeKind.Utc).AddTicks(2432), null, null, "Sales Create", "SALES CREATE", (short)0 }
                });

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "d7503498-12cc-4f1f-95c5-98c5b0353034", "", new DateTime(2023, 3, 2, 8, 6, 42, 964, DateTimeKind.Utc).AddTicks(90), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAELOrRAV+zlz1gs65nKMqi4nKvXIfichkLrJaolP9qt4lOVUcOabDZl2c38++dLfv3Q==", null, false, null, null, (short)0, "cafde407-d35f-4914-a763-fe79116a21d9", null, false, "admin" },
                    { 2, 0, "211165c2-d5a8-4ea5-87da-8035a0911caa", "", new DateTime(2023, 3, 2, 8, 6, 43, 103, DateTimeKind.Utc).AddTicks(1755), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEO1FGImydR1NidFW+RSViD0DvWE4KQRRFMhv6buzGiu8qABGqE7T7/qp2WXqHJ4FAw==", null, false, null, null, (short)0, "8522e01c-e732-4c57-9130-c24c38d63057", null, false, "user" }
                });
        }
    }
}
