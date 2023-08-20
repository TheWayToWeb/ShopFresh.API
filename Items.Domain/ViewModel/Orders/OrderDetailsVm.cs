using AutoMapper;
using Items.Domain.Components.Orders;
using Items.Domain.DTOs.Requests.Common;

namespace Items.Domain.ViewModel.Orders
{
    public class OrderDetailsVm : IMapWith<OrderDetails>
    {
        public Guid Id { get; set; }
        public float OrderPrice { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime ReceivingDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OrderDetails, OrderDetailsVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.OrderPrice,
                    opt => opt.MapFrom(map => map.OrderPrice))
                .ForMember(map => map.DispatchDate,
                    opt => opt.MapFrom(map => map.DispatchDate))
                .ForMember(map => map.ReceivingDate,
                    opt => opt.MapFrom(map => map.ReceivingDate));
        }
    }
}
