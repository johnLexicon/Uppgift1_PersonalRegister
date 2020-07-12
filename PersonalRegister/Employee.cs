namespace PersonalRegister
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }
    }
}