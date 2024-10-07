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
    [Route("api/v1/guests")]
    [Tags("guests")]
    public class GuestPutController : GuestController
    {
        public GuestPutController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Update guest",
            Description = "Update guest, finding it by Id and putting the newInfo"
        )]
        [SwaggerResponse(200, "guest updated")]
        [SwaggerResponse(400, "Bad request, please try again")]

        public async Task<IActionResult> Update(int id, GuestDTO newInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _guestRepository.Update(id, newInfo);
            return Ok("guest updated");
        }
    }
}