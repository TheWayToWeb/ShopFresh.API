using AutoMapper;
using Items.Domain.Components.Entities.CheesyProducts;
using Items.Domain.DTOs.Requests.Common;

namespace Items.Domain.ViewModel.EntitiesVm.CheesyProducts
{
    public class CheesyProductVm : IMapWith<CheesyProduct>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CheesyProduct, CheesyProductVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price));
        }
    }
}
