using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CinemaTracker.Models;

namespace CinemaTracker.Controllers
{

    public class MoviesController : Controller
    {
        private readonly CinemaTrackerContext _db;

        public MoviesController(CinemaTrackerContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var model = _db.Movies.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            //make droplist selectlist of genres, gets from db
            return View();
        }

        public ActionResult Create(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
            return View(thisMovie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            _db.Entry(movie).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details", movie.MovieId); //might not work
        }

        public ActionResult Delete(int id)
        {
            var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
            return View(thisMovie);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
            _db.Movies.Remove(thisMovie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}