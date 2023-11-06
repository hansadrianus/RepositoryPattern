using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentTypeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "SalesOrderHeader");

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId",
                table: "SalesOrderHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.Id);
                });

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
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9223), "Sales Quotation" });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9225), "Sales Order" });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9226), "Sales Contract" });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Name", "RowStatus" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9248), null, null, "Cash", (short)0 },
                    { 2, "", new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9249), null, null, "Credit", (short)0 },
                    { 3, "", new DateTime(2023, 4, 2, 3, 33, 9, 262, DateTimeKind.Utc).AddTicks(9251), null, null, "Split Payment", (short)0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_PaymentTypeId",
                table: "SalesOrderHeader",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderHeader_PaymentType_PaymentTypeId",
                table: "SalesOrderHeader",
                column: "PaymentTypeId",
                principalTable: "PaymentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderHeader_PaymentType_PaymentTypeId",
                table: "SalesOrderHeader");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrderHeader_PaymentTypeId",
                table: "SalesOrderHeader");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "SalesOrderHeader");

            migrationBuilder.AddColumn<string>(
                name: "PaymentType",
                table: "SalesOrderHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7853), "Cash" });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7855), "Credit" });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Name" },
                values: new object[] { new DateTime(2023, 4, 1, 17, 27, 54, 554, DateTimeKind.Utc).AddTicks(7856), "Split Payment" });
        }
    }
}
