using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDTO>()
                .ForMember(b => b.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(b => b.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(b => b.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}