using AutoMapper;
using Items.Domain.Components.Entities.Cheeses;
using Items.Domain.Components.Entities.Common;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Cheeses
{
    public class CheeseVm : IMapWith<Cheese>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public float Weight { get; set; }
        public float InParts { get; set; }
        public List<SalesRange> SaleWeights { get; set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cheese, CheeseVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight))
                .ForMember(map => map.InParts,
                    opt => opt.MapFrom(map => map.InParts))
                .ForMember(map => map.SaleWeights,
                    opt => opt.MapFrom(map => map.SalesWeights));
                
        }
    }
}
