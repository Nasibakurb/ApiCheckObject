using ApiAppl.Application.Commands.ObjectMIO;
using ApiAppl.Domain.Interfaces;
using MediatR;


namespace ApiAppl.Application.Handlers.ObjectMIO
{
    public class ChangeStatusCommandHandler : IRequestHandler<ChangeStatusCommand, Unit>
    {
        private readonly IObjectsMIOCheckService _service;

        public ChangeStatusCommandHandler(IObjectsMIOCheckService service)
        {
            _service = service;
        }

        public async Task<Unit> Handle(ChangeStatusCommand request, CancellationToken cancellationToken)
        {
            _service.ChangeStatus(request.Id);
            return Unit.Value;
        }


    }



}
