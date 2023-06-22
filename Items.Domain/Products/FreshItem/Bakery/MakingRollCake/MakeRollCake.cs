namespace Items.Domain.Products.FreshItem.Bakery.FactoryRollCake
{
    public class MakeRollCake : MakerRollCake
    {
        public override RollCake CreateRollCake() {
            return new RollCake();
        }
    }
}
