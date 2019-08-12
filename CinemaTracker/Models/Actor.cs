using System.Collections.Generic;
using System;

namespace CinemaTracker.Models
{
    public class Actor
    {
        public int ActorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<MovieActor> Movies { get; set; }

    }
}