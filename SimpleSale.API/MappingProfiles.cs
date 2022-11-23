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
        }
    }
}
