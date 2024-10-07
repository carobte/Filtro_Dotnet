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
    [Tags("auth")]
    public class RegisterController : AuthController
    {
        public RegisterController(IEmployeeRepository employeeRepository, Utilities utilities) : base(employeeRepository, utilities)
        {
        }

        [HttpPost]
        [Route("register")]
        [SwaggerOperation(
            Summary = "Register employee",
            Description = "Register employee in database"
        )]
        [SwaggerResponse(201, "Created: Employeed registered successfully")]
        [SwaggerResponse(400, "Bad request")]

        public async Task<IActionResult> Post(RegisterEmployeeDTO newEmployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _employeeRepository.Register(newEmployee);
            return Created();
        }
    }
}