using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Itemssd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemImage",
                table: "Items");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(6705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(1998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(4370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(6449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(8921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(3095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(9105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 531, DateTimeKind.Local).AddTicks(7968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 491, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 443, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 424, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 428, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 428, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 428, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 447, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 435, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 435, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 435, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 435, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 438, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 21, 14, 48, 23, 438, DateTimeKind.Local).AddTicks(4073));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Cities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(6406),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(4756),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(4901),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(5685),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.AddColumn<string>(
                name: "ItemImage",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(3292),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(2297),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 493, DateTimeKind.Local).AddTicks(7145),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 56, 5, 491, DateTimeKind.Local).AddTicks(3971),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 531, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 469, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 465, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 466, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 466, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 466, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 470, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 467, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 467, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 467, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 467, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 468, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 56, 5, 468, DateTimeKind.Local).AddTicks(5607));
        }
    }
}
