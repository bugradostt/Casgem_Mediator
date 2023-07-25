using MediatR;

namespace Casgem_Mediator.MeditorPattern.Commands
{
    public class RemoveProductCommand : IRequest
    {
        public RemoveProductCommand(int id)
        {
            ProductId = id;
        }

        public int ProductId { get; set; }
    }
}
