using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DisableMappingForUserRoleUID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uid",
                table: "UserRoles");

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(868), new Guid("1e19d2a4-5136-4d45-bcbb-dca689105135") });

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(872), new Guid("313af8ea-ca28-4863-84ba-339c34238d2b") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(230), new Guid("5096a021-c591-4f26-bde9-3f05a3f8aa3f") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(252), new Guid("f8b6e84c-f872-443d-ae74-5531d83fa059") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(257), new Guid("97bcdcb5-445a-4064-9932-bbd5c439e7fa") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(261), new Guid("c047a073-8ba4-4348-afda-5c4e41950d08") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(266), new Guid("96451bb5-bb9b-46d4-a710-b8e93c7769d0") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(270), new Guid("da085a7d-3107-4ec8-84cc-796a0e2cf3fc") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(274), new Guid("d892fe54-bd15-4847-97f8-adfa3b6f6317") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(278), new Guid("1023fc70-f74b-4deb-96a1-ee8494ae5fb4") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(282), new Guid("9275f160-c408-47bf-9075-ff9df58be419") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(290), new Guid("d67a6ba2-c44e-431c-93ad-f817681a9460") });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(905), new Guid("b05aab04-1080-4a5f-aa7f-5eeeb852a4fe") });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(909), new Guid("9a2f599c-aada-4396-b0fa-b0211419e994") });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(912), new Guid("000e98c1-55fd-4706-8164-6f3269fe756d") });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(948), new Guid("cc56d5af-7c4d-41ff-a7b4-5431eea0d549") });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(952), new Guid("5924cfdf-8765-4a07-a175-da3ec19d5e48") });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(960), new Guid("42bba6fc-e72e-41e0-8df0-8508435dce46") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(1113), new Guid("8135945d-c40d-4108-afde-823af680385c") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 11, 17, 40, 8, 270, DateTimeKind.Utc).AddTicks(1122), new Guid("0e868d9d-6558-408e-a4bb-23c0bb429c61") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Uid",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2343), new Guid("0becb2ef-2cf6-43f6-8f9e-04404e756fb6") });

            migrationBuilder.UpdateData(
                table: "LanguageCulture",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2347), new Guid("0717e18e-0135-4411-865e-0c2792704625") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1915), new Guid("5282a213-6c7e-41e3-a1c4-f1737de3ef8f") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1923), new Guid("d3aa4faa-e87e-44e9-ba55-e14f502b7689") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1927), new Guid("e0490225-ece2-4f1f-8a9d-9d07e137fd9b") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1930), new Guid("778021fd-7ad8-4e2a-932d-bc586e919374") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1933), new Guid("5b0c21d1-cbb4-4f2a-8c3c-22e9aa2bda9d") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1944), new Guid("4dca744d-7168-403b-b233-e72390ecfeb7") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(1947), new Guid("7f7c5208-c30b-4ae1-9183-3832fc5c56c0") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2014), new Guid("e399ef0c-c21c-44f4-b545-d21bbcbd484b") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2017), new Guid("c1849661-3d14-4d10-89a1-280cbba22d36") });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2020), new Guid("3de7a9c3-1583-49d9-8dc7-d0f286c01acb") });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2381), new Guid("dad29e3f-2b39-49b0-9901-a31fcaf26f25") });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2390), new Guid("6fad56b8-c131-4b2c-9d56-f64e24be57cc") });

            migrationBuilder.UpdateData(
                table: "OrderType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2394), new Guid("1f0131ab-940c-41b9-b4f6-bf144e1b733e") });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2471), new Guid("cd1afbd5-3eac-4765-9eeb-95e766c6f47d") });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2476), new Guid("02c3a3f9-c661-4a13-921f-7e058a79f74a") });

            migrationBuilder.UpdateData(
                table: "PaymentType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2478), new Guid("20245b46-8032-4204-84a0-fa5da5537e40") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2562), new Guid("8bf00c0e-67f8-4322-82d0-750ca4b6eff9") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Uid" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 31, 42, 914, DateTimeKind.Utc).AddTicks(2567), new Guid("58546696-21d2-4cad-9c16-162363bb056c") });
        }
    }
}
