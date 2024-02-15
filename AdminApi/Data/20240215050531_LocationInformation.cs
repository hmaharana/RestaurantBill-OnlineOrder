using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class LocationInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(1624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(2476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(7349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 280, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 101, DateTimeKind.Local).AddTicks(1607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 101, DateTimeKind.Local).AddTicks(6476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 100, DateTimeKind.Local).AddTicks(5869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 91, DateTimeKind.Local).AddTicks(7944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 274, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.CreateTable(
                name: "LocationInformations",
                columns: table => new
                {
                    LocationInformationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationInformations", x => x.LocationInformationId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 19, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 6, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 9, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 9, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 9, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 22, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 13, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 13, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 13, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 13, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 15, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 35, 30, 16, DateTimeKind.Local).AddTicks(1467));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationInformations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(9452),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(9922),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 280, DateTimeKind.Local).AddTicks(1864),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(4958),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 101, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(7156),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 101, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 279, DateTimeKind.Local).AddTicks(2465),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 100, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 27, 11, 274, DateTimeKind.Local).AddTicks(7311),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 91, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 217, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 207, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 209, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 209, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 209, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 219, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 213, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 213, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 213, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 213, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 215, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 15, 10, 27, 11, 215, DateTimeKind.Local).AddTicks(3452));
        }
    }
}
