﻿using Items.Domain.Products.FreshItem.Drinks.MakingTea;

namespace Items.Domain.Products.FreshItem.Drinks.MakingTea.MakingDryTea
{
    public class DryTea : Tea
    {
        public DryTea(Guid personId, Guid itemId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }

        public int SachetCount { get; set; }
    }
}