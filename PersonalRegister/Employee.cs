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
            var textForNullValues = "No value";
            return @$"
            Id: {(Id is null ? textForNullValues : Id.ToString())}, 
            Name: {(Name is null ? textForNullValues : Name)}, 
            Salary: {(Salary is null ? textForNullValues : Salary.ToString())}
            ";
        }
    }
}