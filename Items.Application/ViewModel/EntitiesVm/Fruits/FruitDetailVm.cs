using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Fruits;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Fruits
{
    public class FruitDetailVm : IMapWith<Fruit>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public string? Kind { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public int CreatedDate { get; set; }
        public string? FormRelease { get; set; }
        public string? Grade { get; set; }
        public string? CoolingMode { get; set; }
        public List<SalesRange> SaleWeights { get; set; } = new();
        public string? Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Fruit, FruitDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.Kind,
                    opt => opt.MapFrom(map => map.Kind))
                .ForMember(map => map.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(map => map.MaxTemp,
                    opt => opt.MapFrom(map => map.MaxTemp))
                .ForMember(map => map.CreatedDate,
                    opt => opt.MapFrom(map => map.CreatedDate))
                .ForMember(map => map.FormRelease,
                    opt => opt.MapFrom(map => map.FormRelease))
                .ForMember(map => map.Grade,
                    opt => opt.MapFrom(map => map.Grade))
                .ForMember(map => map.CoolingMode,
                    opt => opt.MapFrom(map => map.CoolingMode))
                .ForMember(map => map.SaleWeights,
                    opt => opt.MapFrom(map => map.SaleWeights))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description));
        }
    }
}
