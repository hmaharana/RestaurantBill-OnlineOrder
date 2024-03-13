using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class stockitemss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POSOrders");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Stocks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(3300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(6620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(7280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(8153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(3887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(4470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 420, DateTimeKind.Local).AddTicks(9357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(5174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 419, DateTimeKind.Local).AddTicks(3141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 359, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AddToCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(8864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 362, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 422, DateTimeKind.Local).AddTicks(230)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: false),
                    OrderStatus = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerMob = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: false),
                    TotalDiscount = table.Column<double>(nullable: true),
                    ServiceCharges = table.Column<double>(nullable: true),
                    OrderNote = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(9541)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "StockItems",
                columns: table => new
                {
                    StockItemsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockId = table.Column<int>(nullable: false),
                    Product = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<double>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 422, DateTimeKind.Local).AddTicks(960)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItems", x => x.StockItemsId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 394, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 395, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 395, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 395, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 398, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 396, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 396, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 396, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 396, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 10, 49, 43, 397, DateTimeKind.Local).AddTicks(635));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "StockItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(8183),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(8915),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(9619),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(3370),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(3522),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(5477),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(6019),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(7515),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(1910),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(2640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(968),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 420, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 361, DateTimeKind.Local).AddTicks(6796),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 359, DateTimeKind.Local).AddTicks(5024),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 419, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AddToCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 12, 11, 20, 37, 362, DateTimeKind.Local).AddTicks(304),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.CreateTable(
                name: "POSOrders",
                columns: table => new
                {
                    POSOrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<long>(type: "bigint", nullable: false),
                    OrderNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    ServiceCharges = table.Column<double>(type: "float", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    TotalDiscount = table.Column<double>(type: "float", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSOrders", x => x.POSOrderId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 336, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 333, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 333, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 333, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 333, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 337, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 335, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 335, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 335, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 335, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 335, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 12, 11, 20, 37, 335, DateTimeKind.Local).AddTicks(9020));
        }
    }
}
