using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class SessionDTO
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public string RoomName { get; set; }
        public DateTime DateTime { get; set; }  
        public int VipReserved { get; set; }
        public int NormalReserved { get; set; }
        public decimal VipPrice { get; set; }
        public decimal NormalPrice { get; set; }
        
    }
}
