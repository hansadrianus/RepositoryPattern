using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProductPricePresicion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Name", "Price", "ProductCode", "RowStatus", "Stock", "Type" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5715), null, null, "Sample Product 1", 10000m, "SAMPLE0001", (short)0, 100, "Sample" },
                    { 2, "", new DateTime(2023, 4, 2, 18, 58, 17, 894, DateTimeKind.Utc).AddTicks(5717), null, null, "Sample Product 2", 20000m, "SAMPLE0002", (short)0, 100, "Sample" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

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
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9251));
        }
    }
}
