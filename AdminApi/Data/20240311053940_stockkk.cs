using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class stockkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(2066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(4714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stocks",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(8060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(5356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrders",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(6698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrderItems",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(7410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(5990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(1380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(2702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(4050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(9206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(8358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(3330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 314, DateTimeKind.Local).AddTicks(2414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 662, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 293, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 290, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 290, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 290, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 290, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 294, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 291, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 291, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 291, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 291, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 292, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 11, 11, 9, 40, 292, DateTimeKind.Local).AddTicks(5379));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(1153),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(3821),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Stocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(7153),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(4472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(5789),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "POSOrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(6454),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9686),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9819),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(487),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(1859),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(3181),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(8296),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(9008),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 663, DateTimeKind.Local).AddTicks(7415),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 315, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 664, DateTimeKind.Local).AddTicks(2519),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 316, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 10, 46, 57, 662, DateTimeKind.Local).AddTicks(2296),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 11, 11, 9, 40, 314, DateTimeKind.Local).AddTicks(2414));

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
    }
}
