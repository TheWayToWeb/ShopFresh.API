using Items.Domain.DTOs.Requests.Fruits.Banana;

namespace Items.Domain.DTOs.Responses.Fruits.Banana
{
    public class BananaListVm
    {
        public IList<BananaLookup>? Bananas { get; set; }
    }
}
