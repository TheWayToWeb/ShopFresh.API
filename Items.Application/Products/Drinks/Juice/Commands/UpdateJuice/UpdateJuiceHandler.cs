using MediatR;

namespace Items.Application.Products.Drinks.Juice.Commands.UpdateJuice
{
    public class UpdateJuiceHandler : IRequestHandler<UpdateJuice, Unit>
    {
        public Task<Unit> Handle(UpdateJuice request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
