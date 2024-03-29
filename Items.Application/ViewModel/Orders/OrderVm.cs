﻿using AutoMapper;
using Items.Domain.Components.Items;
using Items.Domain.Components.Orders;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.Orders
{
    public class OrderVm : IMapWith<Booking>
    {
        public Guid Id { get; set; }
        public List<Item> Items { get; set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Booking, OrderVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.Items,
                    opt => opt.MapFrom(map => map.Items));
        }
    }
}
