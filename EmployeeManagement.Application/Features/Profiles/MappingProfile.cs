using AutoMapper;
using EmployeeManagement.Application.Features.Employee.Queries.GetEmployees;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Application.Features.Employee.Commands.CreateEmployee;

namespace EmployeeManagement.Application.Features.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Employees, EmployeesResponse>().ReverseMap();
            CreateMap<Employees, CreateEmployeeCommandDto>().ReverseMap();
        }
    }
}
