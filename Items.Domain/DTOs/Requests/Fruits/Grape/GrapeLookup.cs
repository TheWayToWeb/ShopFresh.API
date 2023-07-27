using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using GrapeDomain = Items.Domain.Models.Categories.Fruits.ConcreteGrape.Grape.Grape;

namespace Items.Domain.DTOs.Requests.Fruits.Grape
{
    public class GrapeLookup : IMapWith<GrapeDomain>
    {
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<GrapeDomain, GrapeLookup>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath));
        }
    }
}
