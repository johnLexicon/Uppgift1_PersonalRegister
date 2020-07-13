using System;

namespace PersonalRegister
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee() : this(null, 0)
        {
        }

        public Employee(string name, int salary)
        {
            Id = Guid.NewGuid();
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
}