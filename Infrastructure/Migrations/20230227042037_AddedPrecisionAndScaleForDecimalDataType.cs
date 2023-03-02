using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedPrecisionAndScaleForDecimalDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 20, 36, 874, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 20, 36, 874, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 20, 36, 874, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 20, 36, 874, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 20, 36, 874, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 20, 36, 874, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c791a1fc-c2c0-46ec-b279-8ee2b6583e49", new DateTime(2023, 2, 27, 4, 20, 36, 960, DateTimeKind.Utc).AddTicks(6005), "AQAAAAIAAYagAAAAED+uFi5+LruBM4/fYxToq6HbDFBXInCptkY45NKHw5JQtHvz07Ty4RK/n8DiiPKaYQ==", "9f82c99c-8743-417a-87e4-5197a67ca565" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d87cba9-ee8c-43fb-ba41-98258dd7c94f", new DateTime(2023, 2, 27, 4, 20, 37, 40, DateTimeKind.Utc).AddTicks(3124), "AQAAAAIAAYagAAAAEB7dzVxekHwyZ/Bv0awiQI2dRYYq4wF4SzQcPPxWBAeyx/AJVUQFgQJZbK4sAzT3kQ==", "c1c0c807-0552-483d-9946-1a2c5c18fbf1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
