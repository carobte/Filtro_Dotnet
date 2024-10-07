using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_CarolinaBustamante.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_CarolinaBustamante.Controllers.v1.Guest
{
    [ApiController]
    [Route("api/v1/guests")]
    [Tags("guests")]
    public class GuestGetController : GuestController
    {
        public GuestGetController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpGet]
        [SwaggerOperation(
         Summary = "Get guests",
         Description = "Returns all the guests in database")]
        [SwaggerResponse(200, "Ok: Returns all the guests in database")]
        [SwaggerResponse(204, "No Content: There are not guests in the database")]

        public async Task<IActionResult> Get()
        {
            var guests = await _guestRepository.Get();

            if (guests == null || !guests.Any())
            {
                return NoContent();
            }

            return Ok(guests);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
           Summary = "Get guest  by id",
           Description = "Returns the specific guest information"
       )]
        [SwaggerResponse(200, "Ok: Returns the guest information")]
        [SwaggerResponse(404, "Not found: There is not guest  with that id")]
        public async Task<IActionResult> GetById(int id)
        {
            var guest = await _guestRepository.GetById(id);

            if (guest == null)
            {
                return NotFound("There is not guest  with that id");
            }

            return Ok(guest);
        }

        [HttpGet("search/{keyword}")]
        [SwaggerOperation(
           Summary = "Get the first guest by keyword",
           Description = "Returns the specific first guest information searching by keyword"
       )]
        [SwaggerResponse(200, "Ok: Returns the specific first guest information")]
        [SwaggerResponse(404, "Not found: There is not guest with that name or last name")]
        public async Task<IActionResult> GetByKeyword(string keyword)
        {
            var guests = await _guestRepository.GetByKeyword(keyword);

            if (guests == null)
            {
                return NotFound("There is not guest with that name or last name");
            }

            return Ok(guests);
        }


    }
}