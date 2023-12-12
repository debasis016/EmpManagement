namespace EmployeeManagement.Domain.Entities
{
    public record Supervisors
    {
        public int SupervisorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal MaxExpenseAmount { get; set; }
    }
}
