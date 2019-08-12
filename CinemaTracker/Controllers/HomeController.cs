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
        [HttpGet("/")]
        //does that matter?
        public ActionResult Index()
        {
            return View();
        }
    }
}