using ApiAppl.Domain.Entity;
using MediatR;

namespace ApiAppl.Application.Commands.Category
{
    public class CreateCategoryCommand : IRequest<MIOCategory>
    {
        public MIOCategory MIOCategory { get; set; }
    }

}
