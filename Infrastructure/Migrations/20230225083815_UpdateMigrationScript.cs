using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigrationScript : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId1",
                table: "UserRoles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash" },
                values: new object[] { "7decea9c-3018-4000-bf30-c86f6fdb07ab", new DateTime(2023, 2, 25, 8, 38, 15, 85, DateTimeKind.Utc).AddTicks(7516), "AQAAAAIAAYagAAAAEG6EGIBEAru5lVqn2VSr00YGUuMsocIb7VqwVnpWcRftrHVgQe9PWegbmGJ7Aw/pYg==" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash" },
                values: new object[] { "90832678-59dd-47a1-8831-8e9e00b55d28", new DateTime(2023, 2, 25, 8, 38, 15, 182, DateTimeKind.Utc).AddTicks(871), "AQAAAAIAAYagAAAAEE7EYGWICDtlFGPg1d4q/I6cGgStSa/g0x5aCDCoe/22UQc3XgRYk0Y8HJ8+aWMW7g==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId1",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 19, 27, 31, 253, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 19, 27, 31, 253, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 19, 27, 31, 253, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 19, 27, 31, 253, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 19, 27, 31, 253, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 19, 27, 31, 253, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash" },
                values: new object[] { "1998ffba-c76d-4884-9549-0f579a9917ef", new DateTime(2023, 2, 24, 19, 27, 31, 911, DateTimeKind.Utc).AddTicks(4508), "AQAAAAIAAYagAAAAEJR6wk2gUPym8FCZxkIHj7bXMtNUXr7ZKpk5PQPYf9K1VeYiff3SCar+/vfB5Acp1g==" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash" },
                values: new object[] { "de37d9d4-f304-4a7c-9e92-9602b408cae6", new DateTime(2023, 2, 24, 19, 27, 32, 347, DateTimeKind.Utc).AddTicks(3550), "AQAAAAIAAYagAAAAEIdzUQ1CpvhrXvmEMPTqzF8i5K68Wu8xTFeSuvOLXovfimE6+0hXuILv9bXoY6NqzQ==" });
        }
    }
}
