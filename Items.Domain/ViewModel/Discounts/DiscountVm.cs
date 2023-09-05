using AutoMapper;
using Items.Domain.Components.Discount;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.Discounts
{
    public class DiscountVm : IMapWith<Discount>
    {
        public Guid Id { get; set; }
        public float Percent { get; set; }
        public DateTime StartDiscount { get; set; }
        public DateTime FinishDiscount { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<Discount, DiscountVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.Percent,
                    opt => opt.MapFrom(map => map.Percent))
                .ForMember(map => map.StartDiscount,
                    opt => opt.MapFrom(map => map.StartDiscount))
                .ForMember(map => map.FinishDiscount,
                    opt => opt.MapFrom(map => map.FinishDiscount));
        }
    }
}
