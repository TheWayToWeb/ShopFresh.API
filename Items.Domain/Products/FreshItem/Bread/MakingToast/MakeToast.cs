namespace Items.Domain.Products.FreshItem.Bread.MakingToast
{
    public class MakeToast : MakerToast
    {
        public override Toast CreateToast()
        {
            return new Toast();
        }
    }
}
