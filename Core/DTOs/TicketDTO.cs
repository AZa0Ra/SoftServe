using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class TicketDTO : TicketСreateDTO
    {
        public string UserName { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
