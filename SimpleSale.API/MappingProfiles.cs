using AutoMapper;
using SimpleSale.API.ViewModels;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.API
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();

            CreateMap<BrandViewModel, Brand>()
                .ForMember(prop => prop.Id, opt => opt.MapFrom(o => (string.IsNullOrEmpty(o.Id) ? Guid.NewGuid() : Guid.Parse(o.Id))))
                .ForMember(prop => prop.IsDeleted, opt => opt.MapFrom(o => false))
                .ForMember(prop => prop.CreatedOn, opt => opt.MapFrom(o => DateTime.UtcNow))
                .AfterMap((src, dest) => dest.LatestUpdatedOn = dest.CreatedOn)
                .ReverseMap();
        }
    }
}
