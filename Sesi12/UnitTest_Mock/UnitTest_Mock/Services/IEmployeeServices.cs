using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Model;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public interface IEmployeeServices
    {
        Task<string> GetEmployeeById(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
    }
}
