namespace Items.Domain.Components.Entities.Bread.MakingSingleFood
{
    public class SingleFood : Bread
    {
        public SingleFood(Guid personId, Guid itemId, string? itemName, int price, string? imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
