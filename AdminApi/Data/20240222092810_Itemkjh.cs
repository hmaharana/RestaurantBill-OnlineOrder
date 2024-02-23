using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Itemkjh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 478, DateTimeKind.Local).AddTicks(1357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(6898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(7361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(9398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(2127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(4854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 476, DateTimeKind.Local).AddTicks(9779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 837, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 478, DateTimeKind.Local).AddTicks(3435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 839, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 472, DateTimeKind.Local).AddTicks(5542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 833, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Category",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 412, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 400, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 403, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 403, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 403, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 414, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 406, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 406, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 406, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 406, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 409, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 58, 9, 409, DateTimeKind.Local).AddTicks(6409));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Category");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(9667),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 478, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(4938),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(5359),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(7597),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(454),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 838, DateTimeKind.Local).AddTicks(2696),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 477, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 837, DateTimeKind.Local).AddTicks(7603),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 476, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 839, DateTimeKind.Local).AddTicks(1844),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 478, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 22, 11, 8, 29, 833, DateTimeKind.Local).AddTicks(2302),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 58, 9, 472, DateTimeKind.Local).AddTicks(5542));

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
    }
}
