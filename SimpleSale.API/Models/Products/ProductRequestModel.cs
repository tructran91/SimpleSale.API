﻿namespace SimpleSale.API.Models.Products
{
    public class ProductRequestModel : SEOContentViewModel
    {
        public string? Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string? Description { get; set; }

        public bool IsPublished { get; set; }

        public string? ShortDescription { get; set; }

        public decimal? Price { get; set; } = 0;

        public decimal? OldPrice { get; set; }

        public decimal? SpecialPrice { get; set; }

        public DateTime? SpecialPriceStart { get; set; }

        public DateTime? SpecialPriceEnd { get; set; }

        public bool IsCallForPricing { get; set; }

        public bool IsAllowToOrder { get; set; }

        public int StockQuantity { get; set; }

        public string? Sku { get; set; }

        public int DisplayOrder { get; set; }

        public Guid BrandId { get; set; }
    }
}
