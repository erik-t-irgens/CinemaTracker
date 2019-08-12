using System.Collections.Generic;

namespace CinemaTracker.Models
{
    public class Genre
    {
        public Genre()
        {
            Movies = new HashSet<GenreMovie>();
        }
        public int GenreId { get; set; }

        public string Name { get; set; }

        public ICollection<GenreMovie> Movies { get; set; }
    }
}