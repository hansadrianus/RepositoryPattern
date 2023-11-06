using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IgnoreShadowKeyFromUserRoleEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "adb83a21-f9a4-4e21-af5a-a83d8aaf4f96", new DateTime(2023, 3, 2, 8, 3, 36, 671, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "d7d39193-2a15-40dd-932b-f35f5b5a1184", new DateTime(2023, 3, 2, 8, 3, 36, 671, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6132cc7-d5db-4eee-80b8-37397167faa4", new DateTime(2023, 3, 2, 8, 3, 36, 529, DateTimeKind.Utc).AddTicks(3047), "AQAAAAIAAYagAAAAEIW8GocZciaSrze1oazp3eRYG/34/j93wZ8WeI32qms8w+3K+lMFMJkhqyZ6GhlVVQ==", "77b3ce79-bc42-4bdb-a8b2-2c512dc1a7d8" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "779d9fed-a1be-4c4f-a927-387195816a1b", new DateTime(2023, 3, 2, 8, 3, 36, 670, DateTimeKind.Utc).AddTicks(8859), "AQAAAAIAAYagAAAAEBTGCFHwbQTcoqmduVpzkIB4iAnu37bojhwvZIXtICaXBLImaQR4L/cT3sTWRRDOAw==", "6020ad5b-3c1f-4cba-9abb-0182316dff0a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "d8032b33-d38e-4367-87d2-6a8134d8d7f7", new DateTime(2023, 3, 1, 10, 54, 1, 389, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "b7b140e8-cd11-4eff-99e0-14d10b3c27c6", new DateTime(2023, 3, 1, 10, 54, 1, 389, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c39d7177-82d0-4e79-9289-dbac5679d66f", new DateTime(2023, 3, 1, 10, 54, 1, 199, DateTimeKind.Utc).AddTicks(2307), "AQAAAAIAAYagAAAAEFa3JiPEqrvN23b9sLNkt8dpVL1fzj1mAAYO+t4AseVUt5jUwsoVY4s7/YwFgOrJFA==", "77809e30-9b26-461d-bab0-00625bf43f3a" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8b7a85c-c2c8-4871-9336-e3df2cf47e78", new DateTime(2023, 3, 1, 10, 54, 1, 389, DateTimeKind.Utc).AddTicks(6558), "AQAAAAIAAYagAAAAEKNoLEUteZhdvhPLJnXO5MW80SNsz8HQr8PtRudwvhNvpeAui0HdsUAE1p2/vrEEvw==", "337c6657-bc08-4d26-9c6b-45edec8cc74c" });
        }
    }
}
