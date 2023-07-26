namespace Items.Domain.Models.Categories.Bread.CottageCheesePatty
{
    public class MakeCottageCheesePatty : MakerCottageCheesePatty
    {
        public override CottageCheesePatty CreateCottageCheesePatty()
        {
            return new CottageCheesePatty();
        }
    }
}
