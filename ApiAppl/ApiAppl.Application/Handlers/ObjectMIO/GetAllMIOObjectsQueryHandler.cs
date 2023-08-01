using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Interfaces;
using MediatR;
using ApiAppl.Infrastructure.Service;
using ApiAppl.Application.Queries.ObjectMIO;

namespace ApiAppl.Application.Handlers.ObjectMIO
{
    public class GetAllMIOObjectsQueryHandler : IRequestHandler<GetAllMIOObjectsQuery, IEnumerable<ObjectsMIOCheck>>
    {
        private readonly IObjectsMIOCheckService _service;

        public GetAllMIOObjectsQueryHandler(IObjectsMIOCheckService service)
        {
            _service = service;
        }

        public async Task<IEnumerable<ObjectsMIOCheck>> Handle(GetAllMIOObjectsQuery request, CancellationToken cancellationToken)
        {
            return _service.GetAllMIOObjects();
        }
    }

}
