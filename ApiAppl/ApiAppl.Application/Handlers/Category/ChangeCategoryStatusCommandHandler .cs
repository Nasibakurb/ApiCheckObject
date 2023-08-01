using ApiAppl.Application.Commands.Category;
using ApiAppl.Domain.Enum;
using ApiAppl.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Application.Handlers.Category
{
    public class ChangeCategoryStatusCommandHandler : IRequestHandler<ChangeCategoryStatusCommand, Unit>
    {
        private readonly IMIOCategoryRepository _repository;

        public ChangeCategoryStatusCommandHandler(IMIOCategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(ChangeCategoryStatusCommand request, CancellationToken cancellationToken)
        {
            var mioCategory = await _repository.GetCategoryById(request.Id);
            if (mioCategory == null)
            {
                throw new InvalidOperationException("ObjectMIOCheck not found");
            }

            mioCategory.StatusNameCategory = mioCategory.StatusNameCategory == Status.Canceled ? Status.Accepted : Status.Canceled;

            await _repository.SaveChanges();

            return Unit.Value;
        }
    }




}


