using AutoMapper;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Persistence;
using MediatR;

namespace EmployeeManagement.Application.Features.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly EmployeeManagementDBContext _dbContext;

        public CreateEmployeeCommandHandler(EmployeeManagementDBContext context, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = context;
        }

        public async Task<Unit> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employees>(request.employee);
            _dbContext.Employees.Add(employee);
            var response = await _dbContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}