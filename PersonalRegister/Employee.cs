using System;
using System.Text;

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
            var textForNullValues = "No value";
            var sb = new StringBuilder();
            sb.Append($"Id: {(Id is null ? textForNullValues : Id.ToString())}\n");
            sb.Append($"Name: {(Name is null ? textForNullValues : Name)}\n");
            sb.Append($"Salary: {(Salary is null ? textForNullValues : Salary.ToString())}\n");
            return sb.ToString();
        }
    }
}