using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random

        //This method uses attributed Route
        //[Route("movies/released/{year}/(Month:regex(\\d{4}):range(1,12)}")]



        //Following uses 'standard' method of route/controller pairs
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var viewResult  = new ViewResult();
            var customers = new List<Customer>
                {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
                };
             
            return View(movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue )
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0}&sortBy={1}",pageIndex ,sortBy ));
            
        }

        public ActionResult ByReleaseDate(int Year, int Month)
        {
            return Content (Year+"/"+Month);
        }

        
    }
}