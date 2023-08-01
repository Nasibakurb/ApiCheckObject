using ApiAppl.Application.Commands.ObjectMIO;
using ApiAppl.Application.Queries.ObjectMIO;
using ApiAppl.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiAppl.Controllers
{
    [ApiController]
    [Route("api/objectsMio")]
    public class ObjectsMIOCheckController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ObjectsMIOCheckController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObjectsMIOCheck>>> GetAllMIOObjects()
        {
            var query = new GetAllMIOObjectsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }



        [HttpPost("create-objectsMIOCheck")]
        public async Task<ActionResult<ObjectsMIOCheck>> CreateMIOObject(ObjectsMIOCheck objectsMIOCheck) // Создать
        {
            var command = new CreateMIOObjectCommand { ObjectsMIOCheck = objectsMIOCheck };
            var createdObject = await _mediator.Send(command);

            if (createdObject == null)
            {
                return NotFound();
            }

            return createdObject;
        }


        [HttpPut("{id}/change-status")]
        public async Task<IActionResult> ChangeStatus(int id)
        {
            var command = new ChangeStatusCommand(id);
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return NoContent();
            }

            return NotFound();
        }
        //...........................////

        //[HttpPut("{id}/change-object")]
        //public IActionResult UpdateMIOCheck(int id, ObjectsMIOCheck updateObjectsMIOCheck) 
        //{
        //    try
        //    {
        //        _service.UpdateMIOCheck(id, updateObjectsMIOCheck);
        //        return NoContent();
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        return NotFound();
        //    }
        //}
    }
}


    
