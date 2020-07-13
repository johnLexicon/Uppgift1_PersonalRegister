using System.Linq;
using Xunit;

namespace PersonalRegister.Tests
{
    public class RegisterShould
    {
        [Fact]
        public void CreateEmptyCollectionOfEmployees()
        {
            //When
            var sut = new Register();
            //Then
            Assert.NotNull(sut.Employees);
        }

        [Fact]
        public void AddAnEmployee()
        {
            //Given
            var employee = new Employee();
            var sut = new Register();
            //When
            sut.AddEmployee(employee);
            //Then
            Assert.Equal(employee, sut.Employees.FirstOrDefault());
        }
    }
}