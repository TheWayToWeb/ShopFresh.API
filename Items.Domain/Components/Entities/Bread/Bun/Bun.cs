namespace Items.Domain.Components.Entities.Bread.Bun
{
    public class Bun : Bread
    {
        public Bun(Guid personId, Guid itemId, string? itemName, int price, string? imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
