using MediatR;

namespace EmployeeManagement.Application.Features.Employee.Queries.GetEmployees
{
    public class GetEmployeesQuery: IRequest<List<EmployeesResponse>>
    {

    }
}
