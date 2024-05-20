using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Actors { get; set; }
        public string Trailer { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AgeRestriction { get; set; }
        public ICollection<Session> Sessions { get; set; } = new HashSet<Session>();
    }
}
