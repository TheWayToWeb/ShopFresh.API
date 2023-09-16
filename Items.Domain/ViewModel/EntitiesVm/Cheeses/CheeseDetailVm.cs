using AutoMapper;
using Items.Domain.Components.Entities.Cheeses;
using Items.Domain.Components.Entities.Common;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Cheeses
{
    public class CheeseDetailVm : IMapWith<Cheese>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public string? Kind { get; set; }
        public string? Grade { get; set; }
        public string? FormRelease { get; set; }
        public string? Description { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public List<SalesRange> SaleWeights { get; set; } = new();
        public int CountInPackage { get; set; }
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }
        public int CreatedDate { get; set; }
        public string? Maker { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cheese, CheeseDetailVm>()
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
                .ForMember(map => map.Grade,
                    opt => opt.MapFrom(map => map.Grade))
                .ForMember(map => map.FormRelease,
                    opt => opt.MapFrom(map => map.FormRelease))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description))
                .ForMember(map => map.Protein,
                    opt => opt.MapFrom(map => map.Protein))
                .ForMember(map => map.Fat,
                    opt => opt.MapFrom(map => map.Fat))
                .ForMember(map => map.Sugar,
                    opt => opt.MapFrom(map => map.Sugar))
                .ForMember(map => map.Energy,
                    opt => opt.MapFrom(map => map.Energy))
                .ForMember(map => map.SaleWeights,
                    opt => opt.MapFrom(map => map.SaleWeights))
                .ForMember(map => map.CountInPackage,
                    opt => opt.MapFrom(map => map.CountInPackage))
                .ForMember(map => map.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(map => map.MaxTemp,
                    opt => opt.MapFrom(map => map.MaxTemp))
                .ForMember(map => map.CreatedDate,
                    opt => opt.MapFrom(map => map.CreatedDate))
                .ForMember(map => map.Maker,
                    opt => opt.MapFrom(map => map.Maker));
        }
    }
}
