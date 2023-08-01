using ApiAppl.Domain.Entity;
using MediatR;

namespace ApiAppl.Application.Commands.Category
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public MIOCategory UpdatedCategory { get; set; }
    }

}

