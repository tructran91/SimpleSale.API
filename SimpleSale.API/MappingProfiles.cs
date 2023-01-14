using AutoMapper;
using SimpleSale.API.ViewModels;
using SimpleSale.API.ViewModels.Brand;
using SimpleSale.API.ViewModels.Category;
using SimpleSale.Application.DTOs.Category;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.API
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();

            CreateMap<Brand, BrandResponseViewModel>();
            CreateMap<BrandRequestViewModel, Brand>()
                .ForMember(prop => prop.Id, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.Id) ? Guid.NewGuid() : Guid.Parse(o.Id))))
                .ForMember(prop => prop.IsDeleted, opt => opt.MapFrom(o => false))
                .ForMember(prop => prop.CreatedOn, opt => opt.MapFrom(o => DateTime.UtcNow))
                .AfterMap((src, dest) => dest.LatestUpdatedOn = dest.CreatedOn);

            CreateMap<CategoryResponseDto, CategoryResponseViewModel>();
            CreateMap<Category, CategoryResponseViewModel>();
            CreateMap<CategoryRequestViewModel, Category>()
                .ForMember(prop => prop.Id, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.Id) ? Guid.NewGuid() : Guid.Parse(o.Id))))
                .ForMember(prop => prop.ParentId, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.ParentId) ? (Guid?)null : Guid.Parse(o.ParentId))))
                .ForMember(prop => prop.IsDeleted, opt => opt.MapFrom(o => false))
                .ForMember(prop => prop.CreatedOn, opt => opt.MapFrom(o => DateTime.UtcNow))
                .AfterMap((src, dest) => dest.LatestUpdatedOn = dest.CreatedOn);
        }
    }
}
