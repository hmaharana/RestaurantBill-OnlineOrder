using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class vendor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemImage",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "TaxPercentage",
                table: "Items");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(2776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(2928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.AlterColumn<bool>(
                name: "TaxType",
                table: "Items",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DiscountAmount",
                table: "Items",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(3664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GSTAmount",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GSTId",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HNSCode",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Items",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(1043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 101, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(1916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 101, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 525, DateTimeKind.Local).AddTicks(9972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 100, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 524, DateTimeKind.Local).AddTicks(1484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 91, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    AadharNo = table.Column<string>(nullable: true),
                    PANNo = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Certificate = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(4413)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GSTAmount",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GSTId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "HNSCode",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Items");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(1624),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(2476),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.AlterColumn<string>(
                name: "TaxType",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DiscountAmount",
                table: "Items",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 102, DateTimeKind.Local).AddTicks(7349),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.AddColumn<string>(
                name: "ItemImage",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TaxPercentage",
                table: "Items",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 101, DateTimeKind.Local).AddTicks(1607),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 101, DateTimeKind.Local).AddTicks(6476),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 526, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 100, DateTimeKind.Local).AddTicks(5869),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 525, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 15, 10, 35, 30, 91, DateTimeKind.Local).AddTicks(7944),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 16, 12, 1, 37, 524, DateTimeKind.Local).AddTicks(1484));

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
    }
}
