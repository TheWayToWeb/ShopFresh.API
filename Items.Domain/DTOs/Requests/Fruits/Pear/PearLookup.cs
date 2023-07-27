using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using PearDomain = Items.Domain.Models.Categories.Fruits.ConcretePear.Pear.Pear;

namespace Items.Domain.DTOs.Requests.Fruits.Pear
{
    public class PearLookup : IMapWith<PearDomain>
    {
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<PearDomain, PearLookup>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath));
        }
    }
}
