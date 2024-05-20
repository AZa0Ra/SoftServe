using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Claims;

namespace Core.Services
{
    public class TicketService : ITicketService
    {
        private readonly IRepository<Ticket> ticketRepo;
        private readonly IRepository<Session> sessionRepo;
        private readonly IRepository<Room> roomRepo;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IMapper mapper;

        public TicketService(IRepository<Ticket> ticketRepo,
                             IRepository<Session> sessionRepo,
                             IRepository<Room> roomRepo,
                             IHttpContextAccessor httpContextAccessor,
                             UserManager<IdentityUser> userManager,
                             IMapper mapper)
        {
            this.ticketRepo = ticketRepo;
            this.sessionRepo = sessionRepo;
            this.roomRepo = roomRepo;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        public void CreateTicket(TicketСreateDTO ticketDto)
        {
            try
            {
                var session = sessionRepo.GetByID(ticketDto.SessionId);
                if (session == null)
                {
                    throw new HttpException("Session not found", HttpStatusCode.NotFound);
                }

                var room = roomRepo.GetByID(session.RoomId);
                if (room == null)
                {
                    throw new HttpException("Room not found", HttpStatusCode.NotFound);
                }

                int remainingVipSeats = room.VipPlaces - session.VipReserved;
                int remainingNormalSeats = room.NormalPlaces - session.NormalReserved;

                if (ticketDto.SeatType == SeatType.Vip && remainingVipSeats < ticketDto.NumberOfTickets)
                {
                    throw new HttpException("Not enough available VIP seats", HttpStatusCode.BadRequest);
                }
                else if (ticketDto.SeatType == SeatType.Normal && remainingNormalSeats < ticketDto.NumberOfTickets)
                {
                    throw new HttpException("Not enough available normal seats", HttpStatusCode.BadRequest);
                }

                var user = userManager.GetUserAsync(httpContextAccessor.HttpContext.User).Result;
                if (user == null)
                {
                    throw new HttpException("User not found", HttpStatusCode.Unauthorized);
                }

                decimal ticketPrice = (ticketDto.SeatType == SeatType.Vip ? session.VipPrice : session.NormalPrice)* ticketDto.NumberOfTickets;

                var ticket = new Ticket
                {
                    SessionId = ticketDto.SessionId,
                    UserId = user.Id,
                    SeatType = ticketDto.SeatType,
                    NumberOfTickets = ticketDto.NumberOfTickets,
                    TicketPrice = ticketPrice
                };

                ticketRepo.Insert(ticket);
                ticketRepo.Save();

                if (ticketDto.SeatType == SeatType.Vip)
                {
                    session.VipReserved += ticketDto.NumberOfTickets;
                }
                else
                {
                    session.NormalReserved += ticketDto.NumberOfTickets;
                }

                sessionRepo.Update(session);
                sessionRepo.Save();
            }
            catch (HttpException)
            {
                throw; 
            }
            catch (Exception ex)
            {
                throw new HttpException("Internal server error", HttpStatusCode.InternalServerError, ex);
            }
        }
        public IEnumerable<TicketDTO> GetAllTickets()
        {
            var tickets = ticketRepo.GetAll();
            var ticketDTOs = tickets.Select(ticket =>
            {
                var ticketDTO = mapper.Map<TicketDTO>(ticket);

                var userId = ticket.UserId;

                var user = userManager.FindByIdAsync(userId).Result;
                ticketDTO.UserName = user.UserName;

                ticketDTO.SeatType = ticket.SeatType;
                return ticketDTO;
            });
            return ticketDTOs;
        }

        public IEnumerable<TicketDTO> GetUserTickets()
        {

            var userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("User ID not found.");
            }

            var userName = httpContextAccessor.HttpContext.User.Identity.Name;

            var tickets = ticketRepo.Get(filter: t => t.UserId == userId, includeProperties: "Session");

            var ticketDTOs = tickets.Select(ticket =>
            {
                var ticketDTO = mapper.Map<TicketDTO>(ticket);
                ticketDTO.UserName = userName;
                ticketDTO.SeatType = ticket.SeatType;
                return ticketDTO;
            });

            return ticketDTOs;
        }
    }
}
