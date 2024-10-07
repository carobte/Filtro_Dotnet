using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro_Dotnet.Config;
using Filtro_Dotnet.Data;
using Filtro_Dotnet.DTO.Auth;
using Filtro_Dotnet.Models;
using Filtro_Dotnet.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Filtro_Dotnet.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        protected readonly AppDbContext _context;
        protected readonly Utilities _utilities;
        public async Task Register(RegisterEmployeeDTO employee)
        {
            employee.Password = _utilities.EncryptSHA256(employee.Password);

            var newEmployee = new Employee
            {
                FirstName = employee.FirstName.ToLower(),
                LastName = employee.LastName.ToLower(),
                IdNumber = employee.IdNumber,
                Email = employee.Email.ToLower(),
                Password = employee.Password,
            };

            _context.Employees.Add(newEmployee);
            await _context.SaveChangesAsync();
        }

        public async Task<string> Login(LoginDTO loginInfo)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(employee => employee.Email == loginInfo.Email);

            if (employee == null)
            { // employee doesn't exist in db
                return null;
            }

            if (employee.Password == _utilities.EncryptSHA256(loginInfo.Password)) // validate password
            {
                var token = _utilities.GenerateJwtToken(employee);
                return token;
            }

            return null; // if password is incorrect
        }
    }
}