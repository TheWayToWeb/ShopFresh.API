using AutoMapper;
using Items.Domain.Components.Promocode;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.Promocodes
{
    public class PromoCodeVm : IMapWith<Promocode>
    {
        public Guid Id { get; set; }
        public string? DiscountCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool IsActivePromocode { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Promocode, PromoCodeVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.DiscountCode,
                    opt => opt.MapFrom(map => map.DiscountCode))
                .ForMember(map => map.StartDate,
                    opt => opt.MapFrom(map => map.StartDate))
                .ForMember(map => map.FinishDate,
                    opt => opt.MapFrom(map => map.FinishDate))
                .ForMember(map => map.IsActivePromocode,
                    opt => opt.MapFrom(map => map.IsActivePromoCode));
        }
    }
}
