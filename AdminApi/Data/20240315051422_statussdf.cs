using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class statussdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(4392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(7466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StockItems",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 64, DateTimeKind.Local).AddTicks(1522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 55, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "StockItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(8852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 64, DateTimeKind.Local).AddTicks(180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 64, DateTimeKind.Local).AddTicks(845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(2878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(3016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(4829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(5413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(6763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(1481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 53, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(2214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 53, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(6095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 61, DateTimeKind.Local).AddTicks(4606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 52, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AddToCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(9500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 40, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 37, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 37, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 37, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 37, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 41, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 38, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 38, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 38, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 38, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 39, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 10, 44, 22, 39, DateTimeKind.Local).AddTicks(6129));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "StockItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(3351),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(6404),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StockItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 55, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 64, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(7045),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(7782),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(9135),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 64, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(9815),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 64, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(1561),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(1817),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(3785),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(4308),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(5690),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 53, DateTimeKind.Local).AddTicks(9547),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(596),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 53, DateTimeKind.Local).AddTicks(8643),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(5004),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 52, DateTimeKind.Local).AddTicks(2085),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 61, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AddToCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(8473),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 15, 10, 44, 22, 63, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 30, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 27, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 28, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 28, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 28, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 31, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 29, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 29, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 29, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 29, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 29, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 16, 15, 30, 29, DateTimeKind.Local).AddTicks(9133));
        }
    }
}
