using MediatR;

namespace EmployeeManagement.Application.Features.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommandDto
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public decimal Payment { get; set; }
        public ENums.EmployeeType EmployeeType { get; set; }
        public ENums.PaymentType PaymentType { get; set; }
    }

    public class CreateEmployeeCommand : IRequest<Unit>
    {
        public CreateEmployeeCommandDto employee { get; init; }
        public CreateEmployeeCommand()
        {
            employee = new CreateEmployeeCommandDto();
        }
    }
}
