using System.Collections.Generic;

namespace PersonalRegister
{
    public class Register
    {
        public IEnumerable<Employee> Employees { get; private set; }

        public void AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public void PrintEmployees()
        {
            throw new System.NotImplementedException();
        }
    }
}