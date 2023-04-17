using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovePrecisionForSalesOrderDetailTableAndAddAutoIncludeProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 10, 3, 8, 784, DateTimeKind.Utc).AddTicks(2041));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5717));
        }
    }
}
