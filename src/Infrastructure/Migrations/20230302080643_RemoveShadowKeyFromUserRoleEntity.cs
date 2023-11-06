using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveShadowKeyFromUserRoleEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId1",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserRoles");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 6, 42, 790, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "ed63444a-cd9c-42f2-8be2-74cea1083a10", new DateTime(2023, 3, 2, 8, 6, 43, 103, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "f5c22eeb-65f9-45f2-905d-909739f28731", new DateTime(2023, 3, 2, 8, 6, 43, 103, DateTimeKind.Utc).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7503498-12cc-4f1f-95c5-98c5b0353034", new DateTime(2023, 3, 2, 8, 6, 42, 964, DateTimeKind.Utc).AddTicks(90), "AQAAAAIAAYagAAAAELOrRAV+zlz1gs65nKMqi4nKvXIfichkLrJaolP9qt4lOVUcOabDZl2c38++dLfv3Q==", "cafde407-d35f-4914-a763-fe79116a21d9" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "211165c2-d5a8-4ea5-87da-8035a0911caa", new DateTime(2023, 3, 2, 8, 6, 43, 103, DateTimeKind.Utc).AddTicks(1755), "AQAAAAIAAYagAAAAEO1FGImydR1NidFW+RSViD0DvWE4KQRRFMhv6buzGiu8qABGqE7T7/qp2WXqHJ4FAw==", "8522e01c-e732-4c57-9130-c24c38d63057" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 2, 8, 3, 36, 376, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "adb83a21-f9a4-4e21-af5a-a83d8aaf4f96", new DateTime(2023, 3, 2, 8, 3, 36, 671, DateTimeKind.Utc).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "d7d39193-2a15-40dd-932b-f35f5b5a1184", new DateTime(2023, 3, 2, 8, 3, 36, 671, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6132cc7-d5db-4eee-80b8-37397167faa4", new DateTime(2023, 3, 2, 8, 3, 36, 529, DateTimeKind.Utc).AddTicks(3047), "AQAAAAIAAYagAAAAEIW8GocZciaSrze1oazp3eRYG/34/j93wZ8WeI32qms8w+3K+lMFMJkhqyZ6GhlVVQ==", "77b3ce79-bc42-4bdb-a8b2-2c512dc1a7d8" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "779d9fed-a1be-4c4f-a927-387195816a1b", new DateTime(2023, 3, 2, 8, 3, 36, 670, DateTimeKind.Utc).AddTicks(8859), "AQAAAAIAAYagAAAAEBTGCFHwbQTcoqmduVpzkIB4iAnu37bojhwvZIXtICaXBLImaQR4L/cT3sTWRRDOAw==", "6020ad5b-3c1f-4cba-9abb-0182316dff0a" });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId1",
                table: "UserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId1",
                table: "UserRoles",
                column: "RoleId1",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles",
                column: "UserId1",
                principalTable: "UserLoginInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
