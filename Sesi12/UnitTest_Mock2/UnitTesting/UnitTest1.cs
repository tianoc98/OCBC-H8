using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using UnitTest_Mock2.Controllers;
using UnitTest_Mock2.Services;
using UnitTest_Mock2.Model;
using Xunit;

namespace Testing
{
    public class EmployeeTest
    {
        #region Property
        public Mock<IEmployeeServices> mock = new Mock<IEmployeeServices>();
        #endregion
        [Fact]
        public async void GetEmployeeById()
        {
            mock.Setup(p => p.GetEmployeeById(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("JK", result);
        }
        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "JK",
                Designation = "SDE"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
        }
    }
}
