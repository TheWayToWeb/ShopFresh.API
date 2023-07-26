using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using BlackberryDomain = Items.Domain.Models.Categories.Fruits.ConcreteBlackBerry.BlackBerry.Blackberry;

namespace Items.Domain.DTOs.Requests.Fruits.Blackberry
{
    public class BlackberryLookup : IMapWith<BlackberryDomain>
    {
        public Guid ItemId { get; set; }
        public Guid ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<BlackberryDomain, BlackberryLookup>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.ItemName,
                    opt => opt.MapFrom(map => map.ItemName))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
        }
    }
}
