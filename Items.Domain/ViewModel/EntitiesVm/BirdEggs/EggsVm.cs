using AutoMapper;
using Items.Domain.Components.Entities.Eggs;
using Items.Domain.DTOs.Requests.Common;

namespace Items.Domain.ViewModel.EntitiesVm.BirdEggs
{
    public class EggsVm : IMapWith<Egg>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public int CountInPackage { get; set; }
        public string? Category { get; set; }
        public string? Kind { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Egg, EggsVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.CountInPackage,
                    opt => opt.MapFrom(map => map.CountInPackage))
                .ForMember(map => map.Category,
                    opt => opt.MapFrom(map => map.Category))
                .ForMember(map => map.Kind,
                    opt => opt.MapFrom(map => map.Kind));
        }
    }
}
