namespace Items.Domain.Products.FreshItem.Drinks.MakingTea
{
    public abstract class Tea : Drink
    {
        public string? Sort { get; set; }
        public string? KindOfTea { get; set; }
    }
}
