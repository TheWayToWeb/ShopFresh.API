namespace Items.Domain.Products.FreshItem.Bakery.MakingRollCake
{
    public class RollCake : Bakery
    {
        public RollCake(
            Guid personId,
            Guid itemId,
            string? itemName,
            int price,
            string? imagePath
        ) 
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
