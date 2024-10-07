using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro_Dotnet.DTO.Auth;

namespace Filtro_Dotnet.Repositories
{
    public interface IEmployeeRepository
    {
        Task Register(RegisterEmployeeDTO employee);
        Task<string> Login(LoginDTO loginInfo);
    }
}