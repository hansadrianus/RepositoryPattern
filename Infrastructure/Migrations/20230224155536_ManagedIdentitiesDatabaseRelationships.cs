using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ManagedIdentitiesDatabaseRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppMenuRole_Menu_AppMenuId",
                table: "AppMenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_AppMenuRole_Role_RoleId",
                table: "AppMenuRole");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaim_Role_RoleId",
                table: "RoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Role_Name",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppMenuRole",
                table: "AppMenuRole");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "80237728-3b30-4fb3-aa28-ef7ab18e1a2e");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "cb3a6e59-c6e7-43fb-a34a-821c8215f0eb");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "AppMenuRole",
                newName: "MenuRoles");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "Role",
                newName: "ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_AppMenuRole_RoleId",
                table: "MenuRoles",
                newName: "IX_MenuRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AppMenuRole_AppMenuId",
                table: "MenuRoles",
                newName: "IX_MenuRoles_AppMenuId");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UserToken",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "UserRoles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleId1",
                table: "UserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "RowStatus",
                table: "UserRoles",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "UserRoles",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "UserRoles",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UserLogin",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UserClaims",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationRoleId",
                table: "RoleClaim",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Role",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "RowStatus",
                table: "Role",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Role",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuRoles",
                table: "MenuRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Role_ApplicationRoleId",
                        column: x => x.ApplicationRoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_UserLoginInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserLoginInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ApplicationRoleId",
                table: "AspNetUserRoles",
                column: "ApplicationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

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
                name: "FK_Role_AspNetRoles_Id",
                table: "Role",
                column: "Id",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaim_AspNetRoles_RoleId",
                table: "RoleClaim",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_UserRoles_AspNetRoles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_AspNetUserRoles_UserId_RoleId",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                principalTable: "AspNetUserRoles",
                principalColumns: new[] { "UserId", "RoleId" },
                onDelete: ReferentialAction.Cascade);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserToken_UserLoginInfo_ApplicationUserId",
                table: "UserToken",
                column: "ApplicationUserId",
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
                name: "FK_Role_AspNetRoles_Id",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaim_AspNetRoles_RoleId",
                table: "RoleClaim");

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
                name: "FK_UserRoles_AspNetRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_AspNetUserRoles_UserId_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId1",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserLoginInfo_UserId1",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToken_UserLoginInfo_ApplicationUserId",
                table: "UserToken");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuRoles",
                table: "MenuRoles");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "659037b0-e555-49f1-8ef9-51530c020c32");

            migrationBuilder.DeleteData(
                table: "UserLoginInfo",
                keyColumn: "Id",
                keyValue: "9e638460-bf40-4107-b4d0-6235a15310c7");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserToken");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "RowStatus",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "RowVersion",
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

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "RowStatus",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Role");

            migrationBuilder.RenameTable(
                name: "MenuRoles",
                newName: "AppMenuRole");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Role",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameIndex(
                name: "IX_MenuRoles_RoleId",
                table: "AppMenuRole",
                newName: "IX_AppMenuRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuRoles_AppMenuId",
                table: "AppMenuRole",
                newName: "IX_AppMenuRole_AppMenuId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Role",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "Role",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppMenuRole",
                table: "AppMenuRole",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 24, 9, 31, 46, 941, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.InsertData(
                table: "UserLoginInfo",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedTime", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "RefreshToken", "RowStatus", "SecurityStamp", "Token", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "80237728-3b30-4fb3-aa28-ef7ab18e1a2e", 0, "d7cdd039-8551-477d-9de8-cbb6ba8e30d3", "", new DateTime(2023, 2, 24, 9, 31, 47, 19, DateTimeKind.Utc).AddTicks(9769), null, "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEOa7uxuz+djSt5MUg5wtZon7atRv8JBKfSWxeVXkVAVbH19ZqqFx9/MHuiKANVZ4Hg==", null, false, null, null, (short)0, "afa37089-fdaf-4be2-a329-39cd48235ec2", null, false, "admin" },
                    { "cb3a6e59-c6e7-43fb-a34a-821c8215f0eb", 0, "427f0183-5298-4a41-b270-313923e004c0", "", new DateTime(2023, 2, 24, 9, 31, 47, 100, DateTimeKind.Utc).AddTicks(4730), null, "user@user.com", false, "User", "User", false, null, null, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEOPKNPOSedWLxAwyathq+hxsj4PysTgrmyVUHPl8fvzVxNXy5so+tF+5cCDceK05mw==", null, false, null, null, (short)0, "2249790d-45ad-4688-9d72-67536acac643", null, false, "user" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Role_Name",
                table: "Role",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AppMenuRole_Menu_AppMenuId",
                table: "AppMenuRole",
                column: "AppMenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppMenuRole_Role_RoleId",
                table: "AppMenuRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaim_Role_RoleId",
                table: "RoleClaim",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
