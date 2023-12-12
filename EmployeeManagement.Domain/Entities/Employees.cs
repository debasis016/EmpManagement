namespace EmployeeManagement.Domain.Entities
{
    public record Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public decimal Payment { get; set; }
        public int EmployeeType { get; set; }
        public int PaymentType { get; set; }

        public Expenses? Expenses { get; set; }
    }
}
