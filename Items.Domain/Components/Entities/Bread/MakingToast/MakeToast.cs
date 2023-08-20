namespace Items.Domain.Components.Entities.Bread.MakingToast
{
    public class MakeToast : MakerToast
    {
        public override Toast CreateToast()
        {
            return new Toast();
        }
    }
}
