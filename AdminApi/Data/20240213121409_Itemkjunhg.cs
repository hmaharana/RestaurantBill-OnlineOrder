using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Itemkjunhg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(5076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(5486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(2843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 830, DateTimeKind.Local).AddTicks(7408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 825, DateTimeKind.Local).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 310, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    MRP = table.Column<double>(nullable: false),
                    DiscountAmount = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    TaxApplicable = table.Column<bool>(nullable: false),
                    ItemImage = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(7738)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 759, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 748, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 751, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 751, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 751, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 761, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 762, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 755, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 755, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 755, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 755, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 756, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 44, 8, 757, DateTimeKind.Local).AddTicks(531));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(4475),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(4668),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(2406),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(3310),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 831, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 313, DateTimeKind.Local).AddTicks(1356),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 830, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 12, 13, 18, 54, 310, DateTimeKind.Local).AddTicks(9194),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 44, 8, 825, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 280, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 275, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 276, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 276, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 276, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 281, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 278, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 278, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 278, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 278, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 279, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 13, 18, 54, 279, DateTimeKind.Local).AddTicks(5179));
        }
    }
}
