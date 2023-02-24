using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixCircularRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_Role_ApplicationRoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRoles_Menu_AppMenuId",
                table: "MenuRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRoles_Role_RoleId",
                table: "MenuRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ApplicationRoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "659037b0-e555-49f1-8ef9-51530c020c32");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "9e638460-bf40-4107-b4d0-6235a15310c7");

            migrationBuilder.DropColumn(
                name: "ApplicationRoleId",
                table: "AspNetUserRoles");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId1",
                table: "UserRoles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 17, 9, 45, 720, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 17, 9, 45, 720, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 17, 9, 45, 720, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 17, 9, 45, 720, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 17, 9, 45, 720, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 17, 9, 45, 720, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "76faf9ca-f765-487c-8e15-94cd6fdca6be", 0, "4a3747f3-3557-49d5-a3d0-5f93ecc21fdd", "", new DateTime(2023, 2, 24, 17, 9, 45, 877, DateTimeKind.Utc).AddTicks(9189), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEFr13MR/1WX1qOQ5Ya3QlVItG+lVYyUNjue+T8UszvKHF+wV2Z54C62POdTo3cjTAA==", null, false, null, null, (short)0, "1c896201-617e-4686-a05a-b63058859c27", null, false, "user" },
                    { "b7140b01-410f-4aef-b930-3d923512875d", 0, "cdedcfaf-ed09-4b46-bf89-36e22518bd62", "", new DateTime(2023, 2, 24, 17, 9, 45, 798, DateTimeKind.Utc).AddTicks(2292), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEFKvn2sw1MDXoSzaU7A7fNMRknGEswAUCXXiXXOcb0Mz5qvfpjsZfNGNtDxfB2SExA==", null, false, null, null, (short)0, "66eaf0a0-977b-4d4b-918a-e76a796294da", null, false, "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRoles_Menu_AppMenuId",
                table: "MenuRoles",
                column: "AppMenuId",
                principalTable: "Menu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRoles_Role_RoleId",
                table: "MenuRoles",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles",
                column: "UserId1",
                principalTable: "UserLoginInfo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuRoles_Menu_AppMenuId",
                table: "MenuRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuRoles_Role_RoleId",
                table: "MenuRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "76faf9ca-f765-487c-8e15-94cd6fdca6be");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "b7140b01-410f-4aef-b930-3d923512875d");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId1",
                table: "UserRoles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationRoleId",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 15, 55, 35, 474, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 15, 55, 35, 474, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 15, 55, 35, 474, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 15, 55, 35, 474, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 15, 55, 35, 474, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 15, 55, 35, 474, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "659037b0-e555-49f1-8ef9-51530c020c32", 0, "5766a61a-48de-43ef-bb15-6695d13cf488", "", new DateTime(2023, 2, 24, 15, 55, 35, 552, DateTimeKind.Utc).AddTicks(4747), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEKFChkBzdKNEvR85SSBFyXiBGdk3eK1dfHif1sUAiqJfBEUiYyZoWucxFLZi4ye/LA==", null, false, null, null, (short)0, "f28ae2c9-1718-4e87-958d-771ceff86878", null, false, "admin" },
                    { "9e638460-bf40-4107-b4d0-6235a15310c7", 0, "b7833c5a-d2da-416b-8f9c-f3d4218fd63d", "", new DateTime(2023, 2, 24, 15, 55, 35, 632, DateTimeKind.Utc).AddTicks(2941), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEFis/Nl1MXCf7uIjoOrVP1hvacnnm6S1dicJ3ysuzj/FOPVdog1A8HqGLgbewsEEBQ==", null, false, null, null, (short)0, "f233a20a-e736-47c3-b5f3-c829b2ec193e", null, false, "user" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ApplicationRoleId",
                table: "AspNetUserRoles",
                column: "ApplicationRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Role_ApplicationRoleId",
                table: "AspNetUserRoles",
                column: "ApplicationRoleId",
                principalTable: "Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRoles_Menu_AppMenuId",
                table: "MenuRoles",
                column: "AppMenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuRoles_Role_RoleId",
                table: "MenuRoles",
                column: "RoleId",
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
