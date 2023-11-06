using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedPrecisionAndScaleForDecimalDataTypeRevision1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SalesOrderDetail",
                type: "decimal(38,38)",
                precision: 38,
                scale: 38,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(38,38)",
                precision: 38,
                scale: 38,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 31, 28, 195, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 31, 28, 195, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 31, 28, 195, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 31, 28, 195, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 31, 28, 195, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 27, 4, 31, 28, 195, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f8dcebf-df9b-4396-8452-4a3439e2a44c", new DateTime(2023, 2, 27, 4, 31, 28, 285, DateTimeKind.Utc).AddTicks(7), "AQAAAAIAAYagAAAAEHe5uuuh66n6+7KDvct9enxLEwBxroWWzqbhU3nGBH3y1dwZi+bjfps2Y3583xv/XQ==", "1c07a2b1-fb36-46f2-8af4-69f2f716eb85" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4736f245-1d3f-487d-9eba-7a846d8a19f8", new DateTime(2023, 2, 27, 4, 31, 28, 376, DateTimeKind.Utc).AddTicks(6645), "AQAAAAIAAYagAAAAEIBs9dkdAD9D6v1FmNktvFDcvUgbdLmioxrI13lwyTj2+U8u6dYA1rGX4UtlhKSO1w==", "ec055c06-633e-4d9d-b0ea-2e4f2f305195" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SalesOrderDetail",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,38)",
                oldPrecision: 38,
                oldScale: 38);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(38,38)",
                oldPrecision: 38,
                oldScale: 38);

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
    }
}
