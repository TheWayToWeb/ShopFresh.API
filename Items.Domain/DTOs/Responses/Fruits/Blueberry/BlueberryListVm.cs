using Items.Domain.DTOs.Requests.Fruits.Blueberry;

namespace Items.Domain.DTOs.Responses.Fruits.Blueberry
{
    public class BlueberryListVm
    {
        public IList<BlueberryLookup>? Blueberries { get; set; }
    }
}
