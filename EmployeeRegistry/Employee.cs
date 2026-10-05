namespace EmployeeRegistry
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
