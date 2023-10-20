using AutoMapper;
using Items.Domain.Components.Orders;
using Items.Domain.DTOs.Common;

namespace Items.Application.OrderDetails.Queries.OrderDetailsQuery
{
    public class OrderDetailsVm : IMapWith<BookingDetails>
    {
        public Guid Id { get; set; }
        public float OrderPrice { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime ReceivingDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BookingDetails, OrderDetailsVm>()
                .ForMember(x => x.Id,
                    opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.OrderPrice,
                    opt => opt.MapFrom(x => x.OrderPrice))
                .ForMember(x => x.DispatchDate,
                    opt => opt.MapFrom(x => x.DispatchDate))
                .ForMember(x => x.ReceivingDate,
                    opt => opt.MapFrom(x => x.ReceivingDate));
        }
    }
}
