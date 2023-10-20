using AutoMapper;
using Items.Domain.Components.Items;
using Items.Domain.Components.Orders;
using Items.Domain.DTOs.Common;

namespace Items.Application.Orders.Queries.OrderDetailsQuery
{
    public class OrderVm : IMapWith<Booking>
    {
        public Guid Id { get; set; }
        public IEnumerable<Item> Items { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Booking, OrderVm>()
                .ForMember(x => x.Id,
                    opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.Items,
                    opt => opt.MapFrom(x => x.Items));
        }
    }
}
