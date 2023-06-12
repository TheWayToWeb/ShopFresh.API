﻿using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.FruisVegetables.Vegetables.CreateMarrow
{
    public class CreateMarrowHandler : IRequestHandler<CreateMarrow, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateMarrowHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateMarrow request, CancellationToken cancellationToken)
        {
            var marrow = new Marrow
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Grade = request.Grade
            };

            await _dbContext.Marrows.AddAsync(marrow, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return marrow.ItemId;
        }
    }
}