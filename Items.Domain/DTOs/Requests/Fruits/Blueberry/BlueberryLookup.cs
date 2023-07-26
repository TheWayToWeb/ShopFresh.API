using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using BlueberryDomain = Items.Domain.Models.Categories.Fruits.ConcreteBluBerry.BlueBerry.Blueberry;

namespace Items.Domain.DTOs.Requests.Fruits.Blueberry
{
    public class BlueberryLookup : IMapWith<BlueberryDomain>
    {
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<BlueberryDomain, BlueberryLookup>()
                .ForMember(mapVm => mapVm.ItemId,
                    option => option.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.ItemName,
                    option => option.MapFrom(map => map.ItemName))
                .ForMember(mapVm => mapVm.Price,
                    option => option.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    option => option.MapFrom(map => map.ImagePath));
        }
    }
}
