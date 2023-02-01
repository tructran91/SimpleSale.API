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

        //public DbSet<ProductOption> ProductOptions { get; set; }

        //public DbSet<ProductOptionValue> ProductOptionValues { get; set; }

        //public DbSet<ProductPriceHistory> ProductPriceHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductMedia>()
                .HasOne(x => x.Product)
                .WithMany(p => p.Medias)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductMedia>()
                .HasOne(x => x.Media)
                .WithMany(p => p.Products)
                .HasForeignKey(x => x.MediaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductLink>()
                .HasOne(x => x.Product)
                .WithMany(p => p.ProductLinks)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductLink>()
                .HasOne(x => x.LinkedProduct)
                .WithMany(p => p.LinkedProductLinks)
                .HasForeignKey(x => x.LinkedProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
