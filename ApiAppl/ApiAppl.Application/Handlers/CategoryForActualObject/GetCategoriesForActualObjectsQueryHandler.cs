using ApiAppl.Application.Queries.CategoryForActualObject;
using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Interfaces;
using ApiAppl.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace ApiAppl.Application.Handlers.CategoryForActualObject
{ 
    public class GetCategoriesForActualObjectsQueryHandler : IRequestHandler<GetCategoriesForActualObjectsQuery, IEnumerable<string>>
    {
        private readonly IObjectsMIOCheckService _service;

        public GetCategoriesForActualObjectsQueryHandler(IObjectsMIOCheckService service)
        {
            _service = service;
        }

        public async Task<IEnumerable<string>> Handle(GetCategoriesForActualObjectsQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetForActualObject();
        }
    }
}
