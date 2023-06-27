namespace Items.Domain.Products.FreshItem.Bread.MakingPuff
{
    public class Puff : Bread
    {
        public Puff(Guid personId, Guid itemId, string? itemName, int price, string? imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
