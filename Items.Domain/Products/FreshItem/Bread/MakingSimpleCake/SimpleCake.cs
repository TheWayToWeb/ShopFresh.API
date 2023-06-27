namespace Items.Domain.Products.FreshItem.Bread.MakingSimpleCake
{
    public class SimpleCake : Bread
    {
        public SimpleCake(Guid personId, Guid itemId, string? itemName, int price, string? imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
