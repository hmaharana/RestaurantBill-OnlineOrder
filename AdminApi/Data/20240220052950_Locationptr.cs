using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Locationptr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 894, DateTimeKind.Local).AddTicks(5389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 772, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 894, DateTimeKind.Local).AddTicks(532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 770, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 894, DateTimeKind.Local).AddTicks(1039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 770, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 894, DateTimeKind.Local).AddTicks(3147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 771, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 893, DateTimeKind.Local).AddTicks(5452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 768, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 893, DateTimeKind.Local).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 769, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 893, DateTimeKind.Local).AddTicks(2517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 768, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 888, DateTimeKind.Local).AddTicks(6535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 761, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.CreateTable(
                name: "ItemsImage",
                columns: table => new
                {
                    ItemImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsImage", x => x.ItemImageId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 810, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 796, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 799, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 799, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 799, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 812, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 803, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 803, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 803, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 803, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 806, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 59, 49, 806, DateTimeKind.Local).AddTicks(7968));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsImage");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 772, DateTimeKind.Local).AddTicks(4955),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 894, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 770, DateTimeKind.Local).AddTicks(31),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 894, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 770, DateTimeKind.Local).AddTicks(1702),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 894, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 771, DateTimeKind.Local).AddTicks(9999),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 894, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 768, DateTimeKind.Local).AddTicks(9640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 893, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 769, DateTimeKind.Local).AddTicks(5067),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 893, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 768, DateTimeKind.Local).AddTicks(4385),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 893, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 40, 11, 761, DateTimeKind.Local).AddTicks(2283),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 59, 49, 888, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 680, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 664, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 667, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 667, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 667, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 684, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 672, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 672, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 672, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 672, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 676, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 40, 11, 676, DateTimeKind.Local).AddTicks(3461));
        }
    }
}
