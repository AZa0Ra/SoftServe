using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int VipPlaces { get; set; }
        public int NormalPlaces { get; set; }
        public ICollection<Session> Sessions { get; set; } = new HashSet<Session>();
    }
}
