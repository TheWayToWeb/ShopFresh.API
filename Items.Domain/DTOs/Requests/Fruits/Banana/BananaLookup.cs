using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using BananaDomain = Items.Domain.Models.Categories.Fruits.ConcreteBanana.Banana.Banana;

namespace Items.Domain.DTOs.Requests.Fruits.Banana
{
    public class BananaLookup : IMapWith<BananaDomain>
    {
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<BananaDomain, BananaLookup>()
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
