using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class newmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: false),
                    Alias = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Parent = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 872, DateTimeKind.Local).AddTicks(1084)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Category_Category_Parent",
                        column: x => x.Parent,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 876, DateTimeKind.Local).AddTicks(3361)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

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

            migrationBuilder.CreateTable(
                name: "Filters",
                columns: table => new
                {
                    FilterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilterName = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 875, DateTimeKind.Local).AddTicks(2831)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filters", x => x.FilterId);
                });

            migrationBuilder.CreateTable(
                name: "FilterSettings",
                columns: table => new
                {
                    FilterSettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilterId = table.Column<int>(nullable: false),
                    FilterValueId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 875, DateTimeKind.Local).AddTicks(6155)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterSettings", x => x.FilterSettingId);
                });

            migrationBuilder.CreateTable(
                name: "FilterValues",
                columns: table => new
                {
                    FilterValuesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilterId = table.Column<int>(nullable: false),
                    FilterValueName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 875, DateTimeKind.Local).AddTicks(4636)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterValues", x => x.FilterValuesId);
                });

            migrationBuilder.CreateTable(
                name: "GSTs",
                columns: table => new
                {
                    GSTId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GSTName = table.Column<string>(nullable: true),
                    Percentage = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 876, DateTimeKind.Local).AddTicks(4526)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GSTs", x => x.GSTId);
                });

            migrationBuilder.CreateTable(
                name: "ItemImage",
                columns: table => new
                {
                    ItemImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    MainImage = table.Column<string>(nullable: true),
                    Image1 = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true),
                    Image4 = table.Column<string>(nullable: true),
                    Image5 = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 876, DateTimeKind.Local).AddTicks(1862)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemImage", x => x.ItemImageId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: false),
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
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 875, DateTimeKind.Local).AddTicks(9141)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "LogHistory",
                columns: table => new
                {
                    LogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogCode = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    LogInTime = table.Column<DateTime>(nullable: false),
                    LogOutTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogHistory", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "MarketUserLogHistory",
                columns: table => new
                {
                    MarketUserLogHistoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketuserLogCode = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    MarketUserId = table.Column<int>(nullable: false),
                    LogInTime = table.Column<DateTime>(nullable: false),
                    LogOutTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketUserLogHistory", x => x.MarketUserLogHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "MarketUsers",
                columns: table => new
                {
                    MarketUsersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserType = table.Column<int>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 875, DateTimeKind.Local).AddTicks(7351)),
                    LastPasswordChangeDate = table.Column<DateTime>(nullable: true),
                    PasswordChangedBy = table.Column<int>(nullable: true),
                    IsPasswordChange = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 875, DateTimeKind.Local).AddTicks(7645)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketUsers", x => x.MarketUsersId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: false),
                    MenuTitle = table.Column<string>(maxLength: 100, nullable: false),
                    URL = table.Column<string>(maxLength: 500, nullable: true),
                    IsSubMenu = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    IconClass = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    MenuGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupName = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroup", x => x.MenuGroupID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroupWiseMenuMapping",
                columns: table => new
                {
                    MenuGroupWiseMenuMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupId = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroupWiseMenuMapping", x => x.MenuGroupWiseMenuMappingId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    SupplierEmail = table.Column<string>(nullable: true),
                    GSTId = table.Column<int>(nullable: false),
                    PayTerm = table.Column<string>(nullable: true),
                    SupplierAddress = table.Column<string>(nullable: true),
                    TotalPurchase = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 876, DateTimeKind.Local).AddTicks(5798)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    RoleDesc = table.Column<string>(maxLength: 500, nullable: true),
                    MenuGroupId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 500, nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    LastPasswordChangeDate = table.Column<DateTime>(nullable: true),
                    PasswordChangedBy = table.Column<int>(nullable: true),
                    IsPasswordChange = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true),
                    UserDesignation = table.Column<string>(nullable: true),
                    UserReferralId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

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
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 3, 1, 12, 1, 5, 876, DateTimeKind.Local).AddTicks(385)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "AddedBy", "DateAdded", "IconClass", "IsActive", "IsMigrationData", "IsSubMenu", "IsVisible", "LastUpdatedBy", "LastUpdatedDate", "MenuTitle", "ParentID", "SortOrder", "URL" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(924), "fas fa-home", true, true, 0, true, null, null, "Dashboard", 0, 1, "/DashBoard/Index" },
                    { 9, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1402), "fas fa-wrench", true, true, 1, true, null, null, "Settings", 0, 4, "" },
                    { 8, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1401), "", true, true, 0, true, null, null, "Profile", 5, 0, "/User/UserProfile" },
                    { 7, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1398), "", true, true, 0, true, null, null, "Role List", 5, 0, "/User/RoleList" },
                    { 6, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1396), "", true, true, 0, true, null, null, "User List", 5, 0, "/User/UserList" },
                    { 10, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1404), "", true, true, 0, true, null, null, "Change Password", 9, 0, "/User/ChangePassword" },
                    { 4, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1393), "", true, true, 0, true, null, null, "Menu Group List", 2, 0, "/Menu/MenuGroupList" },
                    { 3, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1391), "", true, true, 0, true, null, null, "Menu List", 2, 0, "/Menu/MenuList" },
                    { 2, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1387), "fas fa-ellipsis-v", true, true, 1, true, null, null, "Menu", 0, 2, "" },
                    { 5, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(1395), "fas fa-user", true, true, 1, true, null, null, "User", 0, 3, "" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroup",
                columns: new[] { "MenuGroupID", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 1, 12, 1, 5, 828, DateTimeKind.Local).AddTicks(6849), true, true, null, null, "Super Admin Group" },
                    { 2, 1, new DateTime(2024, 3, 1, 12, 1, 5, 830, DateTimeKind.Local).AddTicks(5245), true, true, null, null, "User Group" },
                    { 3, 1, new DateTime(2024, 3, 1, 12, 1, 5, 830, DateTimeKind.Local).AddTicks(5258), true, true, null, null, "Franchise Group" },
                    { 4, 1, new DateTime(2024, 3, 1, 12, 1, 5, 830, DateTimeKind.Local).AddTicks(5260), true, true, null, null, "Partner Group" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroupWiseMenuMapping",
                columns: new[] { "MenuGroupWiseMenuMappingId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "MenuGroupId", "MenuId" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9519), true, true, 1, 10 },
                    { 10, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9533), true, true, 2, 10 },
                    { 9, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9522), true, true, 2, 8 },
                    { 8, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9520), true, true, 2, 1 },
                    { 6, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9518), true, true, 1, 8 },
                    { 1, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(8900), true, true, 1, 1 },
                    { 4, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9515), true, true, 1, 6 },
                    { 3, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9513), true, true, 1, 4 },
                    { 2, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9510), true, true, 1, 3 },
                    { 5, 1, new DateTime(2024, 3, 1, 12, 1, 5, 834, DateTimeKind.Local).AddTicks(9516), true, true, 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupId", "RoleDesc", "RoleName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 1, 12, 1, 5, 832, DateTimeKind.Local).AddTicks(2242), true, true, null, null, 1, null, "Admin" },
                    { 2, 1, new DateTime(2024, 3, 1, 12, 1, 5, 832, DateTimeKind.Local).AddTicks(2802), true, true, null, null, 2, null, "User" },
                    { 3, 1, new DateTime(2024, 3, 1, 12, 1, 5, 832, DateTimeKind.Local).AddTicks(2806), true, true, null, null, 3, null, "Franchise" },
                    { 4, 1, new DateTime(2024, 3, 1, 12, 1, 5, 832, DateTimeKind.Local).AddTicks(2807), true, true, null, null, 4, null, "Provider" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddedBy", "DateAdded", "DateOfBirth", "Email", "FullName", "ImagePath", "IsActive", "IsMigrationData", "IsPasswordChange", "LastPasswordChangeDate", "LastUpdatedBy", "LastUpdatedDate", "Mobile", "Password", "PasswordChangedBy", "UserDesignation", "UserName", "UserReferralId", "UserRoleId", "VendorId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 1, 12, 1, 5, 833, DateTimeKind.Local).AddTicks(49), null, null, "Admin", null, true, true, false, null, null, null, null, "admin@2024", null, null, "Developer", null, 1, 0 },
                    { 2, 1, new DateTime(2024, 3, 1, 12, 1, 5, 833, DateTimeKind.Local).AddTicks(631), null, null, "Helen Smith", null, true, true, false, null, null, null, null, "user@2020", null, null, "user@2020", null, 2, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_Parent",
                table: "Category",
                column: "Parent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CustomerLogins");

            migrationBuilder.DropTable(
                name: "Filters");

            migrationBuilder.DropTable(
                name: "FilterSettings");

            migrationBuilder.DropTable(
                name: "FilterValues");

            migrationBuilder.DropTable(
                name: "GSTs");

            migrationBuilder.DropTable(
                name: "ItemImage");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "LogHistory");

            migrationBuilder.DropTable(
                name: "MarketUserLogHistory");

            migrationBuilder.DropTable(
                name: "MarketUsers");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.DropTable(
                name: "MenuGroupWiseMenuMapping");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
