using ApiAppl.Application.Commands.Category;
using ApiAppl.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Application.Handlers.Category
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Unit>
    {
        private readonly IMIOCategoryService _service;

        public UpdateCategoryCommandHandler(IMIOCategoryService service)
        {
            _service = service;
        }

        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _service.UpdateMIOCategory(request.Id, request.UpdatedCategory);
            return Unit.Value;
        }
    }



}
