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
    public class SessionController : ControllerBase
    {
        private readonly ISessionService sessionService;

        public SessionController(ISessionService sessionService)
        {
            this.sessionService = sessionService;
        }

        [HttpGet("collection")]
        public IActionResult GetAll()
        {
            return Ok(sessionService.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(sessionService.Get(id));
        }

        [HttpGet("schedule")]
        public IActionResult GetSchedule([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate)
        {
            var sessions = sessionService.GetSessions(startDate, endDate);
            return Ok(sessions);
        }

        [HttpGet("search-by-film")]
        public IActionResult GetSessionsByFilmName([FromQuery] string filmName)
        {
            var sessions = sessionService.GetSessionsByFilmName(filmName);
            return Ok(sessions);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create([FromBody] CreateSessionDTO session)
        {
            if (!ModelState.IsValid) return BadRequest();

            sessionService.Create(session);

            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit([FromBody] CreateSessionDTO session)
        {
            if (!ModelState.IsValid) return BadRequest();

            sessionService.Edit(session);

            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute] int id)
        {
            sessionService.Delete(id);
            return Ok();
        }
    }
}
