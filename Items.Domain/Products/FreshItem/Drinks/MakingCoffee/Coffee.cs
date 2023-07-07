namespace Items.Domain.Products.FreshItem.Drinks.MakingCoffee
{
    public class Coffee : Drink
    {
        public string? TypeCoffee { get; set; }
        public string? KindOfCofee { get; set; }
        public string? Consistency { get; set; }
        public string? Composition { get; set; }
        public string? TasteIntensity { get; set; }
        public bool IsCoffeinFree { get; set; }

        public Coffee(Guid personId, Guid itemId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
