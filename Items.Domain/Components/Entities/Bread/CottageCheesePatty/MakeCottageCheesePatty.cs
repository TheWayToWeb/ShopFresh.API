namespace Items.Domain.Components.Entities.Bread.CottageCheesePatty
{
    public class MakeCottageCheesePatty : MakerCottageCheesePatty
    {
        public override CottageCheesePatty CreateCottageCheesePatty()
        {
            return new CottageCheesePatty();
        }
    }
}
