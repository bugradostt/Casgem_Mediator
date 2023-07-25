using MediatR;

namespace Casgem_Mediator.MeditorPattern.Commands
{
    public class CreateProductCommand:IRequest
    {
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
    }
}
