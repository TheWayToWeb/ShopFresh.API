using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Water;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Beverages
{
    public class BeverageDetailVm : IMapWith<Beverage>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public List<FlavorName> Tastes { get; set; } = new();
        public string? Description { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Beverage, BeverageDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(map => map.MaxTemp,
                    opt => opt.MapFrom(map => map.MaxTemp))
                .ForMember(map => map.Tastes,
                    opt => opt.MapFrom(map => map.Tastes))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description))
                .ForMember(map => map.Protein,
                    opt => opt.MapFrom(map => map.Protein))
                .ForMember(map => map.Fat,
                    opt => opt.MapFrom(map => map.Fat))
                .ForMember(map => map.Sugar,
                    opt => opt.MapFrom(map => map.Sugar))
                .ForMember(map => map.Energy,
                    opt => opt.MapFrom(map => map.Energy));
        }
    }
}
