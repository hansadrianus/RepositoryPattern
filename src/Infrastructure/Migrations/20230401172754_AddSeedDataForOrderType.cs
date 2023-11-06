using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForOrderType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.InsertData(
                table: "OrderType",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Name", "RowStatus" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7853), null, null, "Cash", (short)0 },
                    { 2, "", new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7855), null, null, "Credit", (short)0 },
                    { 3, "", new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7856), null, null, "Split Payment", (short)0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 18, 10, 358, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 18, 10, 358, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 18, 10, 357, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 18, 10, 357, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 18, 10, 357, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 1, 17, 18, 10, 357, DateTimeKind.Utc).AddTicks(9752));
        }
    }
}
