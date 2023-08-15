using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using FruitDomain = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.DTOs.Requests.Fruits.Fruit
{
    public class FruitLookup : IMapWith<FruitDomain>
    {
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<FruitDomain, FruitLookup>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath));
        }
    }
}
