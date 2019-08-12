using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CinemaTracker.Models;

namespace CinemaTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly CinemaTrackerContext _db;
        public HomeController(CinemaTrackerContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        //does that matter?
        public ActionResult Index()
        {
            var model = _db.Genres.
            Include(genre => genre.Movies)
            .ThenInclude(join => join.Movie)
            .ToList();
            return View(model);


        }
    }
}