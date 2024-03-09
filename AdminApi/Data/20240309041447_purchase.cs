using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class purchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(7562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 81, DateTimeKind.Local).AddTicks(1118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 523, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(5776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(5948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(6767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(8484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 81, DateTimeKind.Local).AddTicks(217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(4063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(4952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(2916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(9401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 78, DateTimeKind.Local).AddTicks(4670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 520, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 55, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 51, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 52, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 52, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 52, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 56, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 9, 9, 44, 47, 54, DateTimeKind.Local).AddTicks(8345));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(7795),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Suppliers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 523, DateTimeKind.Local).AddTicks(681),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 81, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(6173),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(6319),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(7066),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(8547),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "GSTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(9954),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 81, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(4685),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(5424),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(3835),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 522, DateTimeKind.Local).AddTicks(9243),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 80, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 37, 13, 520, DateTimeKind.Local).AddTicks(6686),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 9, 9, 44, 47, 78, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 498, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 495, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 495, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 495, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 495, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 499, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 37, 13, 497, DateTimeKind.Local).AddTicks(7565));
        }
    }
}
