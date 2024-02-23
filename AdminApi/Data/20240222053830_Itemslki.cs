using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Itemslki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Category");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(9667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(4938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(5359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(7597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(2696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 837, DateTimeKind.Local).AddTicks(7603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 839, DateTimeKind.Local).AddTicks(1844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 833, DateTimeKind.Local).AddTicks(2302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 531, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 775, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 765, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 767, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 767, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 767, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 777, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 771, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 771, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 771, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 771, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 772, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 11, 8, 29, 772, DateTimeKind.Local).AddTicks(9782));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(6705),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(1998),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(4370),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(6449),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(8921),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 548, DateTimeKind.Local).AddTicks(3095),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 837, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 549, DateTimeKind.Local).AddTicks(9105),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 839, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 21, 14, 48, 23, 531, DateTimeKind.Local).AddTicks(7968),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 833, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
