﻿using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Water
{
    public class Water : ItemFood
    {
        public List<ProductTaste> Tates { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public string? KindRelease { get; private set; }
        public bool IsCold { get; private set; }
    }
}