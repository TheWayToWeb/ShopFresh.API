using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using RaspberryDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteRaspberry.Raspberry.Raspberry;

namespace Items.Domain.DTOs.Requests.Fruits.Raspberry
{
    public class RaspberryLookup : IMapWith<RaspberryDomain>
    {
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<RaspberryDomain, RaspberryLookup>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath));
        }
    }
}
