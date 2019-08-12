using System.Collections.Generic;

namespace CinemaTracker.Models
{
    public class Movie
    {
        public Movie()
        {
            Genres = new HashSet<GenreMovie>();

            Actors = new HashSet<MovieActor>();
        }
        public int MovieId { get; set; }
        public string Title { get; set; }

        public string MPAARating { get; set; }

        public float Rating { get; set; }

        public ICollection<GenreMovie> Genres { get; set; }

        public ICollection<MovieActor> Actors { get; set; }
    }
}

//don't understand why we are creating hash sets in constructor