using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableToNotesForSalesOrderDetailEntityRev1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "SalesOrderDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 177, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 177, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 177, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 177, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 12, 23, 178, DateTimeKind.Utc).AddTicks(347));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "SalesOrderDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 8, 20, 4, 32, 682, DateTimeKind.Utc).AddTicks(6235));
        }
    }
}
