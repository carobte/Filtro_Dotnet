using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_CarolinaBustamante.DTO.Booking;
using PruebaNET_CarolinaBustamante.Repositories;
using Swashbuckle.AspNetCore.Annotations;

namespace PruebaNET_CarolinaBustamante.Controllers.v1.Booking
{
    [ApiController]
    [Route("api/v1/bookings")]
    [Tags("bookings")]
    [Authorize]
    public class BookingPostController : BookingController
    {
        public BookingPostController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new booking",
            Description = "Create booking in database"
        )]
        [SwaggerResponse(204, "Booking created successfully")]
        [SwaggerResponse(400, "Bad request")]

        public async Task<IActionResult> Post(BookingDTO newBooking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _bookingRepository.Create(newBooking);
            return NoContent();
        }
    }
}