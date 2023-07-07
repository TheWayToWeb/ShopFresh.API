namespace Items.Domain.Products.FreshItem.Drinks.MakingTea
{
    public abstract class Tea : Drink
    {
        public string? Grade { get; set; }
        public string? KindOfTea { get; set; }
    }
}
