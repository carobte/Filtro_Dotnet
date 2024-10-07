using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_CarolinaBustamante.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_CarolinaBustamante.Controllers.v1.RoomType
{
    [ApiController]
    [Route("api/v1/room_types")]
    [Tags("room types")]

    public class RoomTypeGetController : RoomTypeController
    {
        public RoomTypeGetController(IRoomTypeRepository roomTypeRepository) : base(roomTypeRepository)
        {
        }

        [HttpGet]
        [SwaggerOperation(
         Summary = "Get Room Types",
         Description = "Returns all the Room Types in database")]
        [SwaggerResponse(200, "Ok: Returns all the Room Types in database")]
        [SwaggerResponse(204, "No Content: There are not Room Types in the database")]

        public async Task<IActionResult> Get()
        {
            var roomTypes = await _roomTypeRepository.Get();

            if (roomTypes == null || !roomTypes.Any())
            {
                return NoContent();
            }

            return Ok(roomTypes);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
           Summary = "Get room type by id",
           Description = "Returns the specific room type information"
       )]
        [SwaggerResponse(200, "Ok: Returns the room type information")]
        [SwaggerResponse(404, "Not found: There is not room type with that id")]
        public async Task<IActionResult> GetById(int id)
        {
            var roomType = await _roomTypeRepository.GetById(id);

            if (roomType == null)
            {
                return NotFound("There is not room type with that id");
            }

            return Ok(roomType);
        }
    }
}
