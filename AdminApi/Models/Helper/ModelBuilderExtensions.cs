using System;
using AdminApi.Models.App;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;

namespace AdminApi.Models.Helper
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuGroup>(b =>
            {
                b.HasKey(e => e.MenuGroupID);
                b.Property(b => b.MenuGroupID).HasIdentityOptions(startValue: 3);
                b.HasData(new MenuGroup
                {
                    MenuGroupID = 1,
                    MenuGroupName = "Super Admin Group",
                    IsActive = true,
                    DateAdded = DateTime.Now,
                    AddedBy = 1,
                    IsMigrationData = true
                },
                new MenuGroup
                {
                    MenuGroupID = 2,
                    MenuGroupName = "User Group",
                    IsActive = true,
                    DateAdded = DateTime.Now,
                    AddedBy = 1,
                    IsMigrationData = true
                }
                        ,
                        new MenuGroup
                        {
                            MenuGroupID = 3,
                            MenuGroupName = "Franchise Group",
                            IsActive = true,
                            DateAdded = DateTime.Now,
                            AddedBy = 1,
                            IsMigrationData = true
                        },
                        new MenuGroup
                        {
                            MenuGroupID = 4,
                            MenuGroupName = "Partner Group",
                            IsActive = true,
                            DateAdded = DateTime.Now,
                            AddedBy = 1,
                            IsMigrationData = true
                        });
            });
            modelBuilder.Entity<UserRole>(b =>
            {
                b.HasKey(e => e.UserRoleId);
                b.Property(b => b.UserRoleId).HasIdentityOptions(startValue: 3);
                b.HasData(
                    new UserRole
                    {
                        UserRoleId = 1,
                        RoleName = "Admin",
                        MenuGroupId = 1,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        AddedBy = 1,
                        IsMigrationData = true
                    },
                    new UserRole
                    {
                        UserRoleId = 2,
                        RoleName = "User",
                        MenuGroupId = 2,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        AddedBy = 1,
                        IsMigrationData = true
                    }
                    ,
                    new UserRole
                    {
                        UserRoleId = 3,
                        RoleName = "Franchise",
                        MenuGroupId = 3,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        AddedBy = 1,
                        IsMigrationData = true
                    }

                    ,
                    new UserRole
                    {
                        UserRoleId = 4,
                        RoleName = "Provider",
                        MenuGroupId = 4,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        AddedBy = 1,
                        IsMigrationData = true
                    }

                    );
            });

            modelBuilder.Entity<Users>(b =>
            {
                b.HasKey(e => e.UserId);
                b.Property(b => b.UserId).HasIdentityOptions(startValue: 3);
                b.HasData(
                    new Users
                    {
                        UserId = 1,
                        UserRoleId = 1,
                        FullName = "Admin",
                        UserName = "Developer",
                        Password = "admin@2024",
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        AddedBy = 1,
                        IsPasswordChange = false,
                        IsMigrationData = true
                    },
                    new Users
                    {
                        UserId = 2,
                        UserRoleId = 2,
                        FullName = "Helen Smith",
                        UserName = "user@2020",
                        Password = "user@2020",
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        AddedBy = 1,
                        IsPasswordChange = false,
                        IsMigrationData = true
                    });
            });

            modelBuilder.Entity<AppMenu>(b =>
            {
                b.HasKey(e => e.MenuID);
                b.Property(b => b.MenuID).HasIdentityOptions(startValue: 11);
                b.HasData(
                    new AppMenu
                    {
                        MenuID = 1,
                        ParentID = 0,
                        MenuTitle = "Dashboard",
                        URL = "/DashBoard/Index",
                        IsSubMenu = 0,
                        SortOrder = 1,
                        IconClass = "fas fa-home",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 2,
                        ParentID = 0,
                        MenuTitle = "Menu",
                        URL = "",
                        IsSubMenu = 1,
                        SortOrder = 2,
                        IconClass = "fas fa-ellipsis-v",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 3,
                        ParentID = 2,
                        MenuTitle = "Menu List",
                        URL = "/Menu/MenuList",
                        IsSubMenu = 0,
                        SortOrder = 0,
                        IconClass = "",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 4,
                        ParentID = 2,
                        MenuTitle = "Menu Group List",
                        URL = "/Menu/MenuGroupList",
                        IsSubMenu = 0,
                        SortOrder = 0,
                        IconClass = "",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 5,
                        ParentID = 0,
                        MenuTitle = "User",
                        URL = "",
                        IsSubMenu = 1,
                        SortOrder = 3,
                        IconClass = "fas fa-user",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 6,
                        ParentID = 5,
                        MenuTitle = "User List",
                        URL = "/User/UserList",
                        IsSubMenu = 0,
                        SortOrder = 0,
                        IconClass = "",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 7,
                        ParentID = 5,
                        MenuTitle = "Role List",
                        URL = "/User/RoleList",
                        IsSubMenu = 0,
                        SortOrder = 0,
                        IconClass = "",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 8,
                        ParentID = 5,
                        MenuTitle = "Profile",
                        URL = "/User/UserProfile",
                        IsSubMenu = 0,
                        SortOrder = 0,
                        IconClass = "",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 9,
                        ParentID = 0,
                        MenuTitle = "Settings",
                        URL = "",
                        IsSubMenu = 1,
                        SortOrder = 4,
                        IconClass = "fas fa-wrench",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new AppMenu
                    {
                        MenuID = 10,
                        ParentID = 9,
                        MenuTitle = "Change Password",
                        URL = "/User/ChangePassword",
                        IsSubMenu = 0,
                        SortOrder = 0,
                        IconClass = "",
                        IsActive = true,
                        IsVisible = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    });
            });


            modelBuilder.Entity<MenuGroupWiseMenuMapping>(b =>
            {
                b.HasKey(e => e.MenuGroupWiseMenuMappingId);
                b.Property(b => b.MenuGroupWiseMenuMappingId).HasIdentityOptions(startValue: 11);
                b.HasData(
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 1,
                        MenuGroupId = 1,
                        MenuId = 1,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 2,
                        MenuGroupId = 1,
                        MenuId = 3,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 3,
                        MenuGroupId = 1,
                        MenuId = 4,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 4,
                        MenuGroupId = 1,
                        MenuId = 6,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 5,
                        MenuGroupId = 1,
                        MenuId = 7,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 6,
                        MenuGroupId = 1,
                        MenuId = 8,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 7,
                        MenuGroupId = 1,
                        MenuId = 10,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 8,
                        MenuGroupId = 2,
                        MenuId = 1,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 9,
                        MenuGroupId = 2,
                        MenuId = 8,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    },
                    new MenuGroupWiseMenuMapping
                    {
                        MenuGroupWiseMenuMappingId = 10,
                        MenuGroupId = 2,
                        MenuId = 10,
                        IsActive = true,
                        DateAdded = DateTime.Now,
                        IsMigrationData = true,
                        AddedBy = 1
                    });
            });


            //modelBuilder.Entity<AccountGroup>(b =>
            //{
            //    b.HasKey(e => e.AccountGroupId);
            //    b.Property(b => b.AccountGroupId).HasIdentityOptions(startValue: 53);
            //    b.HasData(
            //        new AccountGroup
            //        {
            //            AccountGroupId =
            //                               1,
            //            AccountGroupName = "Bank Account",
            //            Parent = 6,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,


            //        },
            //new AccountGroup
            //{
            //    AccountGroupId =
            //                       2,
            //    AccountGroupName = "Bank CC A / C",
            //    Parent = 7,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //},
            //            new AccountGroup
            //            {
            //                AccountGroupId =
            //                           3,
            //                AccountGroupName = "Bank OD A / C",
            //                Parent = 7,
            //                DefinationType = "System",
            //                CreatedBy = 1,
            //                CreatedOn = System.DateTime.Now,
            //                IsDeleted = false,

            //            },
            //        new AccountGroup
            //        {
            //            AccountGroupId =
            //                           4,
            //            AccountGroupName = "Capital Account",
            //            Parent = null,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        },
            //        new AccountGroup
            //        {
            //            AccountGroupId =
            //                           5,
            //            AccountGroupName = "Cash and cash equivalents",
            //            Parent = 6,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        },
            //            new AccountGroup
            //            {
            //                AccountGroupId =
            //                           6,
            //                AccountGroupName = "Current Assets",
            //                Parent = null,
            //                DefinationType = "System",
            //                CreatedBy = 1,
            //                CreatedOn = System.DateTime.Now,
            //                IsDeleted = false,

            //            },
            //        new AccountGroup
            //        {
            //            AccountGroupId =
            //                           7,
            //            AccountGroupName = "Current Liablities",
            //            Parent = null,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           8,
            //            AccountGroupName = "Deposits(Asset)",
            //            Parent = 6,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           9,
            //            AccountGroupName = "Direct Expenses",
            //            Parent = null,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           10,
            //            AccountGroupName = "Direct Incomes",
            //            Parent = null,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           11,
            //            AccountGroupName = "Duties & Taxes",
            //            Parent = 7,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           12,
            //            AccountGroupName = "Fixed Assets",
            //            Parent = 23,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           13,
            //            AccountGroupName = "Indirect Expenses",
            //            Parent = null,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           14,
            //            AccountGroupName = "Indirect Incomes",
            //            Parent = null,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           15,
            //            AccountGroupName = "Current Investments",
            //            Parent = 6,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           16,
            //            AccountGroupName = "Purchase Account",
            //            Parent = null,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           17,
            //            AccountGroupName = "Reserves & Surplus",
            //            Parent = 4,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           18,
            //            AccountGroupName = "Retined Earnings",
            //            Parent = 4,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           19,
            //            AccountGroupName = "Sales Accounts",
            //            Parent = null,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           20,
            //            AccountGroupName = "Inventories",
            //            Parent = 6,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           21,
            //            AccountGroupName = "Sundry Creditors",
            //            Parent = 7,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        }, new AccountGroup
            //        {
            //            AccountGroupId =
            //                           22,
            //            AccountGroupName = "Sundry Debtors",
            //            Parent = 6,
            //            DefinationType = "System",
            //            CreatedBy = 1,
            //            CreatedOn = System.DateTime.Now,
            //            IsDeleted = false,

            //        },
            //new AccountGroup
            //{
            //    AccountGroupId =
            //                                   23,
            //    AccountGroupName = "Non - Current - Assets",
            //    Parent = null,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   24,
            //    AccountGroupName = "Non - Current - Liabilities",
            //    Parent = null,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   25,
            //    AccountGroupName = "Non - Current Investment",
            //    Parent = 23,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //},
            //new AccountGroup
            //{
            //    AccountGroupId =
            //                                   26,
            //    AccountGroupName = "Short term Loans & Advances",
            //    Parent = 6,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   27,
            //    AccountGroupName = "Long term Loans & Advances",
            //    Parent = 23,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   28,
            //    AccountGroupName = "Short term borrowings",
            //    Parent = 7,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   29,
            //    AccountGroupName = "Long term borrowings",
            //    Parent = 24,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   30,
            //    AccountGroupName = "Other Current Assets",
            //    Parent = 6,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   31,
            //    AccountGroupName = "Other Current Liablities",
            //    Parent = 7,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   32,
            //    AccountGroupName = "Trade Receivables",
            //    Parent = 6,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   33,
            //    AccountGroupName = "Trade Payables",
            //    Parent = 7,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   34,
            //    AccountGroupName = "Long - term provisions",
            //    Parent = 24,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   35,
            //    AccountGroupName = "Short - term provisions",
            //    Parent = 7,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   36,
            //    AccountGroupName = "Deferred tax assets(net)",
            //    Parent = 23,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   37,
            //    AccountGroupName = "Tangible assets",
            //    Parent = 12,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   38,
            //    AccountGroupName = "Intangible assets",
            //    Parent = 12,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   39,
            //    AccountGroupName = "Capital work-in-progress",
            //    Parent = 12,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   40,
            //    AccountGroupName = "Intangible assets under development",
            //    Parent = 12,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   41,
            //    AccountGroupName = "Shareholders’ funds",
            //    Parent = 42,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   42,
            //    AccountGroupName = "Share capital",
            //    Parent = 4,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   43,
            //    AccountGroupName = "Finished Goods",
            //    Parent = 6,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   44,
            //    AccountGroupName = "Employee benefit expense",
            //    Parent = 13,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   45,
            //    AccountGroupName = "Financial costs",
            //    Parent = 13,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   46,
            //    AccountGroupName = "Depreciation and amortization expense",
            //    Parent = 13,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   47,
            //    AccountGroupName = "Current Tax",
            //    Parent = 35,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   48,
            //    AccountGroupName = "Deferred tax Assets",
            //    Parent = 6,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   49,
            //    AccountGroupName = "Deferred tax liablity",
            //    Parent = 24,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   50,
            //    AccountGroupName = "Divedent Expendeiture",
            //    Parent = 17,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   51,
            //    AccountGroupName = "Divedent Payable",
            //    Parent = 7,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //}, new AccountGroup
            //{
            //    AccountGroupId =
            //                                   52,
            //    AccountGroupName = "Divedent Income",
            //    Parent = 14,
            //    DefinationType = "System",
            //    CreatedBy = 1,
            //    CreatedOn = System.DateTime.Now,
            //    IsDeleted = false,

            //});
            //});



            //modelBuilder.Entity<AccountHead>(b =>
            //{
            //    b.HasKey(e => e.AccountHeadId);
            //    b.Property(b => b.AccountHeadId).HasIdentityOptions(startValue: 15);
            //    b.HasData(
            //        new AccountHead
            //        {
            //            AccountHeadId = 1,
            //            AccountHeadName = "Cash-In-Hand",
            //            AccountGroupId = 5,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //         new AccountHead
            //         {
            //             AccountHeadId = 2,
            //             AccountHeadName = "CGST 2.5",
            //             AccountGroupId = 11,
            //             IsDeleted = false,
            //             CreatedOn = DateTime.Now,
            //             CreatedBy = 1,

            //         },
            //          new AccountHead
            //          {
            //              AccountHeadId = 3,
            //              AccountHeadName = "SGST 2.5",
            //              AccountGroupId = 11,
            //              IsDeleted = false,
            //              CreatedOn = DateTime.Now,
            //              CreatedBy = 1,

            //          },
            //           new AccountHead
            //           {
            //               AccountHeadId = 4,
            //               AccountHeadName = "IGST 5",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }, new AccountHead
            //           {
            //               AccountHeadId = 5,
            //               AccountHeadName = "CGST 6",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }, new AccountHead
            //           {
            //               AccountHeadId = 6,
            //               AccountHeadName = "SGST 6",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }, new AccountHead
            //           {
            //               AccountHeadId = 7,
            //               AccountHeadName = "IGST 12",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }

            //           , new AccountHead
            //           {
            //               AccountHeadId = 8,
            //               AccountHeadName = "CGST 9",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }, new AccountHead
            //           {
            //               AccountHeadId = 9,
            //               AccountHeadName = "SGST 9",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }, new AccountHead
            //           {
            //               AccountHeadId = 10,
            //               AccountHeadName = "IGST 18",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }, new AccountHead
            //           {
            //               AccountHeadId = 11,
            //               AccountHeadName = "CGST 14",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }
            //           , new AccountHead
            //           {
            //               AccountHeadId = 12,
            //               AccountHeadName = "SGST 14",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }, new AccountHead
            //           {
            //               AccountHeadId = 13,
            //               AccountHeadName = "IGST 28",
            //               AccountGroupId = 11,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }, new AccountHead
            //           {
            //               AccountHeadId = 14,
            //               AccountHeadName = "Sales Account",
            //               AccountGroupId = 19,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           }
            //           , new AccountHead
            //           {
            //               AccountHeadId = 15,
            //               AccountHeadName = "Purchase Account",
            //               AccountGroupId = 16,
            //               IsDeleted = false,
            //               CreatedOn = DateTime.Now,
            //               CreatedBy = 1,

            //           });
            //});




            //modelBuilder.Entity<State>(b =>
            //{
            //    b.HasKey(e => e.StateId);
            //    b.Property(b => b.StateId).HasIdentityOptions(startValue: 15);
            //    b.HasData(
            //        new State
            //        {
            //            StateId = 1,
            //            StateName = "JAMMU AND KASHMIR",
            //            StateCode = "J&K",
            //            GSTStateCode = 1,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 2,
            //            StateName = "HIMACHAL PRADESH",
            //            StateCode = "HP",
            //            GSTStateCode = 2,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 3,
            //            StateName = "PUNJAB",
            //            StateCode = "PB",
            //            GSTStateCode = 3,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 4,
            //            StateName = "CHANDIGARH",
            //            StateCode = "CH",
            //            GSTStateCode = 4,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 5,
            //            StateName = "UTTARAKHAND",
            //            StateCode = "UK",
            //            GSTStateCode = 5,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 6,
            //            StateName = "HARYANA",
            //            StateCode = "HR",
            //            GSTStateCode = 6,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 7,
            //            StateName = "DELHI",
            //            StateCode = "DL",
            //            GSTStateCode = 7,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 8,
            //            StateName = "RAJASTHAN",
            //            StateCode = "RJ",
            //            GSTStateCode = 8,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 9,
            //            StateName = "UTTAR PRADESH",
            //            StateCode = "UP",
            //            GSTStateCode = 9,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 10,
            //            StateName = "BIHAR",
            //            StateCode = "BR",
            //            GSTStateCode = 10,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 11,
            //            StateName = "SIKKIM",
            //            StateCode = "SK",
            //            GSTStateCode = 11,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 12,
            //            StateName = "ARUNACHAL PRADESH",
            //            StateCode = "AR",
            //            GSTStateCode = 12,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 13,
            //            StateName = "NAGALAND",
            //            StateCode = "NL",
            //            GSTStateCode = 13,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 14,
            //            StateName = "MANIPUR",
            //            StateCode = "MN",
            //            GSTStateCode = 14,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 15,
            //            StateName = "MIZORAM",
            //            StateCode = "MZ",
            //            GSTStateCode = 15,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 16,
            //            StateName = "TRIPURA",
            //            StateCode = "TR",
            //            GSTStateCode = 16,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 17,
            //            StateName = "MEGHALAYA",
            //            StateCode = "ML",
            //            GSTStateCode = 17,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 18,
            //            StateName = "ASSAM",
            //            StateCode = "AS",
            //            GSTStateCode = 18,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 19,
            //            StateName = "WEST BENGAL",
            //            StateCode = "WB",
            //            GSTStateCode = 19,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 20,
            //            StateName = "JHARKHAND",
            //            StateCode = "JH",
            //            GSTStateCode = 20,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 21,
            //            StateName = "ODISHA",
            //            StateCode = "OD",
            //            GSTStateCode = 21,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 22,
            //            StateName = "CHATTISGARH",
            //            StateCode = "CG",
            //            GSTStateCode = 22,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 23,
            //            StateName = "MADHYA PRADESH",
            //            StateCode = "MP",
            //            GSTStateCode = 23,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 24,
            //            StateName = "GUJARAT",
            //            StateCode = "GJ",
            //            GSTStateCode = 24,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 25,
            //            StateName = "DADRA AND NAGAR HAVELI AND DAMAN AND DIU",
            //            StateCode = "DD",
            //            GSTStateCode = 26,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 26,
            //            StateName = "MAHARASHTRA",
            //            StateCode = "MH",
            //            GSTStateCode = 27,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 28,
            //            StateName = "KARNATAKA",
            //            StateCode = "KA",
            //            GSTStateCode = 29,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 29,
            //            StateName = "GOA",
            //            StateCode = "GA",
            //            GSTStateCode = 30,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 30,
            //            StateName = "LAKSHADWEEP",
            //            StateCode = "LD",
            //            GSTStateCode = 31,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 31,
            //            StateName = "KERALA",
            //            StateCode = "KL",
            //            GSTStateCode = 32,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 32,
            //            StateName = "TAMIL NADU",
            //            StateCode = "TN",
            //            GSTStateCode = 33,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 33,
            //            StateName = "PUDUCHERRY",
            //            StateCode = "PY",
            //            GSTStateCode = 34,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 34,
            //            StateName = "ANDAMAN AND NICOBAR ISLANDS",
            //            StateCode = "AN",
            //            GSTStateCode = 35,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 35,
            //            StateName = "TELANGANA",
            //            StateCode = "TL",
            //            GSTStateCode = 36,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 36,
            //            StateName = "ANDHRA PRADESH",
            //            StateCode = "AP",
            //            GSTStateCode = 37,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        },
            //        new State
            //        {
            //            StateId = 37,
            //            StateName = "LADAKH",
            //            StateCode = "LA",
            //            GSTStateCode = 38,
            //            IsDeleted = false,
            //            CreatedOn = DateTime.Now,
            //            CreatedBy = 1,

            //        });

            //});




            modelBuilder.Entity<LogHistory>().HasKey(b => b.LogId);

        }
    }
}