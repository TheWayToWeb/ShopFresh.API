using Items.Domain.DTOs.Requests.Fruits.Apple;
using MediatR;

namespace Items.Domain.DTOs.Responses.Fruits.Apple
{
    public class GetAppleDetails : IRequest<AppleDetailVm>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
