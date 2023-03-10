using AutoMapper;
using SimpleSale.Application.DTOs.Brands;
using SimpleSale.Application.DTOs.Categories;
using SimpleSale.Core.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Application
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Brand, BrandDto>();
            CreateMap<BrandDto, Brand>()
                .ForMember(prop => prop.Id, opt => opt.MapFrom(o => ((o.Id == null || o.Id == Guid.Empty) ? Guid.NewGuid() : o.Id)))
                .ForMember(prop => prop.IsDeleted, opt => opt.MapFrom(o => false))
                .ForMember(prop => prop.CreatedOn, opt => opt.MapFrom(o => DateTime.UtcNow))
                .AfterMap((src, dest) => dest.LatestUpdatedOn = dest.CreatedOn);

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>()
                .ForMember(prop => prop.Id, opt => opt.MapFrom(o => ((o.Id == null || o.Id == Guid.Empty) ? Guid.NewGuid() : o.Id)))
                .ForMember(prop => prop.ParentId, opt => opt.MapFrom(o => ((o.ParentId == null || o.ParentId == Guid.Empty) ? (Guid?)null : o.ParentId)))
                .ForMember(prop => prop.IsDeleted, opt => opt.MapFrom(o => false))
                .ForMember(prop => prop.CreatedOn, opt => opt.MapFrom(o => DateTime.UtcNow))
                .AfterMap((src, dest) => dest.LatestUpdatedOn = dest.CreatedOn);
        }
    }
}
