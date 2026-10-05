namespace EmployeeRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var registry = new EmployeeRegistry();

            // Demo Employees
            registry.AddEmployee(new Employee("Maria Andersson", 45000));
            registry.AddEmployee(new Employee("Karl Johansson", 32000));
            registry.AddEmployee(new Employee("Elisabeth Karlsson", 60000));
            registry.AddEmployee(new Employee("Erik Nilsson", 19000));

            // List Employees
            registry.GetEmployees().ToList().ForEach(e =>
            {
                Console.WriteLine($"Name: {e.Name} Salary: {e.Salary} kr");
            });
        }
    }
}
