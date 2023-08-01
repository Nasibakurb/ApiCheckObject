using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Application.Commands.Category
{
    public class ChangeCategoryStatusCommand : IRequest<Unit>
    {
        public int Id { get; set; }

        public ChangeCategoryStatusCommand(int id)
        {
            Id = id;
        }
    }


}
