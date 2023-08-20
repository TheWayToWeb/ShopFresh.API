namespace Items.Domain.Components.Entities.Bread.MakingFlapJack
{
    public class FlapJack : Bread
    {
        public FlapJack(Guid personId, Guid itemId, string? itemName, int price, string? imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
