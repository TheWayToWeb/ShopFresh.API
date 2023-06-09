namespace Items.Domain.Products.FreshItem.Drinks
{
    public class Coffee : Eat
    {
        public string? TypeCoffee { get; set; }
        public string? KindOfCofee { get; set; }
        public string? Consistency { get; set; }
        public string? Composition { get; set; }
        public string? TasteIntensity { get; set; }
        public bool IsCoffeinFree { get; set; }
    }
}
