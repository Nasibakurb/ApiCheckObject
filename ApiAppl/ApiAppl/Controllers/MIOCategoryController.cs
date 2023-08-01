using ApiAppl.Application.Commands.Category;
using ApiAppl.Application.Queries;
using ApiAppl.Application.Queries.Category;
using ApiAppl.Application.Queries.CategoryForActualObject;
using ApiAppl.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiAppl.Controllers
{
    [ApiController]
    [Route("api/miocategories")]
    public class MIOCategoryController : Controller
    {
        private readonly IMediator _mediator;

        public MIOCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MIOCategory>>> GetAllMIOCategories()
        {
            var query = new GetAllMIOCategoryQuery();
            var mioCategories = await _mediator.Send(query);
            return Ok(mioCategories);
        }

        [HttpPost("create-category")]
        public async Task<ActionResult<MIOCategory>> CreateMIOCategory(MIOCategory category)
        {
            var command = new CreateCategoryCommand { MIOCategory = category };
            var createdCategory = await _mediator.Send(command);
            return Ok(createdCategory);
        }

        [HttpPut("{id}/change-category")]
        public async Task<IActionResult> UpdateMIOCategory(int id, MIOCategory updatedCategory)
        {
            var command = new UpdateCategoryCommand { Id = id, UpdatedCategory = updatedCategory };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}/change-status")]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var command = new ChangeCategoryStatusCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpGet("categories-for-actual-objects")]
        public async Task<ActionResult<IEnumerable<string>>> GetCategoriesForActualObjects()
        {
            var query = new GetCategoriesForActualObjectsQuery();
            var categories = await _mediator.Send(query);

            return Ok(categories);
        }
    }
}
