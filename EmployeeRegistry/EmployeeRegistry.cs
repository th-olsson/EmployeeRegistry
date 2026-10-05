namespace EmployeeRegistry
{
    public class EmployeeRegistry
    {
        private readonly List<Employee> _employees = [];

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IReadOnlyList<Employee> GetEmployees(){
            return _employees;
        }
    }
}
