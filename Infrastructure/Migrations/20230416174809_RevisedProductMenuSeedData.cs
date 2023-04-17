using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RevisedProductMenuSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "MenuAction", "MenuParent" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(3885), "CreateProduct", 5 });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "MenuParent" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(3888), 5 });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "MenuParent" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(3890), 5 });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 48, 9, 400, DateTimeKind.Utc).AddTicks(4538));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "MenuAction", "MenuParent" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5910), "CreatePropduct", 1 });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "MenuParent" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5912), 1 });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "MenuParent" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5915), 1 });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(6246));
        }
    }
}
