namespace Items.Domain.Products.FreshItem.Bread.MaikingBaguette
{
    public class Baguette : Bread
    {
        public Baguette(Guid personId, Guid itemId, string? itemName, int price, string? imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
