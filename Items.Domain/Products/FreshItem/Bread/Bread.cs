namespace Items.Domain.Products.FreshItem.Bread
{
    public abstract class Bread : Eat
    {
        public string? KindOfBread { get; set; }
        public string? Feature { get; set; }
        public string? Addition { get; set; }
        public string? TypeOfFlour { get; set; }
    }
}
