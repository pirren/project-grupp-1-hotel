using Hotel.Server.Models;
using Hotel.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly RoomService _roomService;

        public RoomController(RoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var store = _roomService.Find();

            if (store == null)
            {
                return new NotFoundResult();
            }

            return Ok(store);
        }

    }
}
