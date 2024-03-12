using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class posorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(8514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(1270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(1950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(2615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(6914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(7094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(7838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(9200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(5214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(6117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(4389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 489, DateTimeKind.Local).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 383, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.CreateTable(
                name: "POSOrders",
                columns: table => new
                {
                    POSOrderId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<long>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: false),
                    TotalQuantity = table.Column<int>(nullable: false),
                    TotalDiscount = table.Column<double>(nullable: true),
                    ServiceCharges = table.Column<double>(nullable: true),
                    OrderStatus = table.Column<string>(nullable: true),
                    OrderNote = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(3339)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POSOrders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(8889),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(2399),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(3188),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(4121),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(6880),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(7819),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(9901),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(1601),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 492, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(5002),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(5837),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 385, DateTimeKind.Local).AddTicks(3963),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 386, DateTimeKind.Local).AddTicks(766),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 491, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 10, 38, 21, 383, DateTimeKind.Local).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 16, 35, 43, 489, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 351, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 346, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 347, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 347, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 347, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 352, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 10, 38, 21, 349, DateTimeKind.Local).AddTicks(9032));
        }
    }
}
