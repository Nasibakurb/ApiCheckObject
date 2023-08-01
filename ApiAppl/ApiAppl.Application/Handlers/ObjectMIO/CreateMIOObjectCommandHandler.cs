using ApiAppl.Application.Commands.ObjectMIO;
using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Interfaces;
using MediatR;

namespace ApiAppl.Application.Handlers.ObjectMIO
{
    public class CreateMIOObjectCommandHandler : IRequestHandler<CreateMIOObjectCommand, ObjectsMIOCheck>
    {
        private readonly IObjectsMIOCheckService _service;

        public CreateMIOObjectCommandHandler(IObjectsMIOCheckService service)
        {
            _service = service;
        }

        public async Task<ObjectsMIOCheck> Handle(CreateMIOObjectCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return await _service.CreateMIOObject(request.ObjectsMIOCheck);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
    }

}



