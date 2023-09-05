using AutoMapper;
using Items.Domain.Components.Entities.ViscousCream;
using Items.Domain.DTOs.Common;

namespace Items.Domain.DTOs.ViscousCreams
{
    public class ViscousCreamLookupDTO : IMapWith<ViscousCream>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public float Weight { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ViscousCream, ViscousCreamLookupDTO>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight));
        }
    }
}
