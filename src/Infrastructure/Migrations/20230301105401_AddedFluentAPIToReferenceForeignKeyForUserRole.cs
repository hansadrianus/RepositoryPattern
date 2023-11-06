using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedFluentAPIToReferenceForeignKeyForUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId",
                table: "UserRoles");

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
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 3, 1, 10, 54, 1, 88, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "d8032b33-d38e-4367-87d2-6a8134d8d7f7", new DateTime(2023, 3, 1, 10, 54, 1, 389, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "b7b140e8-cd11-4eff-99e0-14d10b3c27c6", new DateTime(2023, 3, 1, 10, 54, 1, 389, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c39d7177-82d0-4e79-9289-dbac5679d66f", new DateTime(2023, 3, 1, 10, 54, 1, 199, DateTimeKind.Utc).AddTicks(2307), "AQAAAAIAAYagAAAAEFa3JiPEqrvN23b9sLNkt8dpVL1fzj1mAAYO+t4AseVUt5jUwsoVY4s7/YwFgOrJFA==", "77809e30-9b26-461d-bab0-00625bf43f3a" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8b7a85c-c2c8-4871-9336-e3df2cf47e78", new DateTime(2023, 3, 1, 10, 54, 1, 389, DateTimeKind.Utc).AddTicks(6558), "AQAAAAIAAYagAAAAEKNoLEUteZhdvhPLJnXO5MW80SNsz8HQr8PtRudwvhNvpeAui0HdsUAE1p2/vrEEvw==", "337c6657-bc08-4d26-9c6b-45edec8cc74c" });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId1",
                table: "UserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId1",
                table: "UserRoles",
                column: "RoleId1",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "UserLoginInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles",
                column: "UserId1",
                principalTable: "UserLoginInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId1",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId",
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

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "b113bdc5-4b48-4dd2-819b-1430e61b843d", new DateTime(2023, 2, 28, 3, 4, 3, 939, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime" },
                values: new object[] { "cc5bbc20-3f68-4d78-bfd2-88d2ea5098ad", new DateTime(2023, 2, 28, 3, 4, 3, 939, DateTimeKind.Utc).AddTicks(8728) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "UserLoginInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
