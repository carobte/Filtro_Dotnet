using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.Config;
using PruebaNET_CarolinaBustamante.Data;
using PruebaNET_CarolinaBustamante.DTO.Auth;
using PruebaNET_CarolinaBustamante.Models;
using PruebaNET_CarolinaBustamante.Repositories;
using Microsoft.EntityFrameworkCore;

namespace PruebaNET_CarolinaBustamante.Services
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