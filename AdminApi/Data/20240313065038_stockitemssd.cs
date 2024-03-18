using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class stockitemssd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(9833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(6045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "StockItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StockItems",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(3273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 422, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(7429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(8896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(1108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(2215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 422, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(6905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(7158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(1913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(4622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(4075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(2477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 420, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(3314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 839, DateTimeKind.Local).AddTicks(7395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 419, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AddToCarts",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(44),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 813, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 808, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 809, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 809, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 809, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 814, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 811, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 811, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 811, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 811, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 812, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 13, 12, 20, 37, 812, DateTimeKind.Local).AddTicks(6632));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(3300),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(9833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(6620),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "StockItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StockItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 422, DateTimeKind.Local).AddTicks(960),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Purchases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(7280),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PaymentMethods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(8153),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(9541),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 422, DateTimeKind.Local).AddTicks(230),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1773),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1922),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(3887),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(4470),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(328),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(1049),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 420, DateTimeKind.Local).AddTicks(9357),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 842, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(5174),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 843, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 419, DateTimeKind.Local).AddTicks(3141),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 839, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "AddToCarts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 13, 10, 49, 43, 421, DateTimeKind.Local).AddTicks(8864),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 13, 12, 20, 37, 844, DateTimeKind.Local).AddTicks(44));

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
    }
}
