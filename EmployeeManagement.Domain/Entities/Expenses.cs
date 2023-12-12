namespace EmployeeManagement.Domain.Entities
{
    public class Expenses
    {
        public int EmployeeID { get; set; }
        public decimal MaxExpenseAmount { get; set; }

        public Employees Employees { get; set; }
    }
}
