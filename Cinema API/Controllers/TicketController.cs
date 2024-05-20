using Core.DTOs;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService ticketService;
        private readonly UserManager<IdentityUser> userManager;

        public TicketController(ITicketService ticketService, UserManager<IdentityUser> userManager)
        {
            this.ticketService = ticketService;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket([FromBody] TicketСreateDTO ticketDto)
        {
            try
            {
                ticketService.CreateTicket(ticketDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("all")]
        public IActionResult GetAllTickets()
        {
            var tickets = ticketService.GetAllTickets();
            return Ok(tickets);
        }

        [HttpGet("user")]
        public IActionResult GetUserTickets()
        {
            var tickets = ticketService.GetUserTickets();
            return Ok(tickets);
        }

    }
}
