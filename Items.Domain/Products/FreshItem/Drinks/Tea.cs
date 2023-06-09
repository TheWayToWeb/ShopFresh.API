namespace Items.Domain.Products.FreshItem.Drinks
{
    public abstract class Tea : Water {
        public string? Sort { get; set; }
        public string? KindOfTea { get; set; }
    }
}
