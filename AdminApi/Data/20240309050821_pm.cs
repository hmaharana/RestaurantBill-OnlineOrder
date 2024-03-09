using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class pm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(8889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(2399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 81, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(6880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(7819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(9901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(1601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 81, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(5002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(5837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(3963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 383, DateTimeKind.Local).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 78, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethodName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(4121)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    PurchaseStatus = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: false),
                    PaymentStatus = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(3188)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 346, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 347, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 347, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 347, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(9032));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(7562),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 81, DateTimeKind.Local).AddTicks(1118),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(5776),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(5948),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(6767),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(8484),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 81, DateTimeKind.Local).AddTicks(217),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(4063),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(4952),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(2916),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(9401),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 78, DateTimeKind.Local).AddTicks(4670),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 383, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 51, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 52, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 52, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 52, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(8345));
        }
    }
}
