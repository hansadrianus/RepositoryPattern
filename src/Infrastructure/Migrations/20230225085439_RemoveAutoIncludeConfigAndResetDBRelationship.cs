using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAutoIncludeConfigAndResetDBRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaim_Role_ApplicationRoleId",
                table: "RoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_UserLoginInfo_ApplicationUserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_UserLoginInfo_ApplicationUserId",
                table: "UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId1",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_UserLoginInfo_ApplicationUserId",
                table: "UserToken");

            migrationBuilder.DropIndex(
                name: "IX_UserToken_ApplicationUserId",
                table: "UserToken");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserLogin_ApplicationUserId",
                table: "UserLogin");

            migrationBuilder.DropIndex(
                name: "IX_UserClaims_ApplicationUserId",
                table: "UserClaims");

            migrationBuilder.DropIndex(
                name: "IX_RoleClaim_ApplicationRoleId",
                table: "RoleClaim");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserToken");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserLogin");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserClaims");

            migrationBuilder.DropColumn(
                name: "ApplicationRoleId",
                table: "RoleClaim");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 54, 39, 259, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash" },
                values: new object[] { "00ed5414-d30d-430c-9716-6c77c2b3ef76", new DateTime(2023, 2, 25, 8, 54, 39, 339, DateTimeKind.Utc).AddTicks(9404), "AQAAAAIAAYagAAAAEPb3QVrNWH3wW9Z1J8COw7B/lFit+oEDKz/rZWfa38Ywpghq72+GhVo9q/N/mplJag==" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash" },
                values: new object[] { "b6fc3375-3471-4edc-a1b1-26eb7bc80a92", new DateTime(2023, 2, 25, 8, 54, 39, 421, DateTimeKind.Utc).AddTicks(2451), "AQAAAAIAAYagAAAAEN26y/IvmYtqb7vhIwLvQfrcMjfM5sBIgg+U3+5sGP1hMloCm5Eq+YyOGcopWpTDFg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "UserToken",
                type: "int",
                nullable: true);

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
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "UserLogin",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "UserClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationRoleId",
                table: "RoleClaim",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 25, 8, 38, 14, 991, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash" },
                values: new object[] { "7decea9c-3018-4000-bf30-c86f6fdb07ab", new DateTime(2023, 2, 25, 8, 38, 15, 85, DateTimeKind.Utc).AddTicks(7516), "AQAAAAIAAYagAAAAEG6EGIBEAru5lVqn2VSr00YGUuMsocIb7VqwVnpWcRftrHVgQe9PWegbmGJ7Aw/pYg==" });

            migrationBuilder.UpdateData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "PasswordHash" },
                values: new object[] { "90832678-59dd-47a1-8831-8e9e00b55d28", new DateTime(2023, 2, 25, 8, 38, 15, 182, DateTimeKind.Utc).AddTicks(871), "AQAAAAIAAYagAAAAEE7EYGWICDtlFGPg1d4q/I6cGgStSa/g0x5aCDCoe/22UQc3XgRYk0Y8HJ8+aWMW7g==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserToken_ApplicationUserId",
                table: "UserToken",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId1",
                table: "UserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId1",
                table: "UserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_ApplicationUserId",
                table: "UserLogin",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_ApplicationUserId",
                table: "UserClaims",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaim_ApplicationRoleId",
                table: "RoleClaim",
                column: "ApplicationRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaim_Role_ApplicationRoleId",
                table: "RoleClaim",
                column: "ApplicationRoleId",
                principalTable: "Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_UserLoginInfo_ApplicationUserId",
                table: "UserClaims",
                column: "ApplicationUserId",
                principalTable: "UserLoginInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_UserLoginInfo_ApplicationUserId",
                table: "UserLogin",
                column: "ApplicationUserId",
                principalTable: "UserLoginInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId1",
                table: "UserRoles",
                column: "RoleId1",
                principalTable: "Role",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles",
                column: "UserId1",
                principalTable: "UserLoginInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_UserLoginInfo_ApplicationUserId",
                table: "UserToken",
                column: "ApplicationUserId",
                principalTable: "UserLoginInfo",
                principalColumn: "Id");
        }
    }
}
