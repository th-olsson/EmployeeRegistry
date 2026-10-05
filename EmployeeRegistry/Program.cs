namespace EmployeeRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var registry = new EmployeeRegistry();

            // Prepare user input
            string? userInput;
            do
            {
                Console.Clear();
                Console.WriteLine("Employee Registry \n");

                // Available commands
                Console.WriteLine("Available commands:");
                Console.WriteLine(" a - Add employee");
                Console.WriteLine(" l - List employees");
                Console.WriteLine(" e - Exit application \n");

                // Take user input
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case "a":
                        // Add Employee
                        {
                            string name;
                            decimal salary;

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Add Employee \n");

                                Console.WriteLine("Enter name:");
                                name = Console.ReadLine();
                            } while (name?.Length < 2); // Repeat prompt until at least two characters

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Add Employee \n");

                                Console.WriteLine($"Enter salary of {name}");
                                var input = Console.ReadLine();
                                Decimal.TryParse(input, out salary);
                            } while (salary <= 0); // Repeat prompt until salary is more than zero

                            registry.AddEmployee(new Employee(name, salary));
                            break;
                        }
                    case "l":
                        // List Employees
                        {
                            Console.Clear();
                            Console.WriteLine($"Current employees: {registry.GetEmployees().Count()} \n");
                            var employees = registry
                                .GetEmployees()
                                .ToList();

                            employees.ForEach(e =>
                                {
                                    Console.WriteLine($"Name: {e.Name}, Salary: {e.Salary} kr");
                                });

                            if (employees.Count > 0)
                            {
                                Console.WriteLine();
                            }

                            Console.WriteLine("Press any key to return");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (userInput != "e");
        }
    }
}