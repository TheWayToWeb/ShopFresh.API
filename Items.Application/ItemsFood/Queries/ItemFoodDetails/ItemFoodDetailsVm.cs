using AutoMapper;
using Items.Domain.Components.Items;
using Items.Domain.DTOs.Common;

namespace Items.Application.ItemsFood.Queries.ItemFoodDetails
{
    public class ItemFoodDetailsVm : IMapWith<ItemFood>
    {
        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
        public string Maker { get; set; }
        public int CountInPackage { get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CreatedDate { get; set; }
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ItemFood, ItemFoodDetailsVm>()
                .ForMember(x => x.Id,
                    opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.BrandName,
                    opt => opt.MapFrom(x => x.Brand.BrandName))
                .ForMember(x => x.Price,
                    opt => opt.MapFrom(x => x.Price))
                .ForMember(x => x.ImagePath,
                    opt => opt.MapFrom(x => x.ImagePath))
                .ForMember(x => x.Maker,
                    opt => opt.MapFrom(x => x.Maker))
                .ForMember(x => x.CountInPackage,
                    opt => opt.MapFrom(x => x.CountInPackage))
                .ForMember(x => x.Weight,
                    opt => opt.MapFrom(x => x.Weight))
                .ForMember(x => x.Description,
                    opt => opt.MapFrom(x => x.Description))
                .ForMember(x => x.Protein,
                    opt => opt.MapFrom(x => x.Protein))
                .ForMember(x => x.Fat,
                    opt => opt.MapFrom(x => x.Fat))
                .ForMember(x => x.Sugar,
                    opt => opt.MapFrom(x => x.Sugar))
                .ForMember(x => x.Energy,
                    opt => opt.MapFrom(x => x.Energy))
                .ForMember(x => x.CreatedDate,
                    opt => opt.MapFrom(x => x.CreatedDate))
                .ForMember(x => x.MinTemp,
                    opt => opt.MapFrom(x => x.MinTemp))
                .ForMember(x => x.MaxTemp,
                    opt => opt.MapFrom(x => x.MaxTemp));
        }
    }
}
