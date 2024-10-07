using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.DTO.Auth;

namespace PruebaNET_CarolinaBustamante.Repositories
{
    public interface IEmployeeRepository
    {
        Task Register(RegisterEmployeeDTO employee);
        Task<string> Login(LoginDTO loginInfo);
    }
}