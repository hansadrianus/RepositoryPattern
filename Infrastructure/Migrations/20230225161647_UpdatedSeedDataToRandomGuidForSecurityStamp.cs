using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedDataToRandomGuidForSecurityStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 16, 16, 44, 480, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 16, 16, 44, 480, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 16, 16, 44, 480, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 16, 16, 44, 480, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 16, 16, 44, 480, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 16, 16, 44, 480, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ab8c4f8-167e-41e4-91aa-a0c1c6451ef1", new DateTime(2023, 2, 25, 16, 16, 44, 859, DateTimeKind.Utc).AddTicks(8388), "AQAAAAIAAYagAAAAEGdesTIPsiQxUaALiYSnFF72glZ9cMtwDhWzBtS/RM01TqgLp8DT0JeFPXtBLiHbjA==", "c413d973-5aee-4e34-aa47-72015c89bc16" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19ae077d-6d4c-41bf-8a47-721150b21a0c", new DateTime(2023, 2, 25, 16, 16, 45, 130, DateTimeKind.Utc).AddTicks(5599), "AQAAAAIAAYagAAAAEHI8c7aOiUrCymuDlngWQJfArWmPkYKGra2BzTdh5pqSzSuAMgd2TlTNUG/ZCvOy+Q==", "8103d224-768d-43ef-af0e-aab335cf654b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00ed5414-d30d-430c-9716-6c77c2b3ef76", new DateTime(2023, 2, 25, 8, 54, 39, 339, DateTimeKind.Utc).AddTicks(9404), "AQAAAAIAAYagAAAAEPb3QVrNWH3wW9Z1J8COw7B/lFit+oEDKz/rZWfa38Ywpghq72+GhVo9q/N/mplJag==", null });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6fc3375-3471-4edc-a1b1-26eb7bc80a92", new DateTime(2023, 2, 25, 8, 54, 39, 421, DateTimeKind.Utc).AddTicks(2451), "AQAAAAIAAYagAAAAEN26y/IvmYtqb7vhIwLvQfrcMjfM5sBIgg+U3+5sGP1hMloCm5Eq+YyOGcopWpTDFg==", null });
        }
    }
}
