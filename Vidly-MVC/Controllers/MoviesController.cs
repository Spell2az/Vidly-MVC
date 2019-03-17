using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        List<Movie> movies = new List<Movie>()
        {
            new Movie(){Id = 1, Title = "Shrek"},
            new Movie(){Id = 2, Title = "Spiderman"}
        };
        public ActionResult Index()
        {
            return View(movies);
        }
    }
}