namespace Items.Domain.Products.FreshItem.Bakery.MakingCookie
{
    public class Cookie : Bakery
    {
        public string? ProductKindItSelf { get; set; }

        public Cookie(Guid personId, Guid itemId, string? itemName, int price, 
            string? imagePath
            ) {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
