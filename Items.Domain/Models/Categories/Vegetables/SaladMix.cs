namespace Items.Domain.Models.Categories.Vegetables
{
    public class SaladMix : Vegetable
    {
        public List<Salad> GreeneryKinds { get; set; } = new();
    }
}
