using Items.Domain.Products.Template;

namespace Items.Domain.Products.FreshItem.Drinks.MakingWater
{
    public class Water : Drink
    {
        public Water(Guid personId, Guid itemId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }

        public bool IsSparkling { get; set; }
        public string? Purpose { get; set; }
    }
}
