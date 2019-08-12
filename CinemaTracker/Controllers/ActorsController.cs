using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CinemaTracker.Models;

namespace CinemaTracker.Controllers
{
    public class ActorsController : Controller
    {
        private readonly CinemaTrackerContext _db;
        public ActorsController(CinemaTrackerContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Actor> Actors = _db.Actors.ToList();
            return View();
        }

        public ActionResult Details(int id)
        {
            var thisActor = _db.Actors
                .Include(actor => actor.Movies)
                .ThenInclude(join => join.Actor)
                .FirstOrDefault(actor => actor.ActorId == id);
            return View(thisActor);
        }

        public ActionResult Edit(int id)
        {
            var thisActor = _db.Actors.FirstOrDefault(actor => actor.ActorId == id);
            return View(thisActor);
        }

        [HttpPost]
        public ActionResult Edit(Actor actor)
        {
            _db.Entry(actor).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details", actor.ActorId);
        }

        public ActionResult Delete(int id)
        {
            var thisActor = _db.Actors.FirstOrDefault(actor => actor.ActorId == id);
            return View(thisActor);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var thisActor = _db.Actors.FirstOrDefault(actor => actor.ActorId == id);
            _db.Actors.Remove(thisActor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }


}