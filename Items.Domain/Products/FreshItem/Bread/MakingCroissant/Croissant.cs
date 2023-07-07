﻿namespace Items.Domain.Products.FreshItem.Bread.MakingCroissant
{
    public class Croissant : Bread
    {
        public Croissant(Guid personId, Guid itemId, string? itemName, int price, string? imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}