using System.Collections.Generic;

namespace PersonalRegister
{
    public class Register
    {
        public IList<Employee> Employees { get; private set; } = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void PrintEmployees()
        {
            foreach (var employee in Employees)
            {
                System.Console.WriteLine(employee);
            }
        }
    }
}