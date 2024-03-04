using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class allchangess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPurchase",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ItemImage");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(7795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 523, DateTimeKind.Local).AddTicks(681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 122, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.AddColumn<double>(
                name: "TotalAmount",
                table: "Suppliers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(6173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(6319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.AddColumn<int>(
                name: "Pincode",
                table: "Locations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(7066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(8547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(9954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(4685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(5424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(3835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(9243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 520, DateTimeKind.Local).AddTicks(6686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 119, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 495, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 495, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 495, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 495, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(7565));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "Locations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(7238),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 122, DateTimeKind.Local).AddTicks(218),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 523, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.AddColumn<string>(
                name: "TotalPurchase",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(5757),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(6455),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(8117),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ItemImage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(9521),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(4087),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(3190),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(8821),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 119, DateTimeKind.Local).AddTicks(7012),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 520, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 97, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 94, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 94, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 94, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 94, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 98, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 96, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 96, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 96, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 96, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 96, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 14, 31, 24, 96, DateTimeKind.Local).AddTicks(9435));
        }
    }
}
