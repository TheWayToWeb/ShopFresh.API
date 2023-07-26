using Items.Domain.DTOs.Requests.Fruits.Apple;

namespace Items.Domain.DTOs.Responses.Fruits.Apple
{
    public class AppleListVm
    {
        public IList<AppleLookup>? Apples { get; set; }
    }
}
