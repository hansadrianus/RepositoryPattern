using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RefreshDatabaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LanguageCulture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LCID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefaultLanguage = table.Column<bool>(type: "bit", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageCulture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuController = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuAction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuParent = table.Column<int>(type: "int", nullable: false),
                    MenuLevel = table.Column<int>(type: "int", nullable: false),
                    MenuOrder = table.Column<int>(type: "int", nullable: false),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "PhysicalInventoryDocumentHeader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentNo = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlanStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlanFinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualFinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Evaluator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDraft = table.Column<bool>(type: "bit", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalInventoryDocumentHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valuation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLoginInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoginInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderHeader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderTypeId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    IsDraft = table.Column<bool>(type: "bit", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_OrderType_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_PaymentType_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalInventoryDocumentDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIDHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AdjustmentValuation = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AdjustmentStock = table.Column<int>(type: "int", nullable: true),
                    AdjustmentTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalInventoryDocumentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalInventoryDocumentDetail_PhysicalInventoryDocumentHeader_PIDHeaderId",
                        column: x => x.PIDHeaderId,
                        principalTable: "PhysicalInventoryDocumentHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalInventoryDocumentDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MenuRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    AppMenuId = table.Column<int>(type: "int", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuRoles_Menu_AppMenuId",
                        column: x => x.AppMenuId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MenuRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaim_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_UserLoginInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserLoginInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogin_UserLoginInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserLoginInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_UserLoginInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserLoginInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserToken_UserLoginInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserLoginInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SalesOrderDetail_SalesOrderHeader_OrderId",
                        column: x => x.OrderId,
                        principalTable: "SalesOrderHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LanguageCulture",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Description", "IsDefaultLanguage", "LCID", "ModifiedBy", "ModifiedTime", "RowStatus", "Uid" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2343), "English", true, 1033, null, null, (short)0, new Guid("0becb2ef-2cf6-43f6-8f9e-04404e756fb6") },
                    { 2, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2347), "Indonesia", false, 1057, null, null, (short)0, new Guid("0717e18e-0135-4411-865e-0c2792704625") }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "CssClass", "MenuAction", "MenuController", "MenuLevel", "MenuName", "MenuOrder", "MenuParent", "ModifiedBy", "ModifiedTime", "RowStatus", "Uid" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1915), "fas fa-dollar-sign", "", "Sales", 0, "Sales", 0, 0, null, null, (short)0, new Guid("5282a213-6c7e-41e3-a1c4-f1737de3ef8f") },
                    { 2, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1923), "", "CreateSalesOrder", "Sales", 1, "Create Sales Order", 1, 1, null, null, (short)0, new Guid("d3aa4faa-e87e-44e9-ba55-e14f502b7689") },
                    { 3, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1927), "", "ChangeSalesOrder", "Sales", 1, "Change Sales Order", 2, 1, null, null, (short)0, new Guid("e0490225-ece2-4f1f-8a9d-9d07e137fd9b") },
                    { 4, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1930), "", "DisplaySalesOrder", "Sales", 1, "Display Sales Order", 3, 1, null, null, (short)0, new Guid("778021fd-7ad8-4e2a-932d-bc586e919374") },
                    { 5, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1933), "fas fa-tags", "", "Products", 0, "Product", 0, 0, null, null, (short)0, new Guid("5b0c21d1-cbb4-4f2a-8c3c-22e9aa2bda9d") },
                    { 6, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1944), "", "CreateProduct", "Products", 1, "Create Product", 1, 5, null, null, (short)0, new Guid("4dca744d-7168-403b-b233-e72390ecfeb7") },
                    { 7, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1947), "", "ChangeProduct", "Products", 1, "Change Product", 2, 5, null, null, (short)0, new Guid("7f7c5208-c30b-4ae1-9183-3832fc5c56c0") },
                    { 8, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2014), "", "DisplayProduct", "Products", 1, "Display Product", 3, 5, null, null, (short)0, new Guid("e399ef0c-c21c-44f4-b545-d21bbcbd484b") },
                    { 9, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2017), "fas fa-tags", "", "Inventories", 0, "Inventory", 0, 0, null, null, (short)0, new Guid("c1849661-3d14-4d10-89a1-280cbba22d36") },
                    { 10, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2020), "", "StockOpname", "Inventories", 1, "Stock Opname", 1, 9, null, null, (short)0, new Guid("3de7a9c3-1583-49d9-8dc7-d0f286c01acb") }
                });

            migrationBuilder.InsertData(
                table: "OrderType",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Name", "RowStatus", "Uid" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2381), null, null, "Sales Quotation", (short)0, new Guid("dad29e3f-2b39-49b0-9901-a31fcaf26f25") },
                    { 2, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2390), null, null, "Sales Order", (short)0, new Guid("6fad56b8-c131-4b2c-9d56-f64e24be57cc") },
                    { 3, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2394), null, null, "Sales Contract", (short)0, new Guid("1f0131ab-940c-41b9-b4f6-bf144e1b733e") }
                });

            migrationBuilder.InsertData(
                table: "PaymentType",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "Name", "RowStatus", "Uid" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2471), null, null, "Cash", (short)0, new Guid("cd1afbd5-3eac-4765-9eeb-95e766c6f47d") },
                    { 2, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2476), null, null, "Credit", (short)0, new Guid("02c3a3f9-c661-4a13-921f-7e058a79f74a") },
                    { 3, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2478), null, null, "Split Payment", (short)0, new Guid("20245b46-8032-4204-84a0-fa5da5537e40") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Description", "ModifiedBy", "ModifiedTime", "Name", "Price", "ProductCode", "RowStatus", "Stock", "Type", "Uid", "Valuation" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2562), "", null, null, "Sample Product 1", 10000m, "SAMPLE0001", (short)0, 100, "Sample", new Guid("8bf00c0e-67f8-4322-82d0-750ca4b6eff9"), 9000m },
                    { 2, "", new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2567), "", null, null, "Sample Product 2", 20000m, "SAMPLE0002", (short)0, 100, "Sample", new Guid("58546696-21d2-4cad-9c16-162363bb056c"), 15000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageCulture_LCID",
                table: "LanguageCulture",
                column: "LCID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuRoles_AppMenuId",
                table: "MenuRoles",
                column: "AppMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRoles_RoleId",
                table: "MenuRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalInventoryDocumentDetail_PIDHeaderId",
                table: "PhysicalInventoryDocumentDetail",
                column: "PIDHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalInventoryDocumentDetail_ProductId",
                table: "PhysicalInventoryDocumentDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalInventoryDocumentHeader_DocumentNo",
                table: "PhysicalInventoryDocumentHeader",
                column: "DocumentNo",
                unique: true,
                filter: "[DocumentNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCode",
                table: "Product",
                column: "ProductCode",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaim_RoleId",
                table: "RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetail_OrderId",
                table: "SalesOrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetail_ProductId",
                table: "SalesOrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_OrderNumber",
                table: "SalesOrderHeader",
                column: "OrderNumber",
                unique: true,
                filter: "[OrderNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_OrderTypeId",
                table: "SalesOrderHeader",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_PaymentTypeId",
                table: "SalesOrderHeader",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "UserLoginInfo",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_UserLoginInfo_Email",
                table: "UserLoginInfo",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserLoginInfo_UserName",
                table: "UserLoginInfo",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "UserLoginInfo",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageCulture");

            migrationBuilder.DropTable(
                name: "MenuRoles");

            migrationBuilder.DropTable(
                name: "PhysicalInventoryDocumentDetail");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "SalesOrderDetail");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "PhysicalInventoryDocumentHeader");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SalesOrderHeader");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UserLoginInfo");

            migrationBuilder.DropTable(
                name: "OrderType");

            migrationBuilder.DropTable(
                name: "PaymentType");
        }
    }
}
