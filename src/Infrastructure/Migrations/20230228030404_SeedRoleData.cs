using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 28, 3, 4, 3, 690, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 28, 3, 4, 3, 690, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 28, 3, 4, 3, 690, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 28, 3, 4, 3, 690, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 28, 3, 4, 3, 690, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 28, 3, 4, 3, 690, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Name", "NormalizedName", "RowStatus" },
                values: new object[,]
                {
                    { 1, "b113bdc5-4b48-4dd2-819b-1430e61b843d", "", new DateTime(2023, 2, 28, 3, 4, 3, 939, DateTimeKind.Utc).AddTicks(8716), null, null, "Administrator", "ADMINISTRATOR", (short)0 },
                    { 2, "cc5bbc20-3f68-4d78-bfd2-88d2ea5098ad", "", new DateTime(2023, 2, 28, 3, 4, 3, 939, DateTimeKind.Utc).AddTicks(8728), null, null, "Sales Create", "SALES CREATE", (short)0 }
                });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9857806-be3a-414e-8e1c-bd28e7b92090", new DateTime(2023, 2, 28, 3, 4, 3, 797, DateTimeKind.Utc).AddTicks(9531), "AQAAAAIAAYagAAAAEFtIYhKSssZoOGTvz8N7YZWiameLXW+0uqdLrO2CI4NDmfx4QUnaS/YAAu/G6iiffQ==", "5a8cba3f-b072-435b-8258-4ffb0850821c" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9585c8ac-02bb-4812-93e8-9490ac4e0aae", new DateTime(2023, 2, 28, 3, 4, 3, 939, DateTimeKind.Utc).AddTicks(7894), "AQAAAAIAAYagAAAAEJk/LRu9lpSRbQOELWNk28KkFtZNQEh/moCcBmz3At+HcV1RiVPTdZ+rn06qbsHY+g==", "0754a717-287b-4c82-958e-27bacf89b198" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
