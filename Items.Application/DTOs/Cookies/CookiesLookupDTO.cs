﻿using AutoMapper;
using Items.Domain.Components.Entities.Cookies;
using Items.Domain.DTOs.Common;

namespace Items.Domain.DTOs.Cookies
{
    public class CookiesLookupDTO : IMapWith<Cookie>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public float Weight { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cookie, CookiesLookupDTO>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight));
        }
    }
}
