namespace Items.Domain.Models.Categories.Bread.MakingToast
{
    public class MakeToast : MakerToast
    {
        public override Toast CreateToast()
        {
            return new Toast();
        }
    }
}
