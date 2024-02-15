using AdminApi.Models.App;
using AdminApi.Models.App.Category;
using AdminApi.Models.App.Item;
using AdminApi.Models.App.Location_Master;
using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;
using System;

namespace AdminApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
        public virtual DbSet<AppMenu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuGroupWiseMenuMapping> MenuGroupWiseMenuMapping { get; set; }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
        public virtual DbSet<FilterValues> FilterValues { get; set; }
        public virtual DbSet<FilterSetting> FilterSettings { get; set; }
       
        public virtual DbSet<MarketUsers> MarketUsers { get; set; }
        public virtual DbSet<MarketUserLogHistory> MarketUserLogHistory { get; set; }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<LocationInformation> LocationInformations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            modelBuilder.Entity<Category>()
            .HasMany(e => e.Children)

            .WithOne() // EF Core
            .HasForeignKey(e => e.Parent);


            modelBuilder.Entity<Category>()
           .Property(s => s.CreatedOn)
           .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Category>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();


            modelBuilder.Entity<Filter>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Filter>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();


            modelBuilder.Entity<FilterValues>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<FilterValues>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();



            modelBuilder.Entity<FilterSetting>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<FilterSetting>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();



            modelBuilder.Entity<MarketUsers>()
          .Property(s => s.DateAdded)
          .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<MarketUsers>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<MarketUsers>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            modelBuilder.Entity<Item>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Item>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

        }


    }
}
