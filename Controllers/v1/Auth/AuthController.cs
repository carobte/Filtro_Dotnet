using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_CarolinaBustamante.Config;
using PruebaNET_CarolinaBustamante.DTO.Auth;
using PruebaNET_CarolinaBustamante.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_CarolinaBustamante.Controllers.v1.Auth
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