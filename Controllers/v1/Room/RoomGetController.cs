using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_CarolinaBustamante.Controllers.v1.Room;
using PruebaNET_CarolinaBustamante.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_CarolinaBustamante.Controllers.v1.Room
{
    [ApiController]
    [Route("api/v1/rooms")]
    [Tags("rooms")]
    [Authorize]
    public class RoomGetController : RoomController
    {
        public RoomGetController(IRoomRepository roomRepository) : base(roomRepository)
        {
        }
        
        [HttpGet]
        [SwaggerOperation(
         Summary = "Get Rooms",
         Description = "Returns all the Rooms in database")]
        [SwaggerResponse(200, "Ok: Returns all the Rooms in database")]
        [SwaggerResponse(204, "No Content: There are not Rooms in the database")]

        public async Task<IActionResult> Get()
        {
            var rooms = await _roomRepository.GetAll();

            if (rooms == null || !rooms.Any())
            {
                return NoContent();
            }

            return Ok(rooms);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
           Summary = "Get room  by id",
           Description = "Returns the specific room information"
       )]
        [SwaggerResponse(200, "Ok: Returns the room information")]
        [SwaggerResponse(404, "Not found: There is not room  with that id")]
        public async Task<IActionResult> GetById(int id)
        {
            var room = await _roomRepository.GetById(id);

            if (room == null)
            {
                return NotFound("There is not room  with that id");
            }

            return Ok(room);
        }

        [HttpGet("available")]
        [SwaggerOperation(
         Summary = "Get available Rooms",
         Description = "Returns all the available Rooms in database")]
        [SwaggerResponse(200, "Ok: Returns all the available Rooms in database")]
        [SwaggerResponse(204, "No Content: There are not available Rooms in the database")]

        public async Task<IActionResult> GetAvailable()
        {
            var roomsAvailable = await _roomRepository.GetAvailable();

            if (roomsAvailable == null || !roomsAvailable.Any())
            {
                return NoContent();
            }
            return Ok(roomsAvailable);
        }

        [HttpGet("occupied")]
        [SwaggerOperation(
         Summary = "Get occupied Rooms",
         Description = "Returns all the occupied Rooms in database")]
        [SwaggerResponse(200, "Ok: Returns all the occupied Rooms in database")]
        [SwaggerResponse(204, "No Content: There are not occupied Rooms in the database")]

        public async Task<IActionResult> GetOccupied()
        {
            var roomsOccupied = await _roomRepository.GetOccupied();

            if (roomsOccupied == null || !roomsOccupied.Any())
            {
                return NoContent();
            }
            return Ok(roomsOccupied);
        }
    }
}