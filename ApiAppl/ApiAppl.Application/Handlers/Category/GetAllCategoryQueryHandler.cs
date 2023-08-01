using ApiAppl.Application.Queries.Category;
using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Interfaces;
using MediatR;

namespace ApiAppl.Application.Handlers.Category
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllMIOCategoryQuery, IEnumerable<MIOCategory>>
    {
        private readonly IMIOCategoryService _service;
        public GetAllCategoryQueryHandler(IMIOCategoryService service)
        {
            _service = service;
        }
        public async Task<IEnumerable<MIOCategory>> Handle(GetAllMIOCategoryQuery request, CancellationToken cancellationToken)
        {
            return _service.GetAllMIOCategories();
        }
    }
}
