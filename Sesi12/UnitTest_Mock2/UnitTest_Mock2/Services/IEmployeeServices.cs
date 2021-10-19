using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock2.Model;

namespace UnitTest_Mock2.Services
{
    public interface IEmployeeServices
    {
        Task<string> GetEmployeeById(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
    }
}
