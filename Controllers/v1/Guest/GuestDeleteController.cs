using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_CarolinaBustamante.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_CarolinaBustamante.Controllers.v1.Guest
{
    [ApiController]
    [Route("api/v1/guests")]
    [Tags("guests")]
    [Authorize]
    public class GuestDeleteController : GuestController
    {
        public GuestDeleteController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(
        Summary = "Delete guest",
        Description = "Delete guest, using its Id")]
        [SwaggerResponse(204, "guest deleted successfully")]

        public async Task<IActionResult> Delete(int id)
        {
            await _guestRepository.Delete(id);
            return NoContent();
        }
    }
}