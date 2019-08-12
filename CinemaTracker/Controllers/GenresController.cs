using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CinemaTracker.Models;

namespace CinemaTracker.Controllers
{
    public class GenresController : Controller
    {
        private readonly CinemaTrackerContext _db;

        public GenresController(CinemaTrackerContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Genre> model = _db.Genres.ToList();
            // Produced a list of genres, clickable
            // BY getting list of genres from the database and passing them into the view.
            return View(model);
        }

        public ActionResult Create()
        {
            // Create a new genre (using the constructor and the Model)
            // Check to make sure genre doesn't exist already in the database **
            return View();
        }

        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            _db.Genres.Add(genre);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            // Genre => Genre.GenreId == id);
            // get the list of genremovie
            // get the list of movies
            // return the first or default that = genre id

            var thisGenre = _db.Genres
                .Include(genre => genre.Movies)
                .ThenInclude(join => join.Movie)
                .FirstOrDefault(genre => genre.GenreId == id);
            return View(thisGenre);
        }

        public ActionResult Edit(int id)
        {
            var thisGenre = _db.Genres.FirstOrDefault(genre => genre.GenreId == id);
            return View(thisGenre);
        }

        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            // Take the genre that we got from our Edit view(thisGenre)
            // Update that information using a form
            _db.Entry(genre).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details", genre.GenreId);
        }

        public ActionResult Delete(int id)
        {
            var thisGenre = _db.Genres.FirstOrDefault(genre => genre.GenreId == id);
            return View(thisGenre);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var thisGenre = _db.Genres.FirstOrDefault(genre => genre.GenreId == id);
            _db.Genres.Remove(thisGenre);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
