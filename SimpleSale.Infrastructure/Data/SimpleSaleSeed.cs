using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Infrastructure.Data
{
    public class SimpleSaleSeed
    {
        public static async Task SeedAsync(SimpleSaleDbContext context)
        {
            if (!context.Brands.Any())
            {
                context.Brands.AddRange(GenerateBrands());
                await context.SaveChangesAsync();
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(GenerateCategories());
                await context.SaveChangesAsync();
            }

            //if (!context.Products.Any())
            //{
            //    context.Products.AddRange(GetPreconfiguredProducts());
            //    await context.SaveChangesAsync();
            //}
        }

        private static IEnumerable<Brand> GenerateBrands()
        {
            return new List<Brand>()
            {
                new Brand() { Id = Guid.Parse("148df6d1-65c1-4e00-b664-5f0a461160a9"), Name = "Apple", Slug = "apple", IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5) },
                new Brand() { Id = Guid.Parse("7cc391e1-8783-4f92-a0cc-9271b34c9ea8"), Name = "Samsung", Slug = "samsung", IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5) },
                new Brand() { Id = Guid.Parse("8ac1a1a5-6cdc-48ad-9292-89e912a6a80a"), Name = "Nokia", Slug = "nokia", IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5) },
                new Brand() { Id = Guid.Parse("b2647f68-1529-44b5-8b2e-e2f4e969d2a7"), Name = "Dell", Slug = "dell", IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5) },
                new Brand() { Id = Guid.Parse("b9fb2c43-bee6-43de-8996-9f39e444fac0"), Name = "Hp", Slug = "hp", IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5) },
                new Brand() { Id = Guid.Parse("ee00dde2-9e30-475d-8a9a-3dfe6173fb30"), Name = "Lenovo", Slug = "lenovo", IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5) },
            };
        }

        private static IEnumerable<Category> GenerateCategories()
        {
            return new List<Category>()
            {
                new Category() { Id = Guid.Parse("8ac51586-431d-4642-8435-5926cb6c04f4"), Name = "Accessories", Slug="accessories", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5)},
                new Category() { Id = Guid.Parse("d8c4a2d8-3f4d-4d3c-923c-f4f46482ab7a"), Name = "Cables", Slug="cables", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5), ParentId = Guid.Parse("8ac51586-431d-4642-8435-5926cb6c04f4")},
                new Category() { Id = Guid.Parse("c3f05c5c-3fa3-4c6d-81c8-e33526e39511"), Name = "Headphones", Slug="headphones", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5), ParentId = Guid.Parse("8ac51586-431d-4642-8435-5926cb6c04f4")},
                new Category() { Id = Guid.Parse("633b7e0d-e227-450e-a3a2-574125aa6024"), Name = "USB Drives", Slug="usb-drives", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5), ParentId = Guid.Parse("8ac51586-431d-4642-8435-5926cb6c04f4")},

                new Category() { Id = Guid.Parse("f64602e6-d373-42ef-a3be-4360449bada1"), Name = "Computers", Slug="computers", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5)},
                new Category() { Id = Guid.Parse("acfb3c87-502b-44a0-b39b-6b644c57ffb6"), Name = "Gaming", Slug="gaming", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5), ParentId = Guid.Parse("f64602e6-d373-42ef-a3be-4360449bada1")},
                new Category() { Id = Guid.Parse("761d55da-023c-41e0-ace7-c7316602e0f6"), Name = "MacBook", Slug="macbook", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5), ParentId = Guid.Parse("f64602e6-d373-42ef-a3be-4360449bada1")},

                new Category() { Id = Guid.Parse("7e226ecb-6fc1-4602-bf0b-d14d02a14555"), Name = "Phones", Slug="phones", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5)},
                new Category() { Id = Guid.Parse("09d370a0-27e9-4b9b-bcf6-b5f076c70f07"), Name = "Iphone", Slug="iphone", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5), ParentId = Guid.Parse("7e226ecb-6fc1-4602-bf0b-d14d02a14555")},
                new Category() { Id = Guid.Parse("a5924453-4608-427f-9751-717f217ea569"), Name = "Basic Phones", Slug="basic-phones", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5), ParentId = Guid.Parse("7e226ecb-6fc1-4602-bf0b-d14d02a14555")},
                new Category() { Id = Guid.Parse("d5f3b0e4-350d-4188-a0d1-28ebc5cc3aea"), Name = "Gaming", Slug="gaming", DisplayOrder = 0, IncludeInMenu = true, IsPublished = true, CreatedOn = DateTime.Now, LatestUpdatedOn = DateTime.Now.AddMinutes(5), ParentId = Guid.Parse("7e226ecb-6fc1-4602-bf0b-d14d02a14555")},
            };
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>();
        }
    }
}
