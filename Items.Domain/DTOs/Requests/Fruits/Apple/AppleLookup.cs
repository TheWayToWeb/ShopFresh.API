using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using AppleDomain = Items.Domain.Models.Categories.Fruits.ConcreteApple.Apple.Apple;

namespace Items.Domain.DTOs.Requests.Fruits.Apple
{
    public class AppleLookup : IMapWith<AppleDomain>
    {
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<AppleDomain, AppleLookup>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.ItemName,
                    opt => opt.MapFrom(map => map.ItemName))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath));
        }
    }
}
