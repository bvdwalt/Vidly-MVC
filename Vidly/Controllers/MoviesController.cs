using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Shrek" };
            //return View(movie);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;

            if (string.IsNullOrEmpty(sortBy)) sortBy = "Name";

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }
    }
}