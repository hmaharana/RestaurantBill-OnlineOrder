using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Locationoku : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(4618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 973, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(2141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 973, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(2563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 973, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(7183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 972, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(9557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 972, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(4245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 971, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 632, DateTimeKind.Local).AddTicks(2284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 963, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 523, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 526, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 526, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 526, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 530, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 530, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 530, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 530, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 532, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 532, DateTimeKind.Local).AddTicks(7078));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 973, DateTimeKind.Local).AddTicks(7372),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 973, DateTimeKind.Local).AddTicks(448),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 973, DateTimeKind.Local).AddTicks(1151),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 972, DateTimeKind.Local).AddTicks(1107),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 972, DateTimeKind.Local).AddTicks(5642),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 971, DateTimeKind.Local).AddTicks(6012),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 963, DateTimeKind.Local).AddTicks(3275),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 632, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 2, 20, 11, 8, 40, 973, DateTimeKind.Local).AddTicks(4334)),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true),
                    GSTAmount = table.Column<double>(type: "float", nullable: true),
                    GSTId = table.Column<int>(type: "int", nullable: true),
                    HNSCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MRP = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    TaxType = table.Column<bool>(type: "bit", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 903, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 892, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 894, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 894, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 894, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 905, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 898, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 898, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 898, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 898, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 900, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 8, 40, 900, DateTimeKind.Local).AddTicks(3612));
        }
    }
}
