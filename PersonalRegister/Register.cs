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
            if (Employees.Count > 0)
            {
                System.Console.WriteLine("----------Employees---------");

                foreach (var employee in Employees)
                {
                    System.Console.WriteLine(employee);
                }
            }
            else
            {
                System.Console.WriteLine("No employees in the employee register.");
            }
        }
    }
}