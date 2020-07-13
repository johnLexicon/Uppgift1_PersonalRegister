using System;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            var register = new Register();
            register.AddEmployee(new Employee { Name = "john lundgren", Salary = 30000 });
            register.AddEmployee(new Employee { Name = "kròliczka", Salary = null });
            register.AddEmployee(new Employee { Name = null, Salary = 25555 });
            var emp = new Employee();
            emp.Id = null;
            register.AddEmployee(emp);

            register.PrintEmployees();
        }
    }
}
