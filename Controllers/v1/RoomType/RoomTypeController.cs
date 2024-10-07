using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_CarolinaBustamante.Repositories;

namespace PruebaNET_CarolinaBustamante.Controllers.v1.RoomType
{
    [ApiController]
    [Route("api/v1/room_types")]
    public class RoomTypeController : ControllerBase
    {
        protected readonly IRoomTypeRepository _roomTypeRepository;

        public RoomTypeController(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }
    }
}