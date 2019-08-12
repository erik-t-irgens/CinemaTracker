using Microsoft.EntityFrameworkCore;

namespace CinemaTracker.Models
{
    public class CinemaTrackerContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public CinemaTrackerContext(DbContextOptions options) : base(options) { }
    }
}


//landing page with movies
//order them by genre
//click on individual movies, tell information, what genre, etc.
//current movies, trailers
//checkbox on side that would specify which ratings you want to see
//actors--see what movies they are in
//search bar: type in actor, would show which movies they are in, type in movie
//see about using api to get movies info, sending from js to c#

//controllers: genre, movie, actor, home
//views: genre: crud, details
//movie: crud, details
//actor: crud, details
//optional: msrp

//Models: movie, actor, genre, movieActor, genreMovie