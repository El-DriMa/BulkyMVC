using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public MovieController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Movie> objMoviesList = dbContext.Movies.ToList();
            return View(objMoviesList);
           // return View();  
        }
    }
}
