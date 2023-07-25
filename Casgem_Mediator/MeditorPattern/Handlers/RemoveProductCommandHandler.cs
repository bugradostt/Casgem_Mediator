using Casgem_Mediator.DAL;
using Casgem_Mediator.MeditorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MeditorPattern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var foundId = _context.Products.Find(request.ProductId);
            _context.Products.Remove(foundId);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
