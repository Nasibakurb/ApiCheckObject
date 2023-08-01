using ApiAppl.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Application.Queries.CategoryForActualObject
{
    public class GetCategoriesForActualObjectsQuery : IRequest<IEnumerable<string>> { }
  

}
