using AutoMapper;
using Items.Domain.Components.Entities.Eggs;
using Items.Domain.DTOs.Common;

namespace Items.Domain.DTOs.Eggs
{
    public class EggLookupDTO : IMapWith<Egg>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public float Weight { get; set; }
        public int CountInPackage { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Egg, EggLookupDTO>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight))
                .ForMember(map => map.CountInPackage,
                    opt => opt.MapFrom(map => map.CountInPackage));
        }
    }
}
