using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class stockkkss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stocks",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(8811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Stocks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(6121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrders",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(7503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrderItems",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(8174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(6824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(1057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(1203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(1876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(3323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(4748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 111, DateTimeKind.Local).AddTicks(9498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 111, DateTimeKind.Local).AddTicks(8544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 110, DateTimeKind.Local).AddTicks(2214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 314, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 88, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 81, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 83, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 83, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 83, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 89, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 86, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 86, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 86, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 86, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 87, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 14, 7, 4, 87, DateTimeKind.Local).AddTicks(1988));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Stocks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(2066),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(4714),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(8060),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(5356),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(6698),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(7410),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(5990),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(572),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(699),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(1380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(2702),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(4050),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(9206),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 111, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(8358),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 111, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(3330),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 112, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 314, DateTimeKind.Local).AddTicks(2414),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 14, 7, 4, 110, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 290, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 290, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 290, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 290, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 291, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 291, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 291, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 291, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 292, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 292, DateTimeKind.Local).AddTicks(5379));
        }
    }
}
