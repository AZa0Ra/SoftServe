using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITicketService
    {
        void CreateTicket(TicketСreateDTO ticketDto);
        IEnumerable<TicketDTO> GetUserTickets();
        IEnumerable<TicketDTO> GetAllTickets();
    }
}
