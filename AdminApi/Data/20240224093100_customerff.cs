using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
    public partial class resturanta : Migration
========
    public partial class customerff : Migration
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(2685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(1004));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 634, DateTimeKind.Local).AddTicks(908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(2279));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(5699));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(5873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(502));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(6208));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(6306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(675));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(1400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(8672));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(8505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(1479));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(3873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(3446));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 634, DateTimeKind.Local).AddTicks(3090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(3136));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(7441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(434));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(1038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 912, DateTimeKind.Local).AddTicks(8633));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(8749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(3103));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 912, DateTimeKind.Local).AddTicks(9622));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(5880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 647, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CustomerLogins",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(6635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(8769));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 632, DateTimeKind.Local).AddTicks(8077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 912, DateTimeKind.Local).AddTicks(7649));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(5222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(6006));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 634, DateTimeKind.Local).AddTicks(5577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(4004));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                defaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 376, DateTimeKind.Local).AddTicks(165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 642, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 342, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 336, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 337, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 337, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 337, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 343, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 339, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 339, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 339, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 339, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 340, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 14, 52, 18, 340, DateTimeKind.Local).AddTicks(8332));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(1004),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(5699),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(6208),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(8672),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(434),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 648, DateTimeKind.Local).AddTicks(3103),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 647, DateTimeKind.Local).AddTicks(6592),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 378, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CustomerLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(8769),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 649, DateTimeKind.Local).AddTicks(6006),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 379, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 13, 55, 35, 642, DateTimeKind.Local).AddTicks(9268),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 14, 52, 18, 376, DateTimeKind.Local).AddTicks(165));
========
                defaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 628, DateTimeKind.Local).AddTicks(2700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 910, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.CreateTable(
                name: "CustomerLogins",
                columns: table => new
                {
                    CustomerLoginId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerMobNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLogins", x => x.CustomerLoginId);
                });
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(8845));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(5203));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9599));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6922));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9606));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6935));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9608));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6939));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9610));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6943));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9613));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6947));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9615));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6950));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9617));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6954));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9619));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6958));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 594, DateTimeKind.Local).AddTicks(9621));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 567, DateTimeKind.Local).AddTicks(6961));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 587, DateTimeKind.Local).AddTicks(6519));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 554, DateTimeKind.Local).AddTicks(3218));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 589, DateTimeKind.Local).AddTicks(1301));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 556, DateTimeKind.Local).AddTicks(9217));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 589, DateTimeKind.Local).AddTicks(1349));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 556, DateTimeKind.Local).AddTicks(9255));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 589, DateTimeKind.Local).AddTicks(1354));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 556, DateTimeKind.Local).AddTicks(9260));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3037));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(5227));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3795));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6709));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3801));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6719));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3803));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6723));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3805));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6726));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3806));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6729));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3808));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6732));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3810));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6735));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3812));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6737));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 596, DateTimeKind.Local).AddTicks(3813));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 569, DateTimeKind.Local).AddTicks(6745));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 591, DateTimeKind.Local).AddTicks(6941));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 561, DateTimeKind.Local).AddTicks(7044));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 591, DateTimeKind.Local).AddTicks(7834));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 561, DateTimeKind.Local).AddTicks(8759));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 591, DateTimeKind.Local).AddTicks(7841));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 561, DateTimeKind.Local).AddTicks(8777));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 591, DateTimeKind.Local).AddTicks(7843));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 561, DateTimeKind.Local).AddTicks(8783));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 592, DateTimeKind.Local).AddTicks(9713));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 564, DateTimeKind.Local).AddTicks(7872));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
<<<<<<<< HEAD:AdminApi/Data/20240224092218_resturanta.cs
                value: new DateTime(2024, 2, 24, 13, 55, 35, 593, DateTimeKind.Local).AddTicks(674));
========
                value: new DateTime(2024, 2, 24, 15, 0, 58, 564, DateTimeKind.Local).AddTicks(9741));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerLogins");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Vendors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(2279),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 634, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(502),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(675),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(1479),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(3136),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 634, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 912, DateTimeKind.Local).AddTicks(8633),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 912, DateTimeKind.Local).AddTicks(9622),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 633, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 912, DateTimeKind.Local).AddTicks(7649),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 632, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 913, DateTimeKind.Local).AddTicks(4004),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 634, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 24, 12, 52, 13, 910, DateTimeKind.Local).AddTicks(8494),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 2, 24, 15, 0, 58, 628, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 879, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 880, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 880, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 880, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 884, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 882, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 882, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 882, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 882, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 882, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 12, 52, 13, 882, DateTimeKind.Local).AddTicks(8572));
>>>>>>>> 0847afcb972e1de995575fc4b4a6476c92c9c0a8:AdminApi/Data/20240224093100_customerff.cs
        }
    }
}
