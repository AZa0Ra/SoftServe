using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public enum SeatType
    {
        Normal = 1,
        Vip = 2
    }
    public class Ticket
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public string UserId { get; set; } 
        public SeatType SeatType { get; set; }
        public int NumberOfTickets { get; set; }
        public decimal TicketPrice { get; set; }

        public Session Session { get; set; }
        public IdentityUser User { get; set; }
    }
}
