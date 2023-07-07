﻿using MediatR;

namespace Items.Application.Products.Vegetables.Potato.Commands.UpdatePotato
{
    public class UpdatePotato : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int MinTemp { get; set; }
        public int Maxtemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int ProductExpiryDate { get; set; }
        public string? CoolingMode { get; set; }
        public bool IsFarmer { get; set; }
        public string? Sort { get; set; }
        public bool IsSlicingShape { get; set; }
    }
}