using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.FruitDrink;
using Items.Domain.DTOs.Requests.Common;

namespace Items.Domain.ViewModel.EntitiesVm.FruitDrinks
{
    public class FruitDrinkVm : IMapWith<FruitDrink>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public int CountInPackage { get; set; }
        public int AgeLimit { get; set; }
        public List<SoldCapacity> Volume { get; set; } = new();


        public void Mapping(Profile profile)
        {
            profile.CreateMap<FruitDrink, FruitDrinkVm>()
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
                .ForMember(map => map.AgeLimit,
                    opt => opt.MapFrom(map => map.AgeLimit))
                .ForMember(map => map.Volume,
                    opt => opt.MapFrom(map => map.Volume));
        }
    }
}
