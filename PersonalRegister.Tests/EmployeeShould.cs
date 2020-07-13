using System;
using Xunit;

namespace PersonalRegister.Tests
{
    public class EmployeeShould
    {
        [Fact]
        public void CreateEmployeeWithOnlyId()
        {
            //Act
            var sut = new Employee();
            //Assert
            Assert.Null(sut.Name);
            Assert.Null(sut.Salary);
            Assert.NotNull(sut.Id);
        }

        [Fact]
        public void CreateEmployeeWithNameAndSalaryAndId()
        {
            //Arrange
            var name = "Kalle Anka";
            var salary = 30000;
            //Act
            var sut = new Employee(name, salary);
            //Assert
            Assert.Equal(name, sut.Name);
            Assert.Equal(salary, sut.Salary);
            Assert.NotNull(sut.Id);
        }

        [Fact]
        public void CreateEmployeeWithoutNameValue()
        {
            //Arrange
            var name = "";
            var salary = 10000;
            //Act
            var sut = new Employee(name, salary);
            //Assert
            Assert.Null(sut.Name);
        }

        [Fact]
        public void ReturnPrintableEmployeeInformation()
        {
            //Arrange
            var employee = new Employee("Kalle Anka", 50000);
            //Act
            var sut = employee.ToString();
            //Assert
            Assert.Contains(employee.Id.ToString(), sut);
            Assert.Contains("Kalle Anka", sut);
            Assert.Contains(50000.ToString(), sut);
        }
    }
}
