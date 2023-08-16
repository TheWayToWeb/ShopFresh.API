namespace Items.Domain.Components.Entities.Categories.Salads
{
    public class SaladMix : Salad
    {
        public List<Salad> GreeneryKinds { get; private set; } = new();
    }
}
