using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class TicketСreateDTO
    {
        public int SessionId { get; set; }
        public SeatType SeatType { get; set; } 
        public int NumberOfTickets { get; set; } 
    }
}
