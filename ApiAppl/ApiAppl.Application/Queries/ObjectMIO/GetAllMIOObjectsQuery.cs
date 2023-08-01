using ApiAppl.Domain.Entity;
using MediatR;

namespace ApiAppl.Application.Queries.ObjectMIO
{
    public class GetAllMIOObjectsQuery : IRequest<IEnumerable<ObjectsMIOCheck>>

    {

    }
}
