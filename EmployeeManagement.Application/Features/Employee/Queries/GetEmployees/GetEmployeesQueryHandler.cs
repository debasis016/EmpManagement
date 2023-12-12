using AutoMapper;
using EmployeeManagement.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Application.Features.Employee.Queries.GetEmployees
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, List<EmployeesResponse>>
    {
        private readonly IMapper _mapper;
        private readonly EmployeeManagementDBContext _dbContext;

        public GetEmployeesQueryHandler(EmployeeManagementDBContext context, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = context;
        }

        public async Task<List<EmployeesResponse>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var allEmployees = await _dbContext.Employees.ToListAsync();
            return _mapper.Map<List<EmployeesResponse>>(allEmployees);
        }
    }
}
