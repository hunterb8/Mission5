using FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private FilmCollectionContext _FilmContext { get; set; }

        public HomeController(FilmCollectionContext a)
        {
            _FilmContext = a;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewMovies()
        {
            var filmslist = _FilmContext.Films
                .Include(y => y.Category)
                .ToList();

            return View(filmslist);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _FilmContext.Categories.ToList();
            
            return View();
        }
            
        [HttpPost]
        public IActionResult AddMovie (NewMovie movie)
        {
            _FilmContext.Add(movie);
            _FilmContext.SaveChanges();

            return View("ConfirmationPage", movie);
        }

        public IActionResult Edit()
        {
            ViewBag.Categories = _FilmContext.Categories.ToList();

            return View("AddMovie");
        }

        public IActionResult Delete()
        {
            return View();
        }


    }
}
