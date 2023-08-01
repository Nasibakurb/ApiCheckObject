using ApiAppl.Application.Commands.Category;
using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Application.Handlers.Category
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, MIOCategory>
    {
        private readonly IMIOCategoryService _service;

        public CreateCategoryCommandHandler(IMIOCategoryService service)
        {
            _service = service;
        }

        public async Task<MIOCategory> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            return await _service.CreateMIOCategory(request.MIOCategory);
        }
    }

}
