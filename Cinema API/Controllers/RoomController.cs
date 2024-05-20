using Core.DTOs;
using Core.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Numerics;
namespace Cinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService roomService;

        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpGet("collection")]
        public IActionResult GetAll()
        {
            return Ok(roomService.GetAll());
        }



        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(roomService.Get(id));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create([FromBody] RoomDTO room)
        {
            if (!ModelState.IsValid) return BadRequest();

            roomService.Create(room);

            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit([FromBody] RoomDTO room)
        {
            if (!ModelState.IsValid) return BadRequest();

            roomService.Edit(room);

            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute] int id)
        {
            roomService.Delete(id);
            return Ok();
        }
    }
}
