﻿using MediatR;
using Range = Items.Domain.Products.Templates.Range;

namespace Items.Application.Products.Vegetables.Potato.Commands.CreatePotato
{
    public class CreatePotato : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int ProductExpiryDate { get; set; }
        public string? CoolingMode { get; set; }
        public string? Sort { get; set; }
        public bool IsSlicingShape { get; set; }
        public List<Range>? SaleWeights { get; set; } = new();
        public bool IsWash { get; set; }
    }
}
