using System;

namespace PersonalRegister
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
}