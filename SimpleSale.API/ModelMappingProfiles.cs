using AutoMapper;
using SimpleSale.API.Models.Brands;
using SimpleSale.API.Models.Categories;
using SimpleSale.API.Models.Products;
using SimpleSale.Application.DTOs.Brands;
using SimpleSale.Application.DTOs.Categories;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.API
{
    public class ModelMappingProfiles : Profile
    {
        public ModelMappingProfiles()
        {
            CreateMap<BrandRequestModel, BrandDto>()
                .ForMember(prop => prop.Id, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.Id) ? Guid.Empty : Guid.Parse(o.Id))));

            CreateMap<CategoryRequestModel, CategoryDto>()
                .ForMember(prop => prop.Id, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.Id) ? Guid.Empty : Guid.Parse(o.Id))))
                .ForMember(prop => prop.ParentId, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.ParentId) ? Guid.Empty : Guid.Parse(o.ParentId))));
        }
    }
}
