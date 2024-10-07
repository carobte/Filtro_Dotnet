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
    [Tags("auth employee")]
    public class LoginController : AuthController
    {
        public LoginController(IEmployeeRepository employeeRepository, Utilities utilities) : base(employeeRepository, utilities)
        {
        }

        [HttpPost]
        [Route("login")]
        [SwaggerOperation(
            Summary = "Login Employee",
            Description = "Login Employee with email and password"
        )]
        [SwaggerResponse(200, "Employee logged in successfully")]
        [SwaggerResponse(400, "Bad request")]
        [SwaggerResponse(401, "Unauthorized")]
        public async Task<IActionResult> Login(LoginDTO employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var token = await _employeeRepository.Login(employee);

            if (token == null)
            {
                return Unauthorized("An error ocurred during the login, please check your credentials and make sure you have permissions");
            }

            else { return Ok($"Here's the token: {token}"); }

        }
    }
}
