using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film? Film { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public DateTime DateTime { get; set; }
        public int VipReserved { get; set; }
        public int NormalReserved { get; set; }
        public decimal VipPrice { get; set; }
        public decimal NormalPrice { get; set; }
        //public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
        
        
    }
}
