using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class resturanta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(2685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(1400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(3873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(7441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(8749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(5880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 647, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CustomerLogins",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(6635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(5222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 376, DateTimeKind.Local).AddTicks(165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 642, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 336, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 337, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 337, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 337, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 339, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 339, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 339, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 339, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 340, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 340, DateTimeKind.Local).AddTicks(8332));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(1004),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(5699),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(6208),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(8672),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(434),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(3103),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 647, DateTimeKind.Local).AddTicks(6592),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CustomerLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(8769),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(6006),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 642, DateTimeKind.Local).AddTicks(9268),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 376, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 587, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 589, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 589, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 589, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 591, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 591, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 591, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 591, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 592, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 13, 55, 35, 593, DateTimeKind.Local).AddTicks(674));
        }
    }
}
