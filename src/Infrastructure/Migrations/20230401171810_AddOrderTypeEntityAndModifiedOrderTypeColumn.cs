using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderTypeEntityAndModifiedOrderTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderType",
                table: "SalesOrderHeader");

            migrationBuilder.AddColumn<int>(
                name: "OrderTypeId",
                table: "SalesOrderHeader",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrderType",
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
                    table.PrimaryKey("PK_OrderType", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_OrderTypeId",
                table: "SalesOrderHeader",
                column: "OrderTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrderHeader_OrderType_OrderTypeId",
                table: "SalesOrderHeader",
                column: "OrderTypeId",
                principalTable: "OrderType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrderHeader_OrderType_OrderTypeId",
                table: "SalesOrderHeader");

            migrationBuilder.DropTable(
                name: "OrderType");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrderHeader_OrderTypeId",
                table: "SalesOrderHeader");

            migrationBuilder.DropColumn(
                name: "OrderTypeId",
                table: "SalesOrderHeader");

            migrationBuilder.AddColumn<string>(
                name: "OrderType",
                table: "SalesOrderHeader",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 7, 7, 25, 24, 480, DateTimeKind.Utc).AddTicks(4933));
        }
    }
}
