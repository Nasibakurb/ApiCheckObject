using ApiAppl.Domain.Entity;
using MediatR;
using System.Diagnostics.Contracts;

namespace ApiAppl.Application.Commands.ObjectMIO
{
    public class CreateMIOObjectCommand : IRequest<ObjectsMIOCheck>
    {
        public ObjectsMIOCheck ObjectsMIOCheck { get; set; }

    }

}
