using System;

namespace PersonalRegister
{
    class Program
    {
        private static readonly Register register = new Register();
        static void Main(string[] args)
        {
            var menu = "1. Add new Employee.\n2. Print register.\n3. Quit\n";
            while (true)
            {
                System.Console.WriteLine(menu);
                Console.Write("Input: ");
                var response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        var employee = RetrieveEmployeeData();
                        register.AddEmployee(employee);
                        break;
                    case "2":
                        register.PrintEmployees();
                        break;
                    case "3":
                        return;
                    default:
                        System.Console.WriteLine($"Wrong input\n");
                        break;
                }
            }
        }

        private static Employee RetrieveEmployeeData()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Salary: ");
            var strSalary = Console.ReadLine();

            return Int32.TryParse(strSalary, out int salary) ? new Employee(name, salary) : new Employee(name, null);

        }
    }
}
