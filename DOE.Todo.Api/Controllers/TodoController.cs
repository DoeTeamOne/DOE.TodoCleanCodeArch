using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DOE.Todo.Api.Controllers
{
    [ApiController]
    [Route("Todo")]
    public class TodoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodoController(IMediator mediator)
        {
            _mediator = mediator;

        }


        [HttpGet("TodoList")]
        public async Task<ActionResult> countryList()
        {
            var req = new GetTodoCommand();

            return Ok(await _mediator.Send(req));
        }

    }
}
