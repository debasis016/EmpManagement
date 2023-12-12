using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Application.Persistence
{
    public interface IEmployeeRepository : IAsyncRepository<Employees>
    {
        Task<List<Employees>> GetEmployees();
    }
}
