using System;

namespace PersonalRegister
{
    public class Employee
    {
        //Guid is a value type
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public int? Salary { get; set; }

        public Employee() : this(null, null)
        {
        }

        public Employee(string name, int? salary)
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