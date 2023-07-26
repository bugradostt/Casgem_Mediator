using Casgem_Mediator.MeditorPattern.Results;
using MediatR;

namespace Casgem_Mediator.MeditorPattern.Queries
{
    public class GetProductUpdateByIdQuery : IRequest<GetProductUpdateByIdQueryResult>
    {
        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }

        public int Id{ get; set; }
    }
}
