using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Location : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationInformations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 452, DateTimeKind.Local).AddTicks(910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 451, DateTimeKind.Local).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 451, DateTimeKind.Local).AddTicks(3824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 451, DateTimeKind.Local).AddTicks(7710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 450, DateTimeKind.Local).AddTicks(5448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 450, DateTimeKind.Local).AddTicks(9773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 449, DateTimeKind.Local).AddTicks(9731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 525, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 441, DateTimeKind.Local).AddTicks(4888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 524, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 329, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 330, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 309, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 313, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 313, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 313, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 334, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 320, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 320, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 320, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 320, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 323, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 10, 23, 8, 324, DateTimeKind.Local).AddTicks(4377));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(4413),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 452, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(2776),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 451, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(2928),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 451, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(3664),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 451, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(1043),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 450, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(1916),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 450, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 525, DateTimeKind.Local).AddTicks(9972),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 449, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 524, DateTimeKind.Local).AddTicks(1484),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 10, 23, 8, 441, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.CreateTable(
                name: "LocationInformations",
                columns: table => new
                {
                    LocationInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 497, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 491, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 492, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 492, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 492, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 498, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 494, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 494, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 494, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 494, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 495, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 16, 12, 1, 37, 495, DateTimeKind.Local).AddTicks(7747));
        }
    }
}
