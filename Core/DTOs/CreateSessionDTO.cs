using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class CreateSessionDTO
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int RoomId { get; set; }
        public DateTime DateTime { get; set; }
        public int VipReserved { get; set; }
        public int NormalReserved { get; set; }
        public decimal VipPrice { get; set; }
        public decimal NormalPrice { get; set; }
    }
}
