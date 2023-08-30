using AutoMapper;
using Items.Domain.Components.Entities.Coffee;
using Items.Domain.DTOs.Requests.Common;

namespace Items.Domain.ViewModel.Entities.CoffeeProduct
{
    public class CoffeeVm : IMapWith<Coffee>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Coffee, CoffeeVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price));
        }
    }
}
