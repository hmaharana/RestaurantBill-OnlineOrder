using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class itemimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "ItemImage");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "ItemImage");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "ItemImage");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "ItemImage");

            migrationBuilder.DropColumn(
                name: "Image5",
                table: "ItemImage");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(7238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 122, DateTimeKind.Local).AddTicks(218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(5757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(6455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(8117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ItemImage",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(9521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(4087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(3190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(8821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 119, DateTimeKind.Local).AddTicks(7012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 296, DateTimeKind.Local).AddTicks(9363));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ItemImage");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(1571),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(6788),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 122, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(8931),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(9183),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(434),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(2936),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "ItemImage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "ItemImage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "ItemImage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "ItemImage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image5",
                table: "ItemImage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(5468),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(6244),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(7630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 299, DateTimeKind.Local).AddTicks(4726),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 300, DateTimeKind.Local).AddTicks(4267),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 121, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 1, 12, 24, 3, 296, DateTimeKind.Local).AddTicks(9363),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 1, 14, 31, 24, 119, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 270, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 265, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 265, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 265, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 265, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 271, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 267, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 267, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 267, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 267, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 268, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 1, 12, 24, 3, 268, DateTimeKind.Local).AddTicks(9746));
        }
    }
}
