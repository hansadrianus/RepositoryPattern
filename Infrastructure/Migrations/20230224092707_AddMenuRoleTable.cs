using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "455e735f-ba20-49cd-b6af-3b0d10814a1d");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "9575640d-8cd6-4016-a8de-49c48dfac619");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "UserLoginInfo",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppMenuRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppMenuId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMenuRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMenuRole_AppMenu_AppMenuId",
                        column: x => x.AppMenuId,
                        principalTable: "AppMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppMenuRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 27, 6, 906, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48f73005-6e34-45cc-93e9-ef3d8b455b78", 0, "cf912aab-ee2c-4510-bf1c-37c295922ca6", "", new DateTime(2023, 2, 24, 9, 27, 7, 64, DateTimeKind.Utc).AddTicks(8492), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEMqjBt7QJLhY0ZgaMMmjv8YkJgMh1n45IjIdE/IBqZ/F+K4++7lrRoPJVpLbH1kt/A==", null, false, null, null, (short)0, "8c56d90b-46d2-42f9-b58a-9fd0e33f3891", null, false, "user" },
                    { "743edad5-2fb4-4cea-93a0-56ae231d9fb8", 0, "6bbf1a20-34ce-46fe-b18b-44722b740089", "", new DateTime(2023, 2, 24, 9, 27, 6, 985, DateTimeKind.Utc).AddTicks(1244), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEDZzl8NFm5ssZaJtEw41AaycAAW6RFe/vK46VWB+hNUfrktwXItkxhOV8wRmZdybWQ==", null, false, null, null, (short)0, "fe1a7017-68f2-4b7f-b035-a1bf3b4304a9", null, false, "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppMenuRole_AppMenuId",
                table: "AppMenuRole",
                column: "AppMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMenuRole_RoleId",
                table: "AppMenuRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppMenuRole");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "48f73005-6e34-45cc-93e9-ef3d8b455b78");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "743edad5-2fb4-4cea-93a0-56ae231d9fb8");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "UserLoginInfo");

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "AppMenu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 6, 18, 24, 607, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "455e735f-ba20-49cd-b6af-3b0d10814a1d", 0, "95c1f6c6-d8ca-4b36-a139-9a16af51e16e", "", new DateTime(2023, 2, 24, 6, 18, 24, 686, DateTimeKind.Utc).AddTicks(6662), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEFQOPTdCW+9hED0kMc4M5J1QR2XJcX/vJcdOolfVk2KGFh1g3kUq/RPJyVhTUBileg==", null, false, null, (short)0, "33111237-1692-4db5-8d49-e8d95f217859", null, false, "admin" },
                    { "9575640d-8cd6-4016-a8de-49c48dfac619", 0, "1c9840a7-6604-4c76-824a-8f24d4f31324", "", new DateTime(2023, 2, 24, 6, 18, 24, 769, DateTimeKind.Utc).AddTicks(2931), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEFWnSO0cIDTd5mcEbULBe54NIE7z63qzQeP8B4m3JRu9x8YUExrmDfbWF+uS/DcZjA==", null, false, null, (short)0, "21ab5a0e-4482-4bb4-b58f-e1aa24a42aa7", null, false, "user" }
                });
        }
    }
}
