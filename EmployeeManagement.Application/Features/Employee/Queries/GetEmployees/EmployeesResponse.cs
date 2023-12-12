namespace EmployeeManagement.Application.Features.Employee.Queries.GetEmployees
{
    public class EmployeesResponse
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public decimal Payment { get; set; }
        public ENums.EmployeeType EmployeeType { get; set; }
        public ENums.PaymentType PaymentType { get; set; }
    }
}
