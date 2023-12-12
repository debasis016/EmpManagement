using EmployeeManagement.Application.Features.Employee.Commands.CreateEmployee;
using EmployeeManagement.Application.Features.Employee.Queries.GetEmployees;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllEmployees")]
        public async Task<ActionResult<List<EmployeesResponse>>> GetAllEmployees()
        {
            var dtos = await _mediator.Send(new GetEmployeesQuery());
            return Ok(dtos);
        }

        [HttpPost(Name = "Create")]
        public async Task<ActionResult<EmployeesResponse>> PostEmployee([FromBody] CreateEmployeeCommand createEmployeeCommand)
        {
            var response = await _mediator.Send(createEmployeeCommand);
            return Ok(response);
        }
    }
}
