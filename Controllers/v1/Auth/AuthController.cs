using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro_Dotnet.Config;
using Filtro_Dotnet.DTO.Auth;
using Filtro_Dotnet.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Filtro_Dotnet.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        protected readonly IEmployeeRepository _employeeRepository;
        protected readonly Utilities _utilities;
        public AuthController(IEmployeeRepository employeeRepository, Utilities utilities)
        {
            _employeeRepository = employeeRepository;
            _utilities = utilities;

        }
    }
}