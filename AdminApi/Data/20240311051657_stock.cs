using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class stock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(1153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(3821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(4472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrders",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(5789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(1859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(3181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(8296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(7415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(2519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 662, DateTimeKind.Local).AddTicks(2296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 489, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.CreateTable(
                name: "POSOrderItems",
                columns: table => new
                {
                    POSOrderItemId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<long>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(6454)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSOrderItems", x => x.POSOrderItemId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ShippingCharges = table.Column<double>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    AdditionalNotes = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(7153)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 638, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 638, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 638, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 638, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 641, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 639, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 639, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 639, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 639, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 640, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 10, 46, 57, 640, DateTimeKind.Local).AddTicks(4859));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POSOrderItems");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(8514),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(1270),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(1950),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(3339),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(2615),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(6914),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(7094),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(7838),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(9200),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(5214),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(6117),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(4389),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 489, DateTimeKind.Local).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 662, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 464, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 461, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 461, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 461, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 461, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 465, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 463, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 463, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 463, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 463, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 463, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 16, 35, 43, 463, DateTimeKind.Local).AddTicks(7585));
        }
    }
}
