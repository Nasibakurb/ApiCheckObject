using ApiAppl.Domain.Entity;
using MediatR;

namespace ApiAppl.Application.Queries.Category
{
    public class GetAllMIOCategoryQuery : IRequest<IEnumerable<MIOCategory>>
    {
    }
}
