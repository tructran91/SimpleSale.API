﻿using Microsoft.EntityFrameworkCore;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Infrastructure.Data
{
    public class SimpleSaleDbContext : DbContext
    {
        public SimpleSaleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Media> Medias { get; set; }

        public DbSet<ProductAttribute> ProductAttributes { get; set; }

        public DbSet<ProductAttributeGroup> ProductAttributeGroups { get; set; }

        public DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductLink> ProductLinks { get; set; }

        public DbSet<ProductMedia> ProductMedias { get; set; }

        public DbSet<ProductOption> ProductOptions { get; set; }

        public DbSet<ProductOptionValue> ProductOptionValues { get; set; }

        public DbSet<ProductPriceHistory> ProductPriceHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
