using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_CarolinaBustamante.DTO.Guest;
using PruebaNET_CarolinaBustamante.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_CarolinaBustamante.Controllers.v1.Guest
{
    [ApiController]
    [Route("api/v1/guest")]
    [Tags("guests")]
    public class GuestPostController : GuestController
    {
        public GuestPostController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new guest",
            Description = "Register guest in database"
        )]
        [SwaggerResponse(204, "Created: guest registered successfully")]
        [SwaggerResponse(400, "Bad request")]

        public async Task<IActionResult> Post(GuestDTO newguest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _guestRepository.Register(newguest);
            return NoContent();
        }
    }
}