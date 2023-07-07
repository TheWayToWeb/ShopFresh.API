namespace Items.Domain.Products.FreshItem.Drinks.MakingSoyMilk
{
    public class SoyMilk : Drink
    {
        public string? KindOfMilk { get; set; }

        public SoyMilk(Guid personId, Guid itemId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
