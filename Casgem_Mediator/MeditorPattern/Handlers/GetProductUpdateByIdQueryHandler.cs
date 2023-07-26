using Casgem_Mediator.DAL;
using Casgem_Mediator.MeditorPattern.Queries;
using Casgem_Mediator.MeditorPattern.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MeditorPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIdQuery, GetProductUpdateByIdQueryResult>
    {
        readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIdQueryResult> Handle(GetProductUpdateByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateByIdQueryResult
            {
                ProductBrand = values.ProductBrand,
                ProductCategory = values.ProductCategory,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductId = values.ProductId,
                ProductStock = values.ProductStock
            };
        }
    }
}
