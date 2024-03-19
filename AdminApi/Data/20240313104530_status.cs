using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(3351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(6404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StockItems",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 55, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(7045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(7782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(9135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(9815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(1561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(1817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(3785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(4308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(5690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 53, DateTimeKind.Local).AddTicks(9547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 53, DateTimeKind.Local).AddTicks(8643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(5004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 52, DateTimeKind.Local).AddTicks(2085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 839, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AddToCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(8473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(44));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(9833),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(6045),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StockItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(3273),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 55, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(7429),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(8896),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(1108),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(2215),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(6905),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(7158),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(747),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(1913),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(4622),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(4075),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 53, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(2477),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 53, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(3314),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 839, DateTimeKind.Local).AddTicks(7395),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 52, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AddToCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(44),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 16, 15, 30, 54, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 808, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 809, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 809, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 809, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 811, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 811, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 811, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 811, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 812, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 812, DateTimeKind.Local).AddTicks(6632));
        }
    }
}
