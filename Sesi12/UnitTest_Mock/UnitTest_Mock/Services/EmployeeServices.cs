using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Model;
using Microsoft.EntityFrameworkCore;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        #region Property
        private readonly ApiDbContext _appDbContext;
        #endregion

        #region Constructor
        public EmployeeServices(ApiDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion
        public async Task<string> GetEmployeeById(int EmpID)
        {
            var name = await _appDbContext.Employee.Where(c => c.Id == EmpID).Select(d => d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetail(int EmpID)
        {
            var emp = await _appDbContext.Employee.FirstOrDefaultAsync(c => c.Id == EmpID);
            return emp;
        }

        public Task<Employee> GetEmployeeDetails(int EmpID)
        {
            throw new NotImplementedException();
        }
    }
}
