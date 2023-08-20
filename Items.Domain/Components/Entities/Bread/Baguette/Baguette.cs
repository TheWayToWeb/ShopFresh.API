namespace Items.Domain.Components.Entities.Bread.Baguette
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
