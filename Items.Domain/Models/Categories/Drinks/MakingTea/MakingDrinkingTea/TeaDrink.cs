﻿using Items.Domain.Models.Categories.Drinks.MakingTea;

namespace Items.Domain.Models.Categories.Drinks.MakingTea.MakingDrinkingTea
{
    public class TeaDrink : Tea
    {
        public TeaDrink(Guid personId, Guid itemId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}