using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using ExoticFruitDomain = Items.Domain.Models.Categories.Fruits.ConcreteExoticFruit.ExoticFruit.ExoticFruit;

namespace Items.Domain.DTOs.Requests.Fruits.ExoticFruit
{
    public class ExoticLookup : IMapWith<ExoticFruitDomain>
    {
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<ExoticFruitDomain, ExoticDetailVm>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath));
        }
    }
}
