namespace Items.Domain.Components.Entities.Salads
{
    public class SaladMix : Salad
    {
        public List<Salad> GreeneryKinds { get; private set; } = new();
    }
}
