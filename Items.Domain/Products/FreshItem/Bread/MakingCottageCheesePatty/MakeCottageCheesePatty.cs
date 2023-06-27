namespace Items.Domain.Products.FreshItem.Bread.MakingCottageCheesePatty
{
    public class MakeCottageCheesePatty : MakerCottageCheesePatty
    {
        public override CottageCheesePatty CreateCottageCheesePatty()
        {
            return new CottageCheesePatty();
        }
    }
}
