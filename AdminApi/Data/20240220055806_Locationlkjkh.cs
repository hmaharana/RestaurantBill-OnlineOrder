using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Locationlkjkh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 303, DateTimeKind.Local).AddTicks(1945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 298, DateTimeKind.Local).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 298, DateTimeKind.Local).AddTicks(5319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 298, DateTimeKind.Local).AddTicks(604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 298, DateTimeKind.Local).AddTicks(2717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 297, DateTimeKind.Local).AddTicks(8170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 293, DateTimeKind.Local).AddTicks(3894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 632, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    MRP = table.Column<double>(nullable: false),
                    DiscountAmount = table.Column<double>(nullable: true),
                    ColorCode = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    GSTAmount = table.Column<double>(nullable: true),
                    GSTId = table.Column<int>(nullable: true),
                    TaxType = table.Column<bool>(nullable: true),
                    HNSCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 302, DateTimeKind.Local).AddTicks(9240)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 219, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 209, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 211, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 211, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 211, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 221, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 215, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 215, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 215, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 215, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 216, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 28, 5, 217, DateTimeKind.Local).AddTicks(1316));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(4618),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 303, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(2141),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 298, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 638, DateTimeKind.Local).AddTicks(2563),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 298, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(7183),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 298, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(9557),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 298, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 637, DateTimeKind.Local).AddTicks(4245),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 297, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 20, 11, 25, 8, 632, DateTimeKind.Local).AddTicks(2284),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 20, 11, 28, 5, 293, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 535, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 523, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 526, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 526, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 526, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 537, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 530, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 530, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 530, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 530, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 532, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 20, 11, 25, 8, 532, DateTimeKind.Local).AddTicks(7078));
        }
    }
}
