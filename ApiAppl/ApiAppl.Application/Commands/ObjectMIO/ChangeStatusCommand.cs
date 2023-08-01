using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Application.Commands.ObjectMIO
{
    public class ChangeStatusCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public ChangeStatusCommand(int id)
        {
            Id = id;
        }
    }

}
