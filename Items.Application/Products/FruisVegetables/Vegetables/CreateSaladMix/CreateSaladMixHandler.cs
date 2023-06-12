﻿using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.FruisVegetables.Vegetables.CreateSaladMix
{
    public class CreateSaladMixHandler : IRequestHandler<CreateSaladMix, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateSaladMixHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSaladMix request, CancellationToken cancellationToken)
        {
            var saladMix = new SaladMix
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.Maxtemp,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                SaladGrades = request.SaladGrades
            };

            await _dbContext.SaladMixes.AddAsync(saladMix, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return saladMix.ItemId;
        }
    }
}