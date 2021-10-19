using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitTest_Mock2.Model;
using UnitTest_Mock2.Services;

namespace UnitTest_Mock2.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        #region Property
        private readonly IEmployeeServices _employeeService;
        #endregion

        #region Constructor
        public EmployeeController(IEmployeeServices dservices)
        {
            _employeeService = dservices;
        }
        #endregion

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int EmpID)
        {
            var result = await _employeeService.GetEmployeeById(EmpID);
            return result;
        }
        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int EmpID)
        {
            var result = await _employeeService.GetEmployeeDetails(EmpID);
            return result;
        }
    }

}
