using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        // GET: Catalogue
        public IActionResult Index()
        {
            // Books list
            IList<Book> books = new List<Book>();
            books = Repository.Products.OfType<Book>().ToList();
            ViewBag.Books = books;

            // MusicCDs list
            IList<MusicCD> musicCDs = new List<MusicCD>();
            musicCDs = Repository.Products.OfType<MusicCD>().ToList();
            ViewBag.MusicCDs = musicCDs;


            // Movies list
            IList<Movie> movies = new List<Movie>();
            movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.Movies = movies;

            return View();
            
        }
    }
}