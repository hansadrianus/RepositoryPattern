using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForProductMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "CssClass", "MenuAction", "MenuController", "MenuLevel", "MenuName", "MenuOrder", "MenuParent", "ModifiedBy", "ModifiedTime", "RowStatus" },
                values: new object[,]
                {
                    { 5, "", new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5908), "fas fa-tags", "", "Products", 0, "Product", 0, 0, null, null, (short)0 },
                    { 6, "", new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5910), "", "CreatePropduct", "Products", 1, "Create Product", 1, 1, null, null, (short)0 },
                    { 7, "", new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5912), "", "ChangeProduct", "Products", 1, "Change Product", 2, 1, null, null, (short)0 },
                    { 8, "", new DateTime(2023, 4, 16, 17, 43, 26, 378, DateTimeKind.Utc).AddTicks(5915), "", "DisplayProduct", "Products", 1, "Display Product", 3, 1, null, null, (short)0 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 16, 17, 35, 28, 26, DateTimeKind.Utc).AddTicks(2389));
        }
    }
}
